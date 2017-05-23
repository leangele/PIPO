using LabTrack.DAL;
using LabTrack.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LabTrack.Forms
{
    public partial class ConfigurationParams : Form
    {
        private static IUnitOfWork UnitOfWork { get; set; }
        public bool IsAdministrationOn { get; set; }
        List<Configuration> _listConfig;
        public ConfigurationParams(UnitOfWork unitOfWork, bool isAdministrationOn)
        {
            InitializeComponent();
            UnitOfWork = unitOfWork;
            IsAdministrationOn = isAdministrationOn;

            ChargeGrid();
            dgvConfig.Columns[0].Visible = false;
            dgvConfig.Columns[2].Visible = false;
            dgvConfig.Columns[4].Visible = false;
        }

        private void ChargeGrid()
        {
            _listConfig = UnitOfWork.ListConfigurations();
            dgvConfig.DataSource = _listConfig;
        }


        private void ConfigurationParams_Load(object sender, EventArgs e)
        {
            General.OpenAndCloseForm(Name);

        }


        private void dgvConfig_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvConfig_SelectionChanged(object sender, EventArgs e)
        {
            //if (dgvConfig.== null) return;
            //var item = int.Parse(dgvConfig.SelectedRows[0].ToString());
            //var itemConfig = _listConfig.SingleOrDefault(x => x.Id == item);
            //if (itemConfig != null)
            //{
            //    lblNameConfig.Text = itemConfig.Name;
            //    txtValue.Text = itemConfig.Value;
            //}
        }

        private void dgvConfig_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = int.Parse(dgvConfig.SelectedRows[0].Cells[0].Value.ToString());

            var itemConfig = _listConfig.SingleOrDefault(x => x.Id == item);
            if (itemConfig != null)
            {
                lblNameConfig.Text = itemConfig.Name;
                txtValue.Text = itemConfig.Value;
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            var item = int.Parse(dgvConfig.SelectedRows[0].Cells[0].Value.ToString());
            var itemConfig = _listConfig.SingleOrDefault(x => x.Id == item);
            if (itemConfig != null)
            {
                itemConfig.Value = txtValue.Text;
            }
            UnitOfWork.SaveData();
            ChargeGrid();
        }
    }
}
