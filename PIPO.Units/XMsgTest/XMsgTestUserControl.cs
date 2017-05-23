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
    public partial class XMsgTestUserControl : UserControl
    {
        internal String srcCS = "";
        internal String srcVB = "";
        internal const String CRLF = "\r\n";
        internal const String DRLF = CRLF+CRLF;
        internal const String VBNxt = " _\r\n\t";
        internal const String CSNxt = "\r\n\t";

        public String SourceCodeCS
        {
            get { return srcCS; }
        }

        public String SourceCodeVB
        {
            get { return srcVB; }
        }

        public XMsgTestUserControl()
        {
            InitializeComponent();
        }
        public virtual void InitDialogSettings()
        {
        }

        public String ColorToStr(Color c)
        {
            String result = "Color.FromArgb(" + c.ToArgb().ToString() + ")";
            return result;
        }

        public String FontToStr(Font f)
        {
            String result = 
                "\"" + f.Name + "\", " +
                ((int)f.Size).ToString() + ", " +
                (f.Italic == true ? "1" : "0") + ", " +
                (f.Bold == true ? "1" : "0") + ", " +
                (f.Underline == true ? "1" : "0") + ", " +
                (f.Strikeout == true ? "1" : "0") + ", " +
                "0";

            return result;
        }

        public String FilenameToStr(String fileName)  //CS only
        {
            return fileName.Replace("\\", "\\\\");
        }
    }
}
