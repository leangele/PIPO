using LabTrack.DAL;
using LabTrack.Interfaces;
using LabTrack.Properties;
using System;
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
        Case _objCase;
        public CreateCases(UnitOfWork unitOfWork, bool isAdministrationOn)
        {
            UnitOfWork = unitOfWork;
            IsAdministrationOn = isAdministrationOn;
            InitializeComponent();
            InitialLoad();
            var listConfig = UnitOfWork.ListConfigurations();
            var singleOrDefault = listConfig.SingleOrDefault(x => x.Name == "xETADefault");
            if (singleOrDefault != null)
                lblMessageETA.Text = string.Format("Time production by default is {0} days", singleOrDefault.Value);
        }

        private void InitialLoad()
        {
            ListCases = UnitOfWork.DalCases.ListCases().OrderByDescending(x => x.DateCreation).ToList();
            lboxCases.DataSource = ListCases;
            lboxCases.ValueMember = "Id";
            lboxCases.DisplayMember = "code";

        }

        private void CreateCases_Load(object sender, EventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateCases())
            {
                var objCase = new Case
                {
                    Code = int.Parse(txtCode.Text),
                    DateCreation = DateTime.Now,
                    ETA = int.Parse(nudTimeETA.Text),
                    IsInProduction = false,
                    Units = int.Parse(nudUnitsManual.Text)
                };
                UnitOfWork.DalCases.CreateCase(objCase);
                UnitOfWork.SaveData();
                InitialLoad();
            }
            SearchAndCleanControl(tpManual.Controls);
            SearchAndCleanControl(tpScan.Controls);
        }

        private static void SearchAndCleanControl(Control.ControlCollection controlList)
        {
            foreach (var control in controlList.Cast<Control>().Where(control => control.GetType() == typeof(TextBox)))
            {
                control.Text = string.Empty;
            }
            foreach (var control in controlList.Cast<Control>().Where(control => control.GetType() == typeof(NumericUpDown)))
            {
                control.Text = @"1";
            }

        }

        private bool ValidateCases()
        {
            if (!string.IsNullOrWhiteSpace(txtCode.Text))
            {
                if (!string.IsNullOrWhiteSpace(nudTimeETA.Text))
                {
                    if (!string.IsNullOrWhiteSpace(nudUnitsManual.Text)) return true;
                    MessageBox.Show(Resources.CreateCases_ValidateCases_Units_Required);
                    return false;
                }
                MessageBox.Show(Resources.CreateCases_ValidateCases_Time_production_required);
                return false;
            }
            MessageBox.Show(Resources.CreateCases_ValidateCases_Case_number_Required);
            return false;
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            General.ValidNumber(e);

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                nudUnitsManual.Focus();
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
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CreateCase();

                txtBarCodeScanned.Focus();
            }

        }

        private void CreateCase()
        {
            int code = Convert.ToInt16(txtBarCodeScanned.Text.Length == 5 ? txtBarCodeScanned.Text.Substring(1) : txtBarCodeScanned.Text);

            var iCode = ListCases.FirstOrDefault(c => c.Code == code);
            if (iCode != null)
            {
                if (ValidateCase(iCode)) return;
                iCode.Units++;
            }
            else
            {
                var singleOrDefault = UnitOfWork.ListConfigurations().SingleOrDefault(x => x.Name == "xETADefault");
                if (singleOrDefault != null)
                {
                    //var units = tabScan.Visible ? "1" : txtunits.Text;
                    var objCase = new Case
                    {
                        Code = code,
                        DateCreation = DateTime.Now,
                        ETA = int.Parse(string.IsNullOrWhiteSpace(nudTimeETA.Text) ? singleOrDefault.Value : nudTimeETA.Text),
                        IsInProduction = false,
                        Units = int.Parse(string.IsNullOrWhiteSpace(nudUnitsManual.Text) ? "1" : nudUnitsManual.Text)
                    };
                    UnitOfWork.DalCases.CreateCase(objCase);
                }
            }

            UnitOfWork.SaveData();
            InitialLoad();
            SearchAndCleanControl(tpManual.Controls);
            SearchAndCleanControl(tpScan.Controls);
        }

        private static bool ValidateCase(Case iCode)
        {
            var singleOrDefault = UnitOfWork.ListConfigurations().SingleOrDefault(x => x.Name == "MaxUnitsPerCase");

            if (singleOrDefault != null && iCode.Units >= int.Parse(singleOrDefault.Value))
            {
                MessageBox.Show(Resources.CreateCases_ValidateCase_you_can_t_add_more_units_to_this_case);
                return true;
            }
            if (iCode.DateFinish == null) return false;
            MessageBox.Show($"you can't add more units to this case was closed {iCode.DateFinish}");
            return true;
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

        private void nudUnitsScaner_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
