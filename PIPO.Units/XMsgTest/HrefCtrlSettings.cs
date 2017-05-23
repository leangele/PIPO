using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using XMsgLib.Dlg;

namespace XMsgTest
{
    public partial class HrefCtrlSettings : XMsgTestUserControl
    {
        public Boolean ControlEnabled
        {
            get { return checkDisplayControl.Checked; }
            set { checkDisplayControl.Checked = value; }
        }

        public Color SelectedColor
        {
            get { return labelHref.ForeColor; }
            set { labelHref.ForeColor = value; }
        }

        public String SelectedHref
        {
            get { return textHref.Text.Trim(); }
            set { textHref.Text = value; }
        }

        public String SelectedAlias
        {
            get {
                if (textAlias.Text.Trim().Length > 0) return textAlias.Text;
                else return SelectedHref;
            }
            set { textAlias.Text = value; }
        }

        public HrefCtrlSettings()
        {
            InitializeComponent();
        }

        private void SelectColor()
        {
            colorDialog1.Color = labelHref.ForeColor;
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                labelHref.ForeColor = colorDialog1.Color;
            }
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            SelectColor();
        }

        public override void InitDialogSettings()
        {
            srcCS = "//Web Link Control settings" + CRLF;
            srcVB = "'Web Link Control settings" + CRLF;

            if ((!ControlEnabled) || (SelectedHref.Length == 0))
            {
                DlgMgr.EnableHrefCtrl("");
                srcCS += "DlgMgr.EnableHrefCtrl(\"\");" + CRLF;
                srcVB += "DlgMgr.EnableHrefCtrl(\"\")" + CRLF;
            }
            else
            {
                DlgMgr.EnableHrefCtrl(SelectedHref, SelectedAlias, SelectedColor);

                srcCS += "DlgMgr.EnableHrefCtrl(" + CSNxt +
                    "\"" + SelectedHref + "\"," + CSNxt +
                    "\"" + SelectedAlias + "\"," + CSNxt +
                    ColorToStr(SelectedColor) + ");" + CRLF;

                srcVB += "DlgMgr.EnableHrefCtrl(" + VBNxt +
                    "\"" + SelectedHref + "\"," + VBNxt +
                    "\"" + SelectedAlias + "\"," + VBNxt +
                    ColorToStr(SelectedColor) + ")" + CRLF;
            }
        }
    }
}
