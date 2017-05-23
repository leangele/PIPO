using LabTrack.DAL;
using LabTrack.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LabTrack.Forms
{
    public partial class FinishCase : Form
    {
        public UnitOfWork UnitOfWork { get; set; }
        private int _idCaseControl;
        private readonly List<Area> _listAreas;
        public bool IsSearch { get; set; }
        public DateTime Today { get; set; }
        public FinishCase(UnitOfWork unitOfWork, bool isSearch)
        {
            UnitOfWork = unitOfWork;
            IsSearch = isSearch;
            InitializeComponent();
            _listAreas = UnitOfWork.DalAreas.ListAreas();
            dtpDateClose.Checked = false;
            dtpDateClose.ShowCheckBox = false;
        }

        private void FinishCase_Load(object sender, EventArgs e)
        {
            General.OpenAndCloseForm(Name);
            Text = IsSearch ? "Search" : "Finish";
            lblDateClose.Visible = !IsSearch;
            dtpDateClose.Visible = !IsSearch;
            lblSearch.Visible = IsSearch;
            txtSearch.Visible = IsSearch;
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != Convert.ToChar(Keys.Enter)) return;
            ValidateCreate();
            txtCode.Text = string.Empty;
        }

        private void ValidateCreate()
        {
            string message;
            var display = "error";


            if (dtpDateClose.Checked)
            {
                int nro;
                var idScanner = txtCode.Text[0].ToString();
                int.TryParse(txtCode.Text.Substring(1), out nro);
                var codeObj = UnitOfWork.DalCases.FindCaseByCode(nro);
                if (codeObj != null)
                {
                    var areaConsult = _listAreas.SingleOrDefault(x => x.Symbol == idScanner);
                    if (areaConsult != null && areaConsult.IsEnd)
                    {
                        var caseControSearch = UnitOfWork.DalCasesControl.GetCaseControlByIdAreaAndCode(nro,
                            areaConsult.Id);

                        if (caseControSearch == null)
                        {
                            General.CreateCaseControl(UnitOfWork, nro, null, Today, areaConsult);
                            CloseCaseControlsInChain(nro, Today);
                            CloseCase(nro, Today);
                            UnitOfWork.SaveData();
                            FillGrid(Today);
                            txtCode.Text = string.Empty;
                            return;
                        }
                        else
                        {
                            message = "Case Cosed before.";
                        }
                    }
                    else
                    {
                        message = "This Scanner dont own to finish area";
                    }
                }
                else
                {
                    message = "Case not created previusly";
                }
            }
            else
            {
                message = "Is necesary select a valid date";
            }
            if (!string.IsNullOrWhiteSpace(message))
            {
                AutoClosingMessageBox.Show(message, display, 5000);
            }
        }

        private void CloseCase(int nro, DateTime today)
        {
            var caseObj = UnitOfWork.DalCases.FindCaseByCode(nro);
            if (caseObj == null) return;
            caseObj.IsInProduction = false;
            caseObj.DateFinish = today;
            var time = (General.DaysLeft((DateTime)caseObj.DateCreation, today, true, General.GetHolidays(DateTime.Now.Year)) *
                        24) / 3;
            caseObj.ETA = time;
        }

        private void CloseCaseControlsInChain(int nro, DateTime today)
        {
            var listCasesNoClosed = UnitOfWork.DalCasesControl.ListCasesByCode(nro);
            foreach (var caseControlDto in listCasesNoClosed.Where(caseControlDto => !caseControlDto.DtFinish.HasValue))
            {
                UnitOfWork.DalCasesControl.ModifyByClose(new CaseControl
                {
                    code = nro,
                    dtFinish = today,
                    dtRecive = today,
                    idTechnitian = caseControlDto.IdArea
                });
            }
        }

        private List<CaseControlDto> ChargeSource(Area areaConsult, DateTime today)
        {
            var source = UnitOfWork.DalCasesControl.GetCaseControlsByIdArea(areaConsult.Id);
            source = source
                .Where(x => x.DtFinish != null &&
                            (x.DtFinish != null &
                             x.DtFinish.Value.Year == today.Year &
                             x.DtFinish.Value.Month == today.Month &
                             x.DtFinish.Value.Day == today.Day))
                .ToList();
            return source;
        }

        private void dtpDateClose_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDateClose.Value > DateTime.Now.AddDays(1))
            {
                dtpDateClose.Checked = false;
                dtpDateClose.ShowCheckBox = false;
            }
            else if (dtpDateClose.Value < DateTime.Now.AddDays(-4))
            {
                dtpDateClose.Checked = false;
                dtpDateClose.ShowCheckBox = false;
            }
            else
            {
                dtpDateClose.Checked = true;
                dtpDateClose.ShowCheckBox = true;
                Today = new DateTime(DateTime.Now.Year, DateTime.Now.Month, dtpDateClose.Value.Day, 18, 00, 00);
            }
            FillGrid(Today);
        }

        private void FillGrid(DateTime today)
        {
            var areaConsult = _listAreas.SingleOrDefault(x => x.IsEnd);
            var source = ChargeSource(areaConsult, today);
            dgvDataEnd.DataSource = source;
            dgvDataEnd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            int nro;
            if (e.KeyChar != Convert.ToChar(Keys.Enter)) return;
            int.TryParse(txtSearch.Text, out nro);
            var singleOrDefault = UnitOfWork.DalCasesControl.ListCasesByCode(nro).OrderByDescending(x => x.DtRecive).ToList();
            dgvDataEnd.DataSource = singleOrDefault;
            dgvDataEnd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dgvDataEnd_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.Button != MouseButtons.Right || e.ColumnIndex != 0) return;
                _idCaseControl = (int)dgvDataEnd.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                var m = new ContextMenu();
                var menuItem1 = new MenuItem("Add/Remove units");
                menuItem1.Click += MenuItem1_Click;
                m.MenuItems.Add(menuItem1);
                m.Show(dgvDataEnd, new Point(e.X, e.Y));
            }
            catch (Exception ex)
            {
                General.ControlErrorEx(ex, Name);

            }

        }

        private void MenuItem1_Click(object sender, EventArgs e)
        {
            var singleOrDefault = ((List<CaseControlDto>)dgvDataEnd.DataSource).SingleOrDefault(x => x.Id == _idCaseControl);
            var modifyUnits = new ModifyUnits(UnitOfWork);
            if (singleOrDefault?.Code != null)
                modifyUnits.Case = new Case { Code = (int)singleOrDefault.Code };
            modifyUnits.ShowDialog();
            FillGrid(Today);
        }
    }
}
