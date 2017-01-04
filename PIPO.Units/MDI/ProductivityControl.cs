using System;
using System.Windows.Forms;
using PIPO.Units.Forms;

namespace PIPO.Units.MDI
{
    public partial class ProductivityControl : Form
    {
        private int childFormNumber = 0;

        public ProductivityControl()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            CreateCases childForm = new CreateCases
            {
                MdiParent = this,
                
            };
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            ProductivityForm objForm = new ProductivityForm
            {
                TopLevel = false,
                MdiParent = this,
                FormBorderStyle = FormBorderStyle.SizableToolWindow,
                Dock = DockStyle.Fill
            };

            objForm.Show();

            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            //openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            //if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            //{
            //    string FileName = openFileDialog.FileName;
            //}
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
