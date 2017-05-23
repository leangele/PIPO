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
    public partial class DialogButtonSettings : XMsgTestUserControl
    {
        private XMessageBoxButton buttonId = XMessageBoxButton.ButtonOk;
        private Font initialFont;

        public XMessageBoxButton ButtonId
        {
            get { return buttonId; }
            set { buttonId = value; }
        }

        public String ButtonName
        {
            get { return labelButtonName.Text; }
            set { labelButtonName.Text = value; }
        }

        public Boolean ButtonDisabled
        {
            get { return checkButtonDisabled.Checked; }
            set { checkButtonDisabled.Checked = value; }
        }

        public String ButtonCaption
        {
            get { return textButtonCaption.Text.Trim(); }
            set { textButtonCaption.Text = value; }
        }

        public Font ButtonFont
        {
            get { return textButtonCaption.Font; }
            set { textButtonCaption.Font = value; }
        }

        public String ButtonToolTip
        {
            get { return textButtonTooltip.Text; }
            set { textButtonTooltip.Text = value; }
        }

        public DialogButtonSettings()
        {
            InitializeComponent();
            initialFont = textButtonCaption.Font;
        }

        public Boolean IsUpdated
        {
            get
            {
                if ((ButtonCaption.Length > 0) || ButtonDisabled 
                    || (ButtonFont.ToString() != initialFont.ToString())) return true;
                return false;
            }
        }

        public override void InitDialogSettings()
        {
            DlgMgr.AssignButtonCaption(buttonId, ButtonCaption);
            DlgMgr.AssignButtonEnabled(buttonId, !ButtonDisabled);
            DlgMgr.AssignButtonToolTip(buttonId, ButtonToolTip);
            DlgMgr.AssignButtonFont(buttonId, ButtonFont);

            if (!IsUpdated)
            {
                srcCS = ""; srcVB = "";
                return;
            }

            srcCS = CRLF + "DlgMgr.AssignButtonCaption(XMessageBoxButton." + buttonId.ToString() + ", \"" + ButtonCaption + "\");" + CRLF +
                "DlgMgr.AssignButtonEnabled(XMessageBoxButton." + buttonId.ToString() + ", " + (!ButtonDisabled).ToString() + ");" + CRLF +
                "DlgMgr.AssignButtonToolTip(XMessageBoxButton." + buttonId.ToString() + ", \"" + ButtonToolTip + "\");" + CRLF +
                "DlgMgr.AssignButtonFont(XMessageBoxButton." + buttonId.ToString() + ", " + CSNxt +
                    FontToStr(ButtonFont) + ");" + CRLF;

            srcVB = CRLF + "DlgMgr.AssignButtonCaption(XMessageBoxButton." + buttonId.ToString() + ", \"" + ButtonCaption + "\")" + CRLF +
                "DlgMgr.AssignButtonEnabled(XMessageBoxButton." + buttonId.ToString() + ", " + (!ButtonDisabled).ToString() + ")" + CRLF +
                "DlgMgr.AssignButtonToolTip(XMessageBoxButton." + buttonId.ToString() + ", \"" + ButtonToolTip + "\")" + CRLF +
                "DlgMgr.AssignButtonFont(XMessageBoxButton." + buttonId.ToString() + ", " + VBNxt +
                    FontToStr(ButtonFont) + ")" + CRLF;
        }

        private void SelectFont()
        {
            fontDialog1.Font = textButtonCaption.Font;
            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                textButtonCaption.Font = fontDialog1.Font;
                labelButtonName.Font = fontDialog1.Font;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectFont();
        }
    }
}
