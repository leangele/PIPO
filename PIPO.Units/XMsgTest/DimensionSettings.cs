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
    public partial class DimensionSettings : XMsgTestUserControl
    {

        public Boolean ExtendedFeaturesEnabled
        {
            get { return checkSetDlgDimensions.Checked; }
            set { checkSetDlgDimensions.Checked = value; }
        }

        public Decimal DialogMaxWidth
        {
            get { return textDlgMaxWidth.Value; }
            set { textDlgMaxWidth.Value = value; }
        }

        public Decimal DialogMaxHeight
        {
            get { return textDlgMaxHeight.Value; }
            set { textDlgMaxHeight.Value = value; }
        }

        public DimensionSettings()
        {
            InitializeComponent();
        }

        public override void InitDialogSettings()
        {
            srcCS = "//Dialog Dimension settings" + CRLF;
            srcVB = "'Dialog Dimension settings" + CRLF;

            if (!ExtendedFeaturesEnabled)
            {
                DlgMgr.AssignDlgMaxSize();
                srcCS += "DlgMgr.AssignDlgMaxSize();" + CRLF;
                srcVB += "DlgMgr.AssignDlgMaxSize()" + CRLF;
            }
            else
            {
                DlgMgr.AssignDlgMaxSize((int)DialogMaxWidth, (int)DialogMaxHeight);
                srcCS += "DlgMgr.AssignDlgMaxSize(" + DialogMaxWidth.ToString() +
                    ", " + DialogMaxHeight.ToString() + ");" + CRLF;
                srcVB += "DlgMgr.AssignDlgMaxSize(" + DialogMaxWidth.ToString() +
                    ", " + DialogMaxHeight.ToString() + ")" + CRLF;
            }
        }
    }
}
