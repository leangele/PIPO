using LabTrack.DAL;
using LabTrack.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LabTrack.Forms
{
    public partial class FinishCase : Form
    {
        public UnitOfWork UnitOfWork { get; set; }
        private readonly List<Area> _listAreas;
        public bool IsSearch { get; set; }
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
                var areaConsult = _listAreas.SingleOrDefault(x => x.Symbol == idScanner);
                var today = new DateTime(DateTime.Now.Year, DateTime.Now.Month, dtpDateClose.Value.Day, 18, 00, 00);
                if (areaConsult != null && areaConsult.IsEnd)
                {
                    var caseControSearch = UnitOfWork.DalCasesControl.GetCaseControlByIdAreaAndCode(nro, areaConsult.Id);

                    if (caseControSearch == null)
                    {
                        General.CreateCaseControl(UnitOfWork, nro, null, today, areaConsult);
                        CloseCaseControlsInChain(nro, today);
                        CloseCase(nro, today);
                        UnitOfWork.SaveData();
                        FillGrid(today);
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
                message = "Is necesary select a Date";
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
            if (dtpDateClose.Value > DateTime.Now)
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
            }
            var today = dtpDateClose.Value;
            FillGrid(today);
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
    }
}
