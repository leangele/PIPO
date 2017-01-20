using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using XMsgLib.Dlg;

namespace XMsgTest
{
    public partial class IconSettings : XMsgTestUserControl
    {
        public Boolean ExtendedFeaturesEnabled
        {
            get { return checkUdfIconsEnabled.Checked; }
            set { checkUdfIconsEnabled.Checked = value; }
        }

        public String IconFileSelected
        {
            get { return iconSelect1.IconFileSelected; }
            set { iconSelect1.IconFileSelected = value; }
        }

        public Decimal ResourceIndexSelected
        {
            get { return iconSelect1.ResourceIndexSelected; }
            set { iconSelect1.ResourceIndexSelected = value; }
        }

        public Boolean IconWebLinkEnabled
        {
            get { return checkIconWebLink.Checked; }
            set { checkIconWebLink.Checked = value; }
        }

        public String IconWebLink
        {
            get { return textIconWebLink.Text.Trim(); }
            set { textIconWebLink.Text = value; }
        }

        public IconSettings()
        {
            InitializeComponent();
        }

        public override void InitDialogSettings()
        {
            srcCS = "//Dialog Icon settings"+CRLF;
            srcVB = "'Dialog Icon settings"+CRLF;

            DlgMgr.UdfIconsEnabled = ExtendedFeaturesEnabled;
            srcCS += "DlgMgr.UdfIconsEnabled = " + ExtendedFeaturesEnabled.ToString().ToLower() + ";" + CRLF;
            srcVB += "DlgMgr.UdfIconsEnabled = " + ExtendedFeaturesEnabled.ToString() + CRLF;

            if (ExtendedFeaturesEnabled)
            {
                String sourceFileType = Path.GetExtension(IconFileSelected).ToLower();

                if (sourceFileType == ".ico")
                {
                    DlgMgr.LoadIconFromIconFile(XMessageBoxIcon.UserIcon, IconFileSelected);

                    srcCS += "DlgMgr.LoadIconFromIconFile(XMessageBoxIcon.UserIcon, " + CSNxt +
                        "\"" + FilenameToStr(IconFileSelected) + "\");" + CRLF;

                    srcVB += "DlgMgr.LoadIconFromIconFile(XMessageBoxIcon.UserIcon," + VBNxt +
                        "\"" + IconFileSelected + "\")" + CRLF;
                }
                else
                    if ((sourceFileType == ".exe") || (sourceFileType == ".dll"))
                    {
                        DlgMgr.LoadIconFromResourceFile(XMessageBoxIcon.UserIcon, IconFileSelected, (int)ResourceIndexSelected);

                        srcCS += "DlgMgr.LoadIconFromResourceFile(XMessageBoxIcon.UserIcon, " + CSNxt +
                            "\"" + FilenameToStr(IconFileSelected) + "\", " + ResourceIndexSelected.ToString() + ");" + CRLF;

                        srcVB += "DlgMgr.LoadIconFromResourceFile(XMessageBoxIcon.UserIcon," + VBNxt +
                            "\"" + IconFileSelected + "\", " + ResourceIndexSelected.ToString() + ")" + CRLF;
                    }
                    else
                    {
                        DlgMgr.LoadIconFromFileType(XMessageBoxIcon.UserIcon, IconFileSelected);
                        srcCS += "DlgMgr.LoadIconFromFileType(XMessageBoxIcon.UserIcon, " + CSNxt +
                            "\"" + FilenameToStr(IconFileSelected) + "\");" + CRLF;

                        srcVB += "DlgMgr.LoadIconFromFileType(XMessageBoxIcon.UserIcon," + VBNxt +
                            "\"" + IconFileSelected + "\")" + CRLF;
                    }
            }

            if (!IconWebLinkEnabled)
            {
                DlgMgr.AddWebLinkToIcon("");
                srcCS += "DlgMgr.AddWebLinkToIcon(\"\");" + CRLF;
                srcVB += "DlgMgr.AddWebLinkToIcon(\"\")" + CRLF;
            }
            else
            {
                DlgMgr.AddWebLinkToIcon(IconWebLink);
                srcCS += "DlgMgr.AddWebLinkToIcon(" + CSNxt + 
                    "\"" + IconWebLink + "\");\r" + CRLF;

                srcVB += "DlgMgr.AddWebLinkToIcon(" + VBNxt +
                    "\"" + IconWebLink + "\")\r" + CRLF;
            }
        }
    }
}
