using LabTrack.DAL;
using LabTrack.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LabTrack.MDI
{
    public partial class ProductivityControl : Form
    {
        public bool IsAdministrationOn { get; set; }

        private static UnitOfWork _unitOfWork;

        public ProductivityControl()
        {
            InitializeComponent();
            _unitOfWork = new UnitOfWork(new CasesControlEntities());
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            OpenForm("CreateCases", FormWindowState.Normal);
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenForm("ProductivityForm");
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm("ConfigurationParams");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm("FrmReport");

        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OpenForm(string form, FormWindowState formWindowState = FormWindowState.Maximized)
        {
            var fc = Application.OpenForms;
            var formFound = false;
            foreach (var frm in fc.Cast<Form>().Where(frm => frm.Name == form))
            {
                frm.Focus();
                formFound = true;
            }
            if (formFound) return;
            switch (form)
            {
                case "CreateCases":
                    var a = new CreateCases(_unitOfWork, IsAdministrationOn)
                    {
                        WindowState = formWindowState,
                        MdiParent = this,
                        TopMost = true
                    };
                    a.Show();
                    break;
                case "ProductivityForm":
                    var b = new Productivity(_unitOfWork, IsAdministrationOn)
                    {
                        WindowState = formWindowState,
                        MdiParent = this
                    };
                    b.Show();
                    break;
                case "ConfigurationParams":
                    var c = new ConfigurationParams(_unitOfWork, IsAdministrationOn)
                    {
                        WindowState = formWindowState,
                        MdiParent = this
                    };
                    c.Show();
                    break;
                case "FrmReport":
                    var d = new Report(_unitOfWork, IsAdministrationOn)
                    {
                        WindowState = formWindowState,
                        MdiParent = this
                    };
                    d.Show();
                    break;
                case "formDataCases":
                    var e = new DataCases(_unitOfWork, IsAdministrationOn)
                    {
                        WindowState = formWindowState,
                        MdiParent = this
                    };
                    e.Show();
                    break;
                case "formAdmin":
                    var f = new Admin(_unitOfWork, IsAdministrationOn)
                    {
                        WindowState = formWindowState,
                    };
                    f.ShowDialog();
                    IsAdministrationOn = f.IsLoged;
                    ActivateDeactivateControls();

                    break;


            }

        }

        private void ActivateDeactivateControls()
        {
            optionsToolStripMenuItem.Enabled = IsAdministrationOn;
            newToolStripMenuItem.Enabled = IsAdministrationOn;
        }

        private void statusAreasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm("formDataCases", FormWindowState.Normal);
        }

        private void administrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm("formAdmin", FormWindowState.Normal);
        }

        private void ProductivityControl_Load(object sender, EventArgs e)
        {
            if (!_unitOfWork.CheckConection(new CasesControlEntities())) return;
            var b = new Productivity(_unitOfWork, IsAdministrationOn)
            {
                WindowState = FormWindowState.Normal,
                MdiParent = this
            };
            b.Show();
        }
    }
}
