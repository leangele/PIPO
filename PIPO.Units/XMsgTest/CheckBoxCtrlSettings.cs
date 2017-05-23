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
    public partial class CheckBoxCtrlSettings : XMsgTestUserControl
    {
        public Boolean ControlEnabled
        {
            get { return checkDisplayControl.Checked; }
            set { checkDisplayControl.Checked = value; }
        }

        public String ControlCaption
        {
            get { return textControlCaption.Text.Trim(); }
            set { textControlCaption.Text = value; }
        }

        public Boolean ControlCheckedStatus
        {
            get { return checkCheckedStatus.Checked; }
            set { checkCheckedStatus.Checked = value; }
        }

        public CheckBoxCtrlSettings()
        {
            InitializeComponent();
        }

        public override void InitDialogSettings()
        {
            srcCS = "//CheckBox Control settings" + CRLF;
            srcVB = "'CheckBox Control settings" + CRLF;

            if ((!ControlEnabled) || (ControlCaption.Length == 0))
            {
                DlgMgr.EnableCheckBoxCtrl();
                srcCS += "DlgMgr.EnableCheckBoxCtrl();" + CRLF;
                srcVB += "DlgMgr.EnableCheckBoxCtrl()" + CRLF;
            }
            else
            {
                DlgMgr.EnableCheckBoxCtrl(ControlCaption, ControlCheckedStatus);
                srcCS += "DlgMgr.EnableCheckBoxCtrl(\"" + ControlCaption + "\"," + CSNxt +
                    ControlCheckedStatus.ToString() + ");" + CRLF;
                srcVB += "DlgMgr.EnableCheckBoxCtrl(\"" + ControlCaption + "\"," + VBNxt +
                    ControlCheckedStatus.ToString() + ")" + CRLF;
            }
        }

    }
}
