using LabTrack.DAL;
using LabTrack.DTO;
using LabTrack.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
        public bool IsAdministrationOn { get; set; }
        //public IUnitOfWork InitOfWork { get; set; }
        private List<CaseControlDto> _listCases;

        private List<CaseControlDto> _listCasesClosed;
        private static UnitOfWork _unitOfWork;

        private readonly List<Configuration> _listConfig;
        private List<Area> _listAreas;

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

        private void InitialCharge()
        {
            FillListForDataGrid();
            dgvData.DataSource = _listCases;
            dgvDataEnd.DataSource = _listCasesClosed;
            _listAreas = _unitOfWork.DalAreas.ListAreas();
            _listAreas.Insert(0, new Area { Id = 0, Name = "All Areas" });

            cbxAreaFilter.DataSource = _listAreas;
            cbxAreaFilter.ValueMember = "id";
            cbxAreaFilter.DisplayMember = "name";
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
            //_listCases.AddRange(listCasesCosed);

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
                    CreateCase(nro);
                    CreateModifyCaseControl(nro, idArea, objCase);
                }
                else
                {
                    var objAdmin = new Admin(_unitOfWork, IsAdministrationOn);
                    objAdmin.ShowDialog();
                    IsAdministrationOn = objAdmin.IsLoged;
                    if (IsAdministrationOn)
                    {
                        CreateCase(nro);
                        CreateModifyCaseControl(nro, idArea, objCase);
                    }
                }
                IsAdministrationOn = false;
            }
            cbxAreaFilter.SelectedValue = IdArea;

        }

        private static void CreateCase(int nro)
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
                    Units = int.Parse("1")
                };
            _unitOfWork.DalCases.CreateCase(objCase);
            _unitOfWork.SaveData();
        }

        [SuppressMessage("ReSharper", "PossibleInvalidOperationException")]
        private void CreateModifyCaseControl(int nro, int idArea, Case objCase)
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
                        var diference = ((DateTime)data.dtFinish - (DateTime)data.dtStart).TotalSeconds;

                        var singleOrDefault = _listConfig.SingleOrDefault(x => x.Name == "MinTimeAllowToFinish");
                        if (singleOrDefault != null)
                        {
                            var timeAllow = int.Parse(singleOrDefault.Value);

                            if (diference >= timeAllow)
                            {
                                objCase.DateFinish = data.dtFinish;
                                message = $"Case number {nro}\r\n was Finished at {data.dtFinish}";

                                var seconds =
                                    ((DateTime)objCase.DateFinish).Subtract(((DateTime)data.dtStart)).TotalSeconds;

                                var time = General.DaysLeft((DateTime)data.dtStart, (DateTime)objCase.DateFinish, true, General.GetHolidays(DateTime.Now.Year));
                                if (data.dtRecive != null)
                                {
                                    objCase.TimeInproduction = (int)seconds;
                                    objCase.IsInProduction = false;
                                }
                            }
                            else
                            {
                                title = "Error";
                                message =
                                    $"Case nro {nro} was Started at: {data.dtRecive} you need at less \r\n{timeAllow / 60} minutes to close the case";
                                AutoClosingMessageBox.Show(message, title, 10000, MessageBoxButtons.OKCancel);
                                return;
                            }
                        }
                    }
                    else
                    {
                        title = "Alert";
                        message =
                            $"Case nro {nro} was Create and saved at:Recived{data.dtRecive} \r\n Started{data.dtStart}\r\n Finished{data.dtFinish}";
                    }
                }
                else
                {
                    data.dtStart = DateTime.Now;
                    title = "Successfull";
                    message = $"Case number {nro}\r\nWill be started at {data.dtStart}.";
                }
            }
            else
            {
                _unitOfWork.DalCasesControl.CreateCaseControl(nro, idArea);
                title = "Successfull";
                message = $"Case number {nro}\r\nWill be Created at {DateTime.Now}";
            }
            var rspt = AutoClosingMessageBox.Show(message, title, 10000, MessageBoxButtons.OKCancel);
            if (rspt != DialogResult.OK)
            {
                return;
            }
            objCase.IsInProduction = true;
            _unitOfWork.SaveData();
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
                _listCasesClosed = ListCases().Where(x => x.DtFinish != null).OrderByDescending(x => x.Id).ToList();
                _listCases = ListCases().Where(x => x.DtFinish == null).OrderByDescending(x => x.Id).ToList();
            }
            dgvData.DataSource = _listCases;
            dgvDataEnd.DataSource = _listCasesClosed;
            txtCode.Text = string.Empty;
            var simpleSound = new SoundPlayer(Resources.beep_short_on);
            simpleSound.Play();
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar != Convert.ToChar(Keys.Enter)) return;
                CreateCase();
                IncloseCase(((Area)cbxAreaFilter.SelectedItem).Id);
                e.Handled = true;
            }
            catch (Exception)
            {
                var message = $"Error not controled, contact the administrator";
                var title = "Error";
                AutoClosingMessageBox.Show(message, title, 5000, MessageBoxButtons.OKCancel);
            }

        }

        public List<CaseControlDto> ListCases()
        {
            return _unitOfWork.DalCasesControl.ListCases();
        }

        [SuppressMessage("ReSharper", "PossibleNullReferenceException")]
        private void ProductivityForm_Load(object sender, EventArgs e)
        {
            try
            {
                lblRed.Text =
                                $"Cases open with more than:\r\n{_listConfig.SingleOrDefault(x => x.Name == "xDaysMaximun").Value} days.";
                lblYellow.Text =
                    $"Cases open between:\r\n{_listConfig.SingleOrDefault(x => x.Name == "xDaysMinimun").Value} " +
                    $" and  {_listConfig.SingleOrDefault(x => x.Name == "xDaysMaximun").Value} days.";
                lblGreen.Text =
                    $"Cases open with less than:\r\n{_listConfig.SingleOrDefault(x => x.Name == "xDaysMinimun").Value} days.";
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            if (Second > 5)
            {
                if (!txtCode.Focused)
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



        private void btnInfo_Click(object sender, EventArgs e)
        {
            var dataCases = new DataCases(_unitOfWork, IsAdministrationOn);
            dataCases.ShowDialog();
        }

        private int _idCaseControl;

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
        private void MenuItem1_Click(object sender, EventArgs e)
        {
            var singleOrDefault = _listCasesClosed.SingleOrDefault(x => x.Id == _idCaseControl);
            if (singleOrDefault != null)
            {
                var message = $"Are you sure you want to delete\r\nthe finish time of the case:{singleOrDefault.Code}";
                var title = "Confirm";
                var rspt = AutoClosingMessageBox.Show(message, title, 10000, MessageBoxButtons.OKCancel);
                if (rspt != DialogResult.OK) return;
            }

            CaseControl caseClosed;
            if (GetCaseClosed(out caseClosed)) return;
            caseClosed.dtFinish = null;
            _unitOfWork.SaveData();

            ReloadGrids();
        }

        private bool GetCaseClosed(out CaseControl caseClosed)
        {
            caseClosed = _unitOfWork.DalCasesControl.GetCaseById(_idCaseControl);
            if (caseClosed == null) return true;
            return false;
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

        private void ReloadGrids()
        {
            FillListForDataGrid(((Area)cbxAreaFilter.SelectedItem).Id);
            dgvData.DataSource = _listCases;
            dgvDataEnd.DataSource = _listCasesClosed;
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

        private void dgvData_RowPrePaint_1(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var dtFinish = _listCases[e.RowIndex].DtFinish;
            var dtRecive = _listCases[e.RowIndex].DtRecive;
            var dtStart = _listCases[e.RowIndex].DtStart;
            if (dtRecive == null) return;
            var difDates = General.DaysLeft((DateTime)dtRecive, DateTime.Now, true,
                General.GetHolidays(DateTime.Now.Year));
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

        private void cbxAreaFilter_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            ReloadGrids();
        }

        private void dgvData_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!IsAdministrationOn) return;
            if (e.Button != MouseButtons.Right || e.ColumnIndex != 0) return;

            _idCaseControl = (int)dgvData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            var m = new ContextMenu();
            var menuItem3 = new MenuItem("Remove Date start");
            menuItem3.Click += MenuItem3_Click;
            m.MenuItems.Add(menuItem3);

            m.Show(dgvData, new Point(e.X, e.Y));
        }

        private void MenuItem4_Click(object sender, EventArgs e)
        {
            var singleOrDefault = _listCasesClosed.SingleOrDefault(x => x.Id == _idCaseControl);
            if (singleOrDefault?.Code == null) return;
            var casesTrack = _unitOfWork.DalCasesControl.ListCasesByCode((int)singleOrDefault.Code);
            var trackCasesF = new TrackingCases(casesTrack);
            trackCasesF.ShowDialog();
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
            txtCode.BackColor = Color.LightGray;
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            txtCode.BackColor = Color.White;
        }

        private void cbxNonStared_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbxNonStared.Checked)
            {
                dgvData.DataSource = ((List<CaseControlDto>)dgvData.DataSource).Where(
                    x => x.DtStart != null ).ToList();
            }
            else
            {
                dgvData.DataSource = _listCases;
            }
        }
    }
}
