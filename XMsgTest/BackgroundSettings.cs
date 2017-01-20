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
    public partial class BackgroundSettings : XMsgTestUserControl
    {
        public delegate void BackgroundColorSelectedHandler(int mode, Color c);
        public event BackgroundColorSelectedHandler OnBackgroundColorSelected;

        public Color BackgroundColorMain
        {
            get { return colorSelect1.SelectedColor; }
            set { colorSelect1.SelectedColor = value; }
        }

        public Color BackgroundColorToolbar
        {
            get { return colorSelect2.SelectedColor; }
            set { colorSelect2.SelectedColor = value; }
        }

        public String SelectedBitmapFileMain
        {
            get { return colorSelect1.SelectedBitmapFile; }
            set { colorSelect1.SelectedBitmapFile = value; }
        }

        public String SelectedBitmapFileToolbar
        {
            get { return colorSelect2.SelectedBitmapFile; }
            set { colorSelect2.SelectedBitmapFile = value; }
        }

        public XMessageBoxHatchStyle SelectedBrushMain
        {
            get { return (XMessageBoxHatchStyle)colorSelect1.SelectedBrush - 1; }
            set { colorSelect1.SelectedBrush = (int)value + 1; }
        }

        public XMessageBoxHatchStyle SelectedBrushToolbar
        {
            get { return (XMessageBoxHatchStyle)colorSelect2.SelectedBrush - 1; }
            set { colorSelect1.SelectedBrush = (int)value + 1; }
        }

        public BackgroundSettings()
        {
            InitializeComponent();
        }

        public override void InitDialogSettings()
        {
            srcCS = "//Dialog Background settings" + CRLF;
            srcVB = "'Dialog Background settings" + CRLF;

            DlgMgr.UdfBackcolorsEnabled = checkUdfBackcolorsEnabled.Checked;
            srcCS += "DlgMgr.UdfBackcolorsEnabled = " + DlgMgr.UdfBackcolorsEnabled.ToString().ToLower() + ";" + CRLF;
            srcVB += "DlgMgr.UdfBackcolorsEnabled = " + DlgMgr.UdfBackcolorsEnabled.ToString() + CRLF;

            if (!DlgMgr.UdfBackcolorsEnabled)
            {
                return;
            }

            //main
            if (colorSelect1.UseSystemDefault)
            {
                DlgMgr.ResetBackColor(XMessageBoxBackground.DlgWindow);
                srcCS += "DlgMgr.ResetBackColor(XMessageBoxBackground." + 
                    XMessageBoxBackground.DlgWindow.ToString() + ");" + CRLF;
                srcVB += "DlgMgr.ResetBackColor(XMessageBoxBackground." + 
                    XMessageBoxBackground.DlgWindow.ToString() + ")" + CRLF;
            }
            else if (colorSelect1.BackgroundMode == 0) //solid color or hatch
            {
                if (SelectedBrushMain == XMessageBoxHatchStyle.HatchStyleNone)
                {
                    DlgMgr.LoadBackColorFromSolidColor(XMessageBoxBackground.DlgWindow, BackgroundColorMain);

                    srcCS += "DlgMgr.LoadBackColorFromSolidColor(XMessageBoxBackground." + 
                        XMessageBoxBackground.DlgWindow.ToString() + "," + CSNxt +
                        ColorToStr(BackgroundColorMain) + ");" + CRLF;

                    srcVB += "DlgMgr.LoadBackColorFromSolidColor(XMessageBoxBackground." +
                        XMessageBoxBackground.DlgWindow.ToString() + "," + VBNxt +
                        ColorToStr(BackgroundColorMain) + ")" + CRLF;
                }
                else
                {
                    DlgMgr.LoadBackcolorFromHatchBrush(XMessageBoxBackground.DlgWindow,
                        SelectedBrushMain, BackgroundColorMain);

                    srcCS += "DlgMgr.LoadBackcolorFromHatchBrush(XMessageBoxBackground." +
                        XMessageBoxBackground.DlgWindow.ToString() + "," + CSNxt +
                        "XMessageBoxHatchStyle." + SelectedBrushMain.ToString() + "," + CSNxt +
                        ColorToStr(BackgroundColorMain) + ");" + CRLF;

                    srcVB += "DlgMgr.LoadBackcolorFromHatchBrush(XMessageBoxBackground." +
                        XMessageBoxBackground.DlgWindow.ToString() + "," + VBNxt +
                        "XMessageBoxHatchStyle." + SelectedBrushMain.ToString() + "," + VBNxt +
                        ColorToStr(BackgroundColorMain) + ")" + CRLF;
                }
            }
            else  //bitmap file
            {
                DlgMgr.LoadBackcolorFromBitmapFile(XMessageBoxBackground.DlgWindow, SelectedBitmapFileMain);

                srcCS += "DlgMgr.LoadBackcolorFromBitmapFile(XMessageBoxBackground." +
                    XMessageBoxBackground.DlgWindow.ToString() + "," + CSNxt +
                    "\"" + FilenameToStr(SelectedBitmapFileMain) + "\");" + CRLF;

                srcVB += "DlgMgr.LoadBackcolorFromBitmapFile(XMessageBoxBackground." +
                    XMessageBoxBackground.DlgWindow.ToString() + "," + VBNxt +
                    "\"" + SelectedBitmapFileMain + "\")" + CRLF;
            }

            //toolbar
            if (colorSelect2.UseSystemDefault)
            {
                DlgMgr.ResetBackColor(XMessageBoxBackground.ToolBarWindow);

                srcCS += "DlgMgr.ResetBackColor(XMessageBoxBackground." +
                    XMessageBoxBackground.ToolBarWindow.ToString() + ");" + CRLF;

                srcVB += "DlgMgr.ResetBackColor(XMessageBoxBackground." +
                    XMessageBoxBackground.ToolBarWindow.ToString() + ")" + CRLF;
            }
            else if (colorSelect2.BackgroundMode == 0) //solid color or hatch
            {
                if (SelectedBrushToolbar == XMessageBoxHatchStyle.HatchStyleNone)
                {
                    DlgMgr.LoadBackColorFromSolidColor(XMessageBoxBackground.ToolBarWindow, 
                        BackgroundColorToolbar);

                    srcCS += "DlgMgr.LoadBackColorFromSolidColor(XMessageBoxBackground." +
                        XMessageBoxBackground.ToolBarWindow.ToString() + "," + CSNxt +
                        ColorToStr(BackgroundColorToolbar) + ");" + CRLF;

                    srcVB += "DlgMgr.LoadBackColorFromSolidColor(XMessageBoxBackground." +
                        XMessageBoxBackground.ToolBarWindow.ToString() + "," + VBNxt +
                        ColorToStr(BackgroundColorToolbar) + ")" + CRLF;
                }
                else
                {
                    DlgMgr.LoadBackcolorFromHatchBrush(XMessageBoxBackground.ToolBarWindow,
                        SelectedBrushToolbar, BackgroundColorToolbar);

                    srcCS += "DlgMgr.LoadBackcolorFromHatchBrush(XMessageBoxBackground." +
                        XMessageBoxBackground.ToolBarWindow.ToString() + "," + CSNxt +
                        "XMessageBoxHatchStyle." + SelectedBrushToolbar.ToString() + "," + CSNxt +
                        ColorToStr(BackgroundColorToolbar) + ");" + CRLF;

                    srcVB += "DlgMgr.LoadBackcolorFromHatchBrush(XMessageBoxBackground." +
                        XMessageBoxBackground.ToolBarWindow.ToString() + "," + VBNxt +
                        "XMessageBoxHatchStyle." + SelectedBrushToolbar.ToString() + "," + VBNxt +
                        ColorToStr(BackgroundColorToolbar) + ")" + CRLF;
                }
            }
            else  //bitmap file
            {
                DlgMgr.LoadBackcolorFromBitmapFile(XMessageBoxBackground.ToolBarWindow, SelectedBitmapFileToolbar);

                srcCS += "DlgMgr.LoadBackcolorFromBitmapFile(XMessageBoxBackground." +
                    XMessageBoxBackground.ToolBarWindow.ToString() + "," + CSNxt +
                    "\"" + FilenameToStr(SelectedBitmapFileToolbar) + "\");" + CRLF;

                srcVB += "DlgMgr.LoadBackcolorFromBitmapFile(XMessageBoxBackground." +
                    XMessageBoxBackground.ToolBarWindow.ToString() + "," + VBNxt +
                    "\"" + SelectedBitmapFileToolbar + "\")" + CRLF;
            }
        }

        private void colorSelect1_OnColorSelected(Color c)
        {
            OnBackgroundColorSelected(0, c);
        }

        private void colorSelect2_OnColorSelected(Color c)
        {
            OnBackgroundColorSelected(1, c);
        }
    }
}
