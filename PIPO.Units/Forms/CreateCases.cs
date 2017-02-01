using LabTrack.DAL;
using LabTrack.Interfaces;
using LabTrack.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace LabTrack.Forms
{
    public partial class CreateCases : Form
    {
        public bool IsAdministrationOn { get; set; }
        private static IUnitOfWork UnitOfWork { get; set; }
        private List<Case> ListCases { get; set; }
        private List<Area> ListArea { get; set; }
        private List<Company> ListCompanies { get; set; }
        Case _objCase;
        public CreateCases(IUnitOfWork unitOfWork, bool isAdministrationOn)
        {
            UnitOfWork = unitOfWork;
            IsAdministrationOn = isAdministrationOn;
            InitializeComponent();
            InitialLoad();
            var listConfig = UnitOfWork.ListConfigurations();
            var singleOrDefault = listConfig.SingleOrDefault(x => x.Name == "xETADefault");
            if (singleOrDefault != null)
                lblMessageETA.Text = $"Time production by default is {singleOrDefault.Value} days";
        }

        private void InitialLoad()
        {
            ListCases = UnitOfWork.DalCases.ListCases().OrderByDescending(x => x.DateCreation).ToList();
            ListCompanies = UnitOfWork.DalCompany.ListCompanies().OrderBy(x => x.Id).ToList();
            ListArea = UnitOfWork.DalAreas.ListAreas();
        }

        private void CreateCases_Load(object sender, EventArgs e)
        {
            ChargeList();
        }

        private void ChargeList()
        {
            FillListBox(lboxCases, ListCases, "Id", "code");
            FillListBox(lbxCompany, ListCompanies, "Id", "Name");
        }

        private static void FillListBox(ListControl controlListBox, IEnumerable source, string valueMember, string displayMember)
        {
            controlListBox.DataSource = source;
            controlListBox.ValueMember = valueMember;
            controlListBox.DisplayMember = displayMember;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ExtendedMsgBox.ExtendeMessagesShow();
        }

        private static void SearchAndCleanControl(IEnumerable controlList)
        {
            var enumerable = controlList as IList<object> ?? controlList.Cast<object>().ToList();
            foreach (var control in enumerable.Cast<Control>().Where(control => control.GetType() == typeof(TextBox)))
            {
                control.Text = string.Empty;
            }
            foreach (var control in enumerable.Cast<Control>().Where(control => control.GetType() == typeof(NumericUpDown)))
            {
                control.Text = @"1";
            }

        }

        private void txtCodeFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            General.ValidNumber(e);
            if (!string.IsNullOrWhiteSpace(txtCodeFind.Text))
            {
                var nro = int.Parse(txtCodeFind.Text);
                lboxCases.DataSource = ListCases.Where(x => x.Code == nro).ToList();
            }
            else
            {
                InitialLoad();
                ChargeList();
            }
        }

        private void lboxCases_SelectedIndexChanged(object sender, EventArgs e)
        {
            _objCase = (Case)lboxCases.SelectedItem;
            ChargeValuesText();
            nudUnitsManual.Enabled = _objCase.DateFinish == null;
            nudUnitsScaner.Enabled = _objCase.DateFinish == null;
        }

        private void ChargeValuesText()
        {
            txtCode.Text = _objCase.Code.ToString();
            txtBarCodeScanned.Text = _objCase.Code.ToString();
            txtDateCreation.Text = _objCase.DateCreation.ToString(CultureInfo.InvariantCulture);
            nudTimeETA.Text = _objCase.ETA.ToString();
            nudUnitsManual.Text = _objCase.Units.ToString();
            nudUnitsScaner.Text = _objCase.Units.ToString();
        }

        private void txtCodeBCS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != Convert.ToChar(Keys.Enter)) return;
            CreateCase();
            txtBarCodeScanned.Focus();
        }

        private void CreateCaseControl()
        {
            var nro = Convert.ToInt16(txtBarCodeScanned.Text.Length == 5 ? txtBarCodeScanned.Text.Substring(1) : txtBarCodeScanned.Text);
            var singleOrDefault = ListArea.SingleOrDefault(x => x.IsStart);
            if (singleOrDefault == null) return;
            var today = DateTime.Now;
            var data = new CaseControl();
            General.CreateCaseControl((UnitOfWork)UnitOfWork, nro, data, today, singleOrDefault);
        }

        private void CreateCase()
        {
            int code = Convert.ToInt16(txtBarCodeScanned.Text.Length == 5 ? txtBarCodeScanned.Text.Substring(1) : txtBarCodeScanned.Text);

            var iCode = ListCases.FirstOrDefault(c => c.Code == code);
            if (iCode != null)
            {
                if (!ValidateCase(iCode)) return;
                iCode.Units++;
            }
            else
            {
                var singleOrDefault = UnitOfWork.ListConfigurations().SingleOrDefault(x => x.Name == "xETADefault");
                if (singleOrDefault != null)
                {
                    var objCase = new Case
                    {
                        Code = code,
                        DateCreation = DateTime.Now,
                        ETA = int.Parse(string.IsNullOrWhiteSpace(nudTimeETA.Text) ? singleOrDefault.Value : nudTimeETA.Text),
                        IsInProduction = false,
                        Units = int.Parse(string.IsNullOrWhiteSpace(nudUnitsManual.Text) ? "1" : nudUnitsManual.Text),
                        Company = (Company)lbxCompany.SelectedItem

                    };
                    ((Company)lbxCompany.SelectedItem).MaxCodeActual = code;
                    UnitOfWork.DalCases.CreateCase(objCase);
                    CreateCaseControl();
                }
            }

            UnitOfWork.SaveData();
            InitialLoad();
            var copySelection = (Company)lbxCompany.SelectedItem;
            ChargeList();
            lbxCompany.SelectedItem = copySelection;
            SearchAndCleanControl(tpManual.Controls);
            SearchAndCleanControl(tpScan.Controls);
        }

        private static bool ValidateCase(Case iCode)
        {
            var singleOrDefault = UnitOfWork.ListConfigurations().SingleOrDefault(x => x.Name == "MaxUnitsPerCase");

            if (singleOrDefault == null || iCode.Units < int.Parse(singleOrDefault.Value)) return true;
            MessageBox.Show(Resources.CreateCases_ValidateCase_you_can_t_add_more_units_to_this_case);
            return false;
        }

        private void txtCode_Enter(object sender, EventArgs e)
        {
            SearchAndCleanControl(tpManual.Controls);
            nudUnitsScaner.Text = Resources.CreateCases_txtBarCodeScanned_Enter__0;
            nudUnitsManual.Text = Resources.CreateCases_txtBarCodeScanned_Enter__0;
            nudTimeETA.Text = Resources.CreateCases_txtBarCodeScanned_Enter__0;
        }

        private void txtBarCodeScanned_Enter(object sender, EventArgs e)
        {
            SearchAndCleanControl(tpScan.Controls);
            SearchAndCleanControl(tpManual.Controls);
            nudUnitsScaner.Text = Resources.CreateCases_txtBarCodeScanned_Enter__0;
        }

        private void AddRemoveUnitsScaner(bool isScanner)
        {
            _objCase.Units = _objCase != null && isScanner
                ? int.Parse(nudUnitsScaner.Text)
                : int.Parse(nudUnitsManual.Text);
            UnitOfWork.SaveData();
        }

        private void nudUnits_Click(object sender, EventArgs e)
        {
            AddRemoveUnitsScaner(true);
            ChargeValuesText();
        }

        private void nudUnitsManual_Click(object sender, EventArgs e)
        {
            AddRemoveUnitsScaner(false);
            ChargeValuesText();
        }

        private void nudTimeETA_Click(object sender, EventArgs e)
        {
            AddRemoveEtaScaner();
        }

        private void AddRemoveEtaScaner()
        {
            _objCase.ETA = int.Parse(nudTimeETA.Text);
        }

        private void txtCodeFind_Enter(object sender, EventArgs e)
        {
            txtCodeFind.Text = string.Empty;
        }

        private void lbxCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            var filterCases = ListCases.Where(x => x.IdCompany == ((Company)lbxCompany.SelectedItem).Id).ToList();
            FillListBox(lboxCases, filterCases, "Id", "code");
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCodeFind.Text))
            {
                var nro = int.Parse(txtCodeFind.Text);
                lboxCases.DataSource = ListCases.Where(x => x.Code == nro).ToList();
            }
            else
            {
                InitialLoad();
                ChargeList();
            }
        }

        private void lboxCases_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            General.ShowHistoryOfCase((UnitOfWork)UnitOfWork, IsAdministrationOn);
        }
    }
}
