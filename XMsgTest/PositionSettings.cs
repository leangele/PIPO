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
    public partial class PositionSettings : XMsgTestUserControl
    {

        public Boolean ExtendedFeaturesEnabled
        {
            get { return checkSetDlgPosition.Checked; }
            set { checkSetDlgPosition.Checked = value; }
        }

        public int PositionMode
        {
            get { if (radioButton1.Checked) return 0; else return 1; }
            set
            {
                if (value == 0) { radioButton2.Checked = false; radioButton1.Checked = true; }
                else { radioButton1.Checked = false; radioButton2.Checked = true; }
            }
        }

        public Decimal PositionLeft
        {
            get { return numericDlgPosLeft.Value; }
            set { numericDlgPosLeft.Value = value; }
        }

        public Decimal PositionTop
        {
            get { return numericDlgPosTop.Value; }
            set { numericDlgPosTop.Value = value; }
        }

        public int HorizontalAlign
        {
            get { return comboDlgHorizAlign.SelectedIndex; }
            set { comboDlgHorizAlign.SelectedIndex = value; }
        }

        public int VerticalAlign
        {
            get { return comboDlgVertAlign.SelectedIndex; }
            set { comboDlgVertAlign.SelectedIndex = value; }
        }

        public PositionSettings()
        {
            InitializeComponent();
        }

        public override void InitDialogSettings()
        {
            srcCS = "//Dialog Position settings" + CRLF;
            srcVB = "'Dialog Position settings" + CRLF;

            if (!ExtendedFeaturesEnabled)
            {
                DlgMgr.AssignDlgPosition();
                srcCS += "DlgMgr.AssignDlgPosition();" + CRLF;
                srcVB += "DlgMgr.AssignDlgPosition()" + CRLF;
                return;
            }

            if (PositionMode == 0)
            {
                //relative
                XMessageBoxHorizontalAlign ha = XMessageBoxHorizontalAlign.Centered;
                XMessageBoxVerticalAlign va = XMessageBoxVerticalAlign.Centered;

                switch (comboDlgHorizAlign.SelectedIndex)
                {
                    case 0:
                        ha = XMessageBoxHorizontalAlign.LeftAligned;
                        break;
                    case 2:
                        ha = XMessageBoxHorizontalAlign.RightAligned;
                        break;
                    default:
                        ha = XMessageBoxHorizontalAlign.Centered;
                        break;
                }

                switch (comboDlgVertAlign.SelectedIndex)
                {
                    case 0:
                        va = XMessageBoxVerticalAlign.TopAligned;
                        break;
                    case 2:
                        va = XMessageBoxVerticalAlign.BottomAligned;
                        break;
                    default:
                        va = XMessageBoxVerticalAlign.Centered;
                        break;
                }

                DlgMgr.AssignDlgPosition(ha, va);
                srcCS += "//anchor" + CRLF +
                    "DlgMgr.AssignDlgPosition(XMessageBoxHorizontalAlign." + ha.ToString() + ", " + CSNxt +
                    "XMessageBoxVerticalAlign." + va.ToString() + ");" + CRLF;

                srcVB += "'anchor" + CRLF +
                    "DlgMgr.AssignDlgPosition(XMessageBoxHorizontalAlign." + ha.ToString() + "," + VBNxt +
                    "XMessageBoxVerticalAlign." + va.ToString() + ")" + CRLF;

            }
            else
            {
                //absolute
                DlgMgr.AssignDlgPosition((int)PositionLeft, (int)PositionTop, 
                    XMessageBoxPositionMode.AbsolutePosition);

                srcCS += "//absolute" + CRLF + 
                    "DlgMgr.AssignDlgPosition(" + PositionLeft.ToString() + ", " +
                    PositionTop.ToString() + ", " + CSNxt +
                    "XMessageBoxPositionMode." + XMessageBoxPositionMode.AbsolutePosition.ToString() + ");" + CRLF;

                srcVB += "'absolute" + CRLF + 
                    "DlgMgr.AssignDlgPosition(" + PositionLeft.ToString() + ", " +
                    PositionTop.ToString() + ", " + VBNxt +
                    "XMessageBoxPositionMode." + XMessageBoxPositionMode.AbsolutePosition.ToString() + ")" + CRLF;
            }

        }
    }
}
