using LabTrack.DAL;
using LabTrack.DTO;
using LabTrack.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace LabTrack.Forms
{
    public partial class Productivity : Form
    {
        public int Second { get; set; }
        public int SecondsForLoop { get; set; }
        public static bool IsAdministrationOn { get; set; }
     
        private List<CaseControlDto> _listCases;
        private List<CaseControlDto> _listCasesClosed;
        private static UnitOfWork _unitOfWork;
        private readonly List<Configuration> _listConfig;
        private List<Area> _listAreas;
        private int _idCaseControl;
        private void InitialCharge()
        {
            try
            {
                FillListForDataGrid();
                dgvData.DataSource = _listCases;
                dgvDataEnd.DataSource = _listCasesClosed;
                _listAreas = _unitOfWork.DalAreas.ListAreas();
                _listAreas.Insert(0, new Area { Id = 0, Name = "All Areas" });
                dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dgvDataEnd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                cbxAreaFilter.DataSource = _listAreas;
                cbxAreaFilter.ValueMember = "id";
                cbxAreaFilter.DisplayMember = "name";
            }
            catch (Exception ex)
            {
                General.ControlErrorEx(ex);
                throw;
            }
        }

        private void CreateCase()
        {
            int nro;
            var idScanner = txtCode.Text[0];
            int.TryParse(txtCode.Text.Substring(1), out nro);
            var singleOrDefault =
                _listAreas.SingleOrDefault(
                    x => string.Equals(x.Symbol, idScanner.ToString(), StringComparison.CurrentCultureIgnoreCase));
            if (singleOrDefault == null) return;
            var idArea = singleOrDefault.Id;
            var objCase = _unitOfWork.DalCases.FindCaseByCode(nro);
            if (objCase != null)
            {
                CreateModifyCaseControl(nro, idArea, objCase);
            }
            else
            {
                string message = $"Case num: {nro} not exist,\r\ndo you want to create it?";
                if (AutoClosingMessageBox.Show(message, "Error", 5000, MessageBoxButtons.OKCancel) != DialogResult.OK)
                    return;
                if (IsAdministrationOn)
                {
                    objCase = CreateCaseDb(nro);
                    CreateModifyCaseControl(nro, idArea, objCase, true);
                }
                else
                {
                    var objAdmin = new Admin(_unitOfWork, IsAdministrationOn);
                    objAdmin.ShowDialog();
                    IsAdministrationOn = objAdmin.IsLoged;
                    if (IsAdministrationOn)
                    {
                        objCase = CreateCaseDb(nro);
                        CreateModifyCaseControl(nro, idArea, objCase, true);
                    }
                }
                IsAdministrationOn = false;
            }
        }

        private void ReloadGrids()
        {
            FillListForDataGrid(((Area)cbxAreaFilter.SelectedItem).Id);
            dgvData.DataSource = _listCases;
            dgvDataEnd.DataSource = _listCasesClosed;
        }

        private void ProductivityForm_Load(object sender, EventArgs e)
        {
            try
            {
                var singleOrDefault = _listConfig.SingleOrDefault(x => x.Name == "xDaysMaximun");
                if (singleOrDefault != null)
                    lblRed.Text =
                        $"Cases open with more than:\r\n{singleOrDefault.Value} days.";
                var orDefault = _listConfig.SingleOrDefault(x => x.Name == "xDaysMinimun");
                if (orDefault != null)
                {
                    var configuration = _listConfig.SingleOrDefault(x => x.Name == "xDaysMaximun");
                    if (configuration != null)
                        lblYellow.Text =
                            $"Cases open between:\r\n{orDefault.Value} " +
                            $" and  {configuration.Value} days.";
                }
                var @default = _listConfig.SingleOrDefault(x => x.Name == "xDaysMinimun");
                if (@default != null)
                    lblGreen.Text =
                        $"Cases open with less than:\r\n{@default.Value} days.";
            }
            catch (Exception ex)
            {
                General.ControlErrorEx(ex);
                AutoClosingMessageBox.Show("Error not controled, contact the administrator", "Error", 5000, MessageBoxButtons.OKCancel);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
                if (Second > 5)
                {
                    if (!txtCode.Focused && IsAccessible)
                    {
                        txtCode.Focus();
                        Second = 0;
                    }
                }

                var firstOrDefault = _listConfig.FirstOrDefault(x => x.Name == "ChangeAreasSeconds");
                if (firstOrDefault != null && SecondsForLoop >= int.Parse(firstOrDefault.Value))
                {
                    var i = cbxAreaFilter.SelectedIndex;
                    if (i >= cbxAreaFilter.Items.Count - 1)
                    {
                        i = 1;
                        cbxAreaFilter.SelectedIndex = i;
                    }
                    else
                    {
                        cbxAreaFilter.SelectedIndex = i + 1;
                    }
                    SecondsForLoop = 0;

                }
                Second++;
                SecondsForLoop++;
            }
            catch (Exception ex)
            {
                General.ControlErrorEx(ex);
                throw;
            }

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            General.ShowHistoryOfCase(_unitOfWork, IsAdministrationOn);
        }

        private void MenuItem1_Click(object sender, EventArgs e)
        {
            var singleOrDefault = _listCasesClosed.SingleOrDefault(x => x.Id == _idCaseControl);
            if (singleOrDefault != null)
            {
                var message = $"Are you sure you want to delete\r\nthe finish time of the case:{singleOrDefault.Code}";
                var rspt = AutoClosingMessageBox.Show(message, "Confirm", 10000, MessageBoxButtons.OKCancel);
                if (rspt != DialogResult.OK) return;
            }

            CaseControl caseClosed;
            if (GetCaseClosed(out caseClosed)) return;
            caseClosed.dtFinish = null;
            _unitOfWork.SaveData();

            ReloadGrids();
        }

        private void MenuItem2_Click(object sender, EventArgs e)
        {
            var singleOrDefault = _listCasesClosed.SingleOrDefault(x => x.Id == _idCaseControl);
            if (singleOrDefault != null)
            {
                var message = $"Are you sure you want to delete\r\nthe start and finish time of the case:{singleOrDefault.Code}";
                var title = "Confirm";
                var rspt = AutoClosingMessageBox.Show(message, title, 10000, MessageBoxButtons.OKCancel);
                if (rspt != DialogResult.OK) return;
            }

            CaseControl caseClosed;
            if (GetCaseClosed(out caseClosed)) return;
            caseClosed.dtFinish = null;
            caseClosed.dtStart = null;
            _unitOfWork.SaveData();

            ReloadGrids();
        }

        private void MenuItem3_Click(object sender, EventArgs e)
        {
            var singleOrDefault = _listCases.SingleOrDefault(x => x.Id == _idCaseControl);
            if (singleOrDefault != null)
            {
                var message = $"Are you sure you want to delete\r\nthe start date of the case:{singleOrDefault.Code}";
                var title = "Confirm";
                var rspt = AutoClosingMessageBox.Show(message, title, 10000, MessageBoxButtons.OKCancel);
                if (rspt != DialogResult.OK) return;
            }

            CaseControl caseClosed;
            if (GetCaseClosed(out caseClosed)) return;
            caseClosed.dtFinish = null;
            caseClosed.dtStart = null;
            _unitOfWork.SaveData();

            ReloadGrids();
        }

        private void MenuItem4_Click(object sender, EventArgs e)
        {
            var singleOrDefault = _listCasesClosed.SingleOrDefault(x => x.Id == _idCaseControl);
            if (singleOrDefault?.Code == null) return;
            var casesTrack = _unitOfWork.DalCasesControl.ListCasesByCode((int)singleOrDefault.Code);
            var trackCasesF = new TrackingCases(casesTrack);
            trackCasesF.ShowDialog();
        }

        private void MenuItem5_Click(object sender, EventArgs e)
        {
            var singleOrDefault = _listCases.SingleOrDefault(x => x.Id == _idCaseControl);
            var changeArea = new ChangeArea(_unitOfWork);
            if (singleOrDefault != null)
                changeArea.CaseControl = new CaseControl { code = singleOrDefault.Code, Id = singleOrDefault.Id };
            changeArea.ShowDialog();
            FillListForDataGrid();
            dgvData.DataSource = _listCases;
            dgvDataEnd.DataSource = _listCasesClosed;
        }

        private void MenuItem6_Click(object sender, EventArgs e)
        {
            var singleOrDefault = _listCases.SingleOrDefault(x => x.Id == _idCaseControl);
            var modifyUnits = new ModifyUnits(_unitOfWork);
            if (singleOrDefault?.Code != null)
                modifyUnits.Case = new Case { Code = (int)singleOrDefault.Code };
            modifyUnits.ShowDialog();
            FillListForDataGrid();
            dgvData.DataSource = _listCases;
            dgvDataEnd.DataSource = _listCasesClosed;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            var f = new Admin(_unitOfWork, IsAdministrationOn)
            {
                WindowState = FormWindowState.Normal,
            };
            f.ShowDialog();
            IsAdministrationOn = f.IsLoged;
            btnAdmin.Text = IsAdministrationOn ? @"Log out" : @"Admin";

        }

        private void txtCode_Enter(object sender, EventArgs e)
        {
            txtCode.BackColor = Color.LightBlue;
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            txtCode.BackColor = Color.White;
        }

        private void cbxAreaFilter_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            ReloadGrids();
        }

        private void cbxNonStared_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbxNonStared.Checked)
            {
                dgvData.DataSource = ((List<CaseControlDto>)dgvData.DataSource).Where(
                    x => x.DtStart != null).ToList();
            }
            else
            {
                dgvData.DataSource = _listCases;
            }
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar != Convert.ToChar(Keys.Enter)) return;
                var singleOrDefault = _listAreas
                    .SingleOrDefault(x => string.Equals(x.Symbol, txtCode.Text[0].ToString(), StringComparison.CurrentCultureIgnoreCase));
                CreateCase();
                IncloseCase(((Area)cbxAreaFilter.SelectedItem).Id);


                if (singleOrDefault != null) cbxAreaFilter.SelectedItem = singleOrDefault;
                SecondsForLoop = 0;
                var simpleSound = new SoundPlayer(Resources.beep_short_on);
                simpleSound.Play();
                e.Handled = true;
            }
            catch (Exception)
            {
                AutoClosingMessageBox.Show($"Error not controled, contact the administrator", "Error", 5000);
            }
        }

        private void dgvDataEnd_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!IsAdministrationOn) return;
            if (e.Button != MouseButtons.Right || e.ColumnIndex != 0) return;

            _idCaseControl = (int)dgvDataEnd.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            var m = new ContextMenu();
            var menuItem1 = new MenuItem("Remove Date Finish");
            menuItem1.Click += MenuItem1_Click;
            m.MenuItems.Add(menuItem1);
            var menuItem2 = new MenuItem("Remove Date Start and Finish");
            menuItem2.Click += MenuItem2_Click;
            m.MenuItems.Add(menuItem2);
            var menuItem4 = new MenuItem("Track of the case");
            menuItem4.Click += MenuItem4_Click;
            m.MenuItems.Add(menuItem4);
            var currentMouseOverRow = dgvDataEnd.HitTest(e.X, e.Y).RowIndex;
            if (currentMouseOverRow >= 0)
            {
                m.MenuItems.Add(new MenuItem($"Do something to row {currentMouseOverRow}"));
            }

            m.Show(dgvDataEnd, new Point(e.X, e.Y));
        }

        private void dgvData_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!IsAdministrationOn) return;
            if (e.Button != MouseButtons.Right || e.ColumnIndex != 0) return;

            _idCaseControl = (int)dgvData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            var m = new ContextMenu();
            var menuItem3 = new MenuItem("Remove date start");
            menuItem3.Click += MenuItem3_Click;
            m.MenuItems.Add(menuItem3);
            var menuItem5 = new MenuItem("Change area");
            menuItem5.Click += MenuItem5_Click;
            m.MenuItems.Add(menuItem5);
            var menuItem6 = new MenuItem("Change Units");
            menuItem6.Click += MenuItem6_Click;
            m.MenuItems.Add(menuItem6);
            m.Show(dgvData, new Point(e.X, e.Y));
        }

        private void dgvData_RowPrePaint_1(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var dtFinish = _listCases[e.RowIndex].DtFinish;
            var dtRecive = _listCases[e.RowIndex].DtRecive;
            var dtStart = _listCases[e.RowIndex].DtStart;
            if (dtRecive == null) return;
            var difDates = General.DaysLeft((DateTime)dtRecive, DateTime.Now, true, General.GetHolidays(DateTime.Now.Year));
            var singleOrDefault = _listConfig.SingleOrDefault(x => x.Name == "xDaysMaximun");
            if (singleOrDefault == null) return;
            var xDaysMaximun = int.Parse(singleOrDefault.Value);
            singleOrDefault = _listConfig.SingleOrDefault(x => x.Name == "xDaysMinimun");
            if (singleOrDefault == null) return;
            var xDaysMinimun = int.Parse(singleOrDefault.Value);

            if (dtFinish == null)
            {
                if (dtStart != null)
                {
                    dgvData.Rows[e.RowIndex].DefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.Green };
                }
                else if (difDates < xDaysMinimun)
                {
                    dgvData.Rows[e.RowIndex].DefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.White };
                }
                else if (xDaysMinimun <= difDates && difDates < xDaysMaximun)

                {
                    dgvData.Rows[e.RowIndex].DefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.Yellow };
                }
                else if (difDates >= xDaysMaximun)
                {
                    dgvData.Rows[e.RowIndex].DefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.Red };
                }
            }
            else
            {
                dgvData.Rows[e.RowIndex].DefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.White };
            }
        }

        private void FillListForDataGrid(int intFilter = 0)
        {
            if (intFilter == 0)
            {
                _listCasesClosed = ListCases().Where(x => x.DtFinish != null).OrderByDescending(x => x.DtStart).ToList();
                _listCases = ListCases().Where(x => x.DtFinish == null).OrderByDescending(x => x.DtStart).ToList();
            }
            else
            {
                _listCasesClosed =
                    ListCases()
                        .Where(x => x.DtFinish != null && x.IdArea == intFilter)
                        .OrderByDescending(x => x.DtStart)
                        .ToList();
                _listCases =
                    ListCases()
                        .Where(x => x.DtFinish == null && x.IdArea == intFilter)
                        .OrderByDescending(x => x.DtStart)
                        .ToList();
            }
        }

        private void IncloseCase(int idArea = 0)
        {
            if (idArea > 0)
            {
                _listCasesClosed =
                    ListCases()
                        .Where(x => x.DtFinish != null && x.IdArea == idArea)
                        .OrderByDescending(x => x.Id)
                        .ToList();
                _listCases =
                    ListCases()
                        .Where(x => x.DtFinish == null && x.IdArea == idArea)
                        .OrderByDescending(x => x.Id)
                        .ToList();
            }
            else
            {
                _listCasesClosed = ListCases()
                    .Where(x => x.DtFinish != null)
                    .OrderByDescending(x => x.Id).ToList();
                _listCases = ListCases()
                    .Where(x => x.DtFinish == null)
                    .OrderByDescending(x => x.Id).ToList();
            }
            dgvData.DataSource = _listCases;
            dgvDataEnd.DataSource = _listCasesClosed;
            txtCode.Text = string.Empty;
        }

        private static Case CreateCaseDb(int nro)
        {
            var objCase = new Case();
            var singleOrDefault = _unitOfWork.ListConfigurations().SingleOrDefault(x => x.Name == "xETADefault");
            if (singleOrDefault != null)
                objCase = new Case
                {
                    Code = nro,
                    DateCreation = DateTime.Now,
                    ETA = int.Parse(singleOrDefault.Value),
                    IsInProduction = false,
                    Units = 1,
                    IdCompany = 2
                };
            _unitOfWork.DalCases.CreateCase(objCase);
            _unitOfWork.SaveData();
            return objCase;
        }

        private static void SaveData(Case objCase)
        {
            objCase.IsInProduction = true;
            _unitOfWork.SaveData();
        }
        
        private bool GetCaseClosed(out CaseControl caseClosed)
        {
            caseClosed = _unitOfWork.DalCasesControl.GetCaseById(_idCaseControl);
            return caseClosed == null;
        }

        private void CreateModifyCaseControl(int nro, int idArea, Case objCase, bool isUnderGround = false)
        {
            try
            {
                var title = "Successfull";
                var message = string.Empty;
                var data = _unitOfWork.DalCasesControl.GetCaseControlByIdAreaAndCode(nro, idArea);

                if (data != null)
                {
                    if (data.dtFinish != null || data.dtStart != null)
                    {
                        if (data.dtFinish == null)
                        {
                            data.dtFinish = DateTime.Now;
                            if (data.dtStart != null)
                            {
                                var diference = ((DateTime)data.dtFinish - (DateTime)data.dtStart).TotalSeconds;

                                var singleOrDefault = _listConfig.SingleOrDefault(x => x.Name == "MinTimeAllowToFinish");
                                if (singleOrDefault != null)
                                {
                                    var timeAllow = int.Parse(singleOrDefault.Value);

                                    if (diference >= timeAllow)
                                    {
                                        SaveFinish(nro, objCase, data, out message, out title);
                                    }
                                    else
                                    {
                                        title = "Error Time";
                                        message =
                                            $"Case nro {nro} was Started at: {data.dtRecive} you need at less \r\n{timeAllow / 60} minutes to close the case";
                                        AutoClosingMessageBox.Show(message, title, 10000, MessageBoxButtons.OKCancel);
                                        return;
                                    }
                                }
                            }
                        }
                        else
                        {
                            title = "History";
                            message =
                                $"Case nro {nro} was Create and saved at:Recived{data.dtRecive} \r\n Started{data.dtStart}\r\n Finished{data.dtFinish}";
                        }
                    }
                    else
                    {
                        data.dtStart = DateTime.Now;
                        title = "Started";
                        message = $"Case number {nro}\r\nWill be started at {data.dtStart}.";
                    }
                }
                else
                {
                    var areaConsult = _listAreas.SingleOrDefault(x => x.Id == idArea);

                    var today = DateTime.Now;
                    data = General.CreateCaseControl(_unitOfWork, nro, null, today, areaConsult);

                    title = "Created";
                    message = $"Case number {nro}\r\nWill be Created at {DateTime.Now}";
                }
                if (isUnderGround)
                {
                    SaveData(objCase);
                    return;
                }
                var rspt = AutoClosingMessageBox.Show(message, title, 10000, MessageBoxButtons.OKCancel);
                if (rspt == DialogResult.OK)
                {
                    SaveData(objCase);
                }
                else
                {
                    switch (title)
                    {
                        case "Started":
                            if (data != null) data.dtStart = null;
                            break;
                        case "Created":
                            if (data != null) data.dtRecive = null;
                            break;
                        case "Finish":
                        case "Error Time":
                            if (data != null) data.dtFinish = null;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                General.ControlErrorEx(ex);
                AutoClosingMessageBox.Show($"Error not controled, contact the administrator", "Error", 5000, MessageBoxButtons.OKCancel);
            }
        }
        
        private static void SaveFinish(int nro, Case objCase, CaseControl data, out string message, out string title)
        {
            objCase.DateFinish = data.dtFinish;
            message = $"Case number {nro}\r\n was Finished at {data.dtFinish}";
            title = "Finish";
            if (objCase.DateFinish != null)
            {
                if (data.dtStart != null)
                {
                    var seconds =
                        ((DateTime)objCase.DateFinish).Subtract(((DateTime)data.dtStart)).TotalSeconds;

                    //var time = General.DaysLeft((DateTime)data.dtStart, (DateTime)objCase.DateFinish, true,
                    //General.GetHolidays(DateTime.Now.Year));
                    if (data.dtRecive == null)
                        objCase.TimeInproduction = (int)seconds;
                }
            }
            objCase.IsInProduction = false;
        }

        public List<CaseControlDto> ListCases()
        {
            return _unitOfWork.DalCasesControl.ListCases();
        }

        public Productivity(UnitOfWork unitOfWork, bool isAdministrationOn)
        {

            IsAdministrationOn = isAdministrationOn;
            _unitOfWork = unitOfWork;
            InitializeComponent();
            InitialCharge();
            _listConfig = _unitOfWork.ListConfigurations();
            Second = 0;
            timer1.Interval = 1000;
            timer1.Start();

        }
    }
}
