using PIPO.Units.DAL;
using PIPO.Units.Interfaces;
using PIPO.Units.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PIPO.Units.Forms
{
    public partial class CreateCases : Form
    {
        private IUnitOfWork _unitOfWork { get; set; }
        private List<Case> listCases { get; set; }
        public CreateCases()
        {
            _unitOfWork = new UnitOfWork(new CasesControlEntities());
            InitializeComponent();
            InitialLoad();
        }

        private void InitialLoad()
        {
            listCases = _unitOfWork.DalCases.ListCases();
            lboxCases.DataSource = listCases;
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
                    ETA = int.Parse(txtETA.Text),
                    IsInProduction = false,
                    Units = int.Parse(txtunits.Text)
                };
                _unitOfWork.DalCases.CreateCase(objCase);
                _unitOfWork.SaveData();
                InitialLoad();
            }
            SearchAndCleanControl(tabPage1.Controls);
        }

        private static void SearchAndCleanControl(Control.ControlCollection controlList)
        {
            foreach (Control control in controlList.Cast<Control>().Where(control => control.GetType() == typeof(TextBox)))
            {
                control.Text = string.Empty;
            }
        }

        private bool ValidateCases()
        {
            if (string.IsNullOrWhiteSpace(txtCode.Text))
            {
                MessageBox.Show(Resources.CreateCases_ValidateCases_Case_number_Required);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtETA.Text))
            {
                MessageBox.Show(Resources.CreateCases_ValidateCases_Time_production_required);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtunits.Text))
            {
                MessageBox.Show(Resources.CreateCases_ValidateCases_Units_Required);
                return false;
            }
            return true;
        }

        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            General.ValidNumber(e);

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtunits.Focus();
            }
        }

        private void txtunits_KeyPress(object sender, KeyPressEventArgs e)
        {
            General.ValidNumber(e);
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtETA.Focus();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            General.ValidNumber(e);
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnSave.Focus();
            }
        }

        private void txtCodeFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            General.ValidNumber(e);
            if (!string.IsNullOrWhiteSpace(txtCodeFind.Text))
            {
                var nro = int.Parse(txtCodeFind.Text);
                lboxCases.DataSource = listCases.Where(x => x.Code == nro).ToList();
            }
            else
            {
                InitialLoad();
            }
        }

        private void lboxCases_SelectedIndexChanged(object sender, EventArgs e)
        {
            var objCase = (Case)lboxCases.SelectedItem;

            txtCode.Text = objCase.Code.ToString();
            txtBarCodeScanned.Text = objCase.Code.ToString();
            txtDateCreation.Text = objCase.DateCreation.ToString();
            txtETA.Text = objCase.ETA.ToString();
            txtunits.Text = objCase.Units.ToString();
            lblUnits.Text = objCase.Units.ToString();
        }

        private void txtCodeBCS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CreateCase();
            }
            SearchAndCleanControl(tabPage2.Controls);
            txtBarCodeScanned.Focus();
        }

        private void CreateCase()
        {
            var code = Convert.ToInt16(txtBarCodeScanned.Text);
            var iCode = listCases.FirstOrDefault(c => c.Code == code);
            if (iCode != null)
            {
                if (ValidateCase(iCode)) return;
                iCode.Units++;
            }
            else
            {
                var objCase = new Case
                {
                    Code = code,
                    DateCreation = DateTime.Now,
                    ETA = int.Parse(string.IsNullOrWhiteSpace(txtETA.Text) ? "5" : txtETA.Text),
                    IsInProduction = false,
                    Units = int.Parse(string.IsNullOrWhiteSpace(txtunits.Text) ? "1" : txtunits.Text)
                };
                _unitOfWork.DalCases.CreateCase(objCase);
            }

            _unitOfWork.SaveData();
            InitialLoad();
        }

        private static bool ValidateCase(Case iCode)
        {
            if (iCode.Units == 64)
            {
                MessageBox.Show(Resources.CreateCases_ValidateCase_you_can_t_add_more_units_to_this_case);
                return true;
            }
            if (iCode.DateFinish != null)
            {
                MessageBox.Show($"you can't add more units to this case was closed {iCode.DateFinish}");
                return true;
            }
            return false;
        }

        private void txtCode_Enter(object sender, EventArgs e)
        {
            SearchAndCleanControl(tabPage1.Controls);
        }

        private void txtBarCodeScanned_Enter(object sender, EventArgs e)
        {
            SearchAndCleanControl(tabPage2.Controls);
            lblUnits.Text = "0";
        }

        private void txtBarCodeScanned_Leave(object sender, EventArgs e)
        {

        }
    }
}
