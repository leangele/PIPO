using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace XMsgTest
{
    public partial class GeneratedCode : UserControl
    {
        public GeneratedCode()
        {
            InitializeComponent();
            SwitchLanguagePane();
        }

        public void ClearPanes()
        {
            textCodeCS.Text = "";
            textCodeVB.Text = "";
        }

        public void AddCode(String codeCS, String codeVB)
        {
            textCodeCS.Text = textCodeCS.Text + codeCS + "\r\n";
            textCodeVB.Text = textCodeVB.Text + codeVB + "\r\n";
        }

        private void CopyToClipboard()
        {
            String code;

            if (textCodeCS.Visible) code = textCodeCS.Text;
            else code = textCodeVB.Text;

            if ( code.Length > 0) Clipboard.SetText(code);

        }

        private void SwitchLanguagePane()
        {
            textCodeCS.Visible = radioButton1.Checked;
            textCodeVB.Visible = !radioButton1.Checked;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SwitchLanguagePane();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CopyToClipboard();
        }

    }
}
