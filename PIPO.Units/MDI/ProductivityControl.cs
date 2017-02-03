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

        private void OpenForm(string form, FormWindowState formWindowState = FormWindowState.Maximized, bool val = false, string value = null)
        {
            var fc = Application.OpenForms;
            var formFound = false;
            if (ConsulStatusForm(form, fc, formFound)) return;
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
                case "Productivity":
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
                    General.OpenAndCloseForm(Name);

                    break;
                case "FinishCase":
                    var g = new FinishCase(_unitOfWork, val)
                    {
                        WindowState = formWindowState,
                    };
                    g.Show();
                    break;
                case "FrmReport":

                    var d = new Forms.Reports(value)
                    {
                        WindowState = formWindowState,
                        MdiParent = this
                    };
                    d.Show();
                    break;
            }
        }

        private static bool ConsulStatusForm(string form, FormCollection fc, bool formFound)
        {
            foreach (var frm in fc.Cast<Form>().Where(frm => frm.Name == form))
            {
                frm.Focus();
                formFound = true;
            }
            return formFound;
        }

        private void ActivateDeactivateControls()
        {
            optionsToolStripMenuItem1.Enabled = IsAdministrationOn;
            newToolStripMenuItem1.Enabled = IsAdministrationOn;
        }


        private void ProductivityControl_Load(object sender, EventArgs e)
        {
            if (!_unitOfWork.CheckConection(new CasesControlEntities())) return;
            var b = new Productivity(_unitOfWork, IsAdministrationOn)
            {
                WindowState = FormWindowState.Maximized,
                MdiParent = this
            };
            b.Show();
        }
        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenForm("CreateCases", FormWindowState.Normal);
        }

        private void productivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm("Productivity");
        }

        private void finishToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenForm("FinishCase", FormWindowState.Normal);
        }

        private void unitsPerDayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm("FrmReport", FormWindowState.Normal, false, "CasePerRangeWithUnits.rpt");
        }

        private void finishPerDayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm("FrmReport", FormWindowState.Normal, false, "CasesFinishedByDate.rpt");
        }

        private void statusPerAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm("formDataCases", FormWindowState.Normal);
        }

        private void searchToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenForm("FinishCase", FormWindowState.Normal, true);
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void optionsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenForm("ConfigurationParams");
        }

        private void administrationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenForm("formAdmin", FormWindowState.Normal);
        }
    }
}
