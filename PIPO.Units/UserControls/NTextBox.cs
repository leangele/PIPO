using System.Windows.Forms;

namespace LabTrack.UserControls
{
    public partial class NTextBox : UserControl
    {
        public NTextBox()
        {
            InitializeComponent();
        }

        private void txtNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            //// only allow one decimal point
            //var textBox = sender as TextBox;
            //if (textBox != null && ((e.KeyChar == '.') && (textBox.Text.IndexOf('.') > -1)))
            //{
            //    e.Handled = true;
            //}
        }
    }
}
