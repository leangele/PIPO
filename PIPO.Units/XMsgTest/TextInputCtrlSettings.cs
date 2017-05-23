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
    public partial class TextInputCtrlSettings : XMsgTestUserControl
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

        public int ControlWidth
        {
            get { return (int)textControlWidth.Value; }
            set { textControlWidth.Value = value; }
        }

        public int ControlHeight
        {
            get { return (int)textControlHeight.Value; }
            set { textControlHeight.Value = value; }
        }

        public XMessageBoxEditControlStyles ControlStyle
        {
            get { return GetControlStyle(); }
            set { SetControlStyle(value); }
        }

        private XMessageBoxEditControlStyles GetControlStyle()
        {
            XMessageBoxEditControlStyles controlStyle = XMessageBoxEditControlStyles.None;
            
            if (checkAutoHScroll.Checked) controlStyle |= XMessageBoxEditControlStyles.AutoHScroll;
            if (checkAutoVScroll.Checked) controlStyle |= XMessageBoxEditControlStyles.AutoVScroll;
            if (checkCenter.Checked) controlStyle |= XMessageBoxEditControlStyles.Center;
            if (checkLowerCase.Checked) controlStyle |= XMessageBoxEditControlStyles.Lowercase;
            if (checkMultiline.Checked) controlStyle |= XMessageBoxEditControlStyles.Multiline;
            if (checkNoHideSel.Checked) controlStyle |= XMessageBoxEditControlStyles.NoHideSel;
            if (checkNumber.Checked) controlStyle |= XMessageBoxEditControlStyles.Number;
            if (checkOemConvert.Checked) controlStyle |= XMessageBoxEditControlStyles.OemConvert;
            if (checkPassword.Checked) controlStyle |= XMessageBoxEditControlStyles.Password;
            if (checkReadOnly.Checked) controlStyle |= XMessageBoxEditControlStyles.ReadOnly;
            if (checkRight.Checked) controlStyle |= XMessageBoxEditControlStyles.Right;
            if (checkUppercase.Checked) controlStyle |= XMessageBoxEditControlStyles.Uppercase;
            if (checkWantReturn.Checked) controlStyle |= XMessageBoxEditControlStyles.WantReturn;

            return controlStyle;
        }

        void SetControlStyle(XMessageBoxEditControlStyles value)
        {
            checkAutoHScroll.Checked = (((int)value & (int)XMessageBoxEditControlStyles.AutoHScroll) != 0);
            checkAutoVScroll.Checked = (((int)value & (int)XMessageBoxEditControlStyles.AutoVScroll) != 0);
            checkCenter.Checked = (((int)value & (int)XMessageBoxEditControlStyles.Center) != 0);
            checkLowerCase.Checked = (((int)value & (int)XMessageBoxEditControlStyles.Lowercase) != 0);
            checkMultiline.Checked = (((int)value & (int)XMessageBoxEditControlStyles.Multiline) != 0);
            checkNoHideSel.Checked = (((int)value & (int)XMessageBoxEditControlStyles.NoHideSel) != 0);
            checkNumber.Checked = (((int)value & (int)XMessageBoxEditControlStyles.Number) != 0);
            checkOemConvert.Checked = (((int)value & (int)XMessageBoxEditControlStyles.OemConvert) != 0);
            checkPassword.Checked = (((int)value & (int)XMessageBoxEditControlStyles.Password) != 0);
            checkReadOnly.Checked = (((int)value & (int)XMessageBoxEditControlStyles.ReadOnly) != 0);
            checkRight.Checked = (((int)value & (int)XMessageBoxEditControlStyles.Right) != 0);
            checkUppercase.Checked = (((int)value & (int)XMessageBoxEditControlStyles.Uppercase) != 0);
            checkWantReturn.Checked = (((int)value & (int)XMessageBoxEditControlStyles.WantReturn) != 0);

        }

        public TextInputCtrlSettings()
        {
            InitializeComponent();
        }

        public override void InitDialogSettings()
        {
            srcCS = "//Text Input Control settings" + CRLF;
            srcVB = "'Text Input Control settings" + CRLF;

            if ((!checkDisplayControl.Checked) || (ControlCaption.Length == 0))
            {
                DlgMgr.EnableTextInputCtrl();
                srcCS += "DlgMgr.EnableTextInputCtrl();" + CRLF;
                srcVB += "DlgMgr.EnableTextInputCtrl()" + CRLF;
            }
            else
            {
                DlgMgr.EnableTextInputCtrl(ControlCaption, ControlWidth, ControlHeight, ControlStyle);

                srcCS += "DlgMgr.EnableTextInputCtrl(" + CSNxt +
                    "\"" + ControlCaption + "\", " + CSNxt +
                    ControlWidth.ToString() + ", " + ControlHeight.ToString() + ", " + CSNxt +
                    ((int)ControlStyle).ToString() + ");" + CRLF;

                srcVB += "DlgMgr.EnableTextInputCtrl(" + VBNxt +
                    "\"" + ControlCaption + "\"," + VBNxt +
                    ControlWidth.ToString() + ", " + ControlHeight.ToString() + "," + VBNxt +
                    ((int)ControlStyle).ToString() + ")" + CRLF;

            }
        }

    }
}
