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
    public partial class MessageSettings : XMsgTestUserControl
    {
        public Decimal DlgTimeout
        {
            get { return numericTimeout.Value; }
            set { numericTimeout.Value = value; }
        }

        public String DlgCaption
        {
            get { return textDlgCaption.Text.Trim(); }
            set { textDlgCaption.Text = value; }
        }

        public String DlgMessage
        {
            get { return textDlgMessage.Text; }
            set { textDlgMessage.Text = value; }
        }

        public Font DlgMessageFont
        {
            get { return textDlgMessage.Font; }
            set { 
                textDlgMessage.Font = value;
                labelMessageFontName.Text = value.ToString();
            }
        }

        public Color DlgMessageBackColor
        {
            get { return textDlgMessage.BackColor; }
            set { textDlgMessage.BackColor = value; }
        }

        public Color DlgMessageForeColor
        {
            get { return textDlgMessage.ForeColor; }
            set { textDlgMessage.ForeColor = value; }
        }

        public String DlgMessageWebLink
        {
            get { return textMessageWebLink.Text.Trim(); }
            set { textMessageWebLink.Text = value; }
        }

        public MessageSettings()
        {
            InitializeComponent();
        }

        private void SelectFont()
        {
            fontDialog1.Font = textDlgMessage.Font;
            fontDialog1.Color = textDlgMessage.ForeColor;
            fontDialog1.ShowColor = true;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                textDlgMessage.Font = fontDialog1.Font;
                textDlgMessage.ForeColor = fontDialog1.Color;
                labelMessageFontName.Text = fontDialog1.Font.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectFont();
        }

        public override void InitDialogSettings()
        {
            srcCS = "//Message settings" + CRLF;
            srcVB = "'Message settings" + CRLF;

            DlgMgr.AssignMessageFont(DlgMessageFont);
            DlgMgr.MessageFontColor = DlgMessageForeColor;
            DlgMgr.TimeoutMilliseconds = (int)DlgTimeout;

            srcCS += "DlgMgr.AssignMessageFont(" + FontToStr(DlgMessageFont) + ");" + CRLF +
                "DlgMgr.MessageFontColor = " + ColorToStr(DlgMessageForeColor) + ";" + CRLF +
                "DlgMgr.TimeoutMilliseconds = " + ((int)DlgTimeout).ToString() + ";" + CRLF;

            srcVB += "DlgMgr.AssignMessageFont(" + FontToStr(DlgMessageFont) + ")" + CRLF +
                "DlgMgr.MessageFontColor = " + ColorToStr(DlgMessageForeColor) + CRLF +
                "DlgMgr.TimeoutMilliseconds = " + ((int)DlgTimeout).ToString() + CRLF;

            if (checkMessageWebLink.Checked)
            {
                DlgMgr.AddWebLinkToMessage(DlgMessageWebLink);
                srcCS += "DlgMgr.AddWebLinkToMessage(\"" + DlgMessageWebLink + "\");" + CRLF;
                srcVB += "DlgMgr.AddWebLinkToMessage(\"" + DlgMessageWebLink + "\")" + CRLF;
            }
            else
            {
                DlgMgr.AddWebLinkToMessage("");
                srcCS += "DlgMgr.AddWebLinkToMessage(\"\");" + CRLF;
                srcVB += "DlgMgr.AddWebLinkToMessage(\"\")" + CRLF;
            }

        }
    }
}
