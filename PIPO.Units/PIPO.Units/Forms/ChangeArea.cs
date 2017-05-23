using LabTrack.DAL;
using System;
using System.Windows.Forms;

namespace LabTrack.Forms
{
    public partial class ChangeArea : Form
    {
        public UnitOfWork UnitOfWork { get; set; }
        public CaseControl CaseControl { get; set; }

        public ChangeArea(UnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var area = (Area)cbxNewArea.SelectedItem;
            if (CaseControl.idTechnitian != area.Id)
            {
                string message = $"Are you sure want to change\r\n the area for: {area.Name},\r\n technitian be: {area.NamePerson}.";

                if (AutoClosingMessageBox.Show(message, "Error", 50000, MessageBoxButtons.OKCancel) != DialogResult.OK)
                    return;
                CaseControl.idTechnitian = area.Id;
                UnitOfWork.SaveData();
                Close();
            }

        }

        private void Change_Area_Load(object sender, EventArgs e)
        {
            CaseControl = UnitOfWork.DalCasesControl.GetCaseById(CaseControl.Id);
            var area = UnitOfWork.DalAreas.GetAreaForId(CaseControl.idTechnitian);
            if (area == null) throw new ArgumentNullException(nameof(area));
            lblOldArea.Text = area.Name;
            lblOldTechnitian.Text = area.NamePerson;
            var areas = UnitOfWork.DalAreas.ListAreas();
            cbxNewArea.DataSource = areas;
            cbxNewArea.ValueMember = "id";
            cbxNewArea.DisplayMember = "name";
        }
    }
}
