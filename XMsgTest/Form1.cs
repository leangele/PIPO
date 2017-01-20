using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using XMsgLib.Dlg;

namespace XMsgTest
{

    public partial class formXMsgTest : Form
    {
        internal const String CRLF = "\r\n";
        internal const String DRLF = CRLF + CRLF;

        public formXMsgTest()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TestMessageBox();
        }


        private void TestMessageBox()
        {
            DlgMgr.DlgMonitorEnabled = chkDlgMonitor.Checked;

            //message
            messageSettings1.InitDialogSettings();

            //dialog dimensions
            dimensionSettings1.InitDialogSettings();

            //dialog position
            positionSettings1.InitDialogSettings();

            //background colors
            backgroundSettings1.InitDialogSettings();

            //icon
            MessageBoxIcon dialogIcon = MessageBoxIcon.Information;
            iconSettings1.InitDialogSettings();

            //buttons
            MessageBoxButtons dialogButtons = dialogButtonsSettings1.DialogButtonsSelected;
            dialogButtonsSettings1.InitDialogSettings();

            //additional controls
            hrefCtrlSettings1.InitDialogSettings();
            checkBoxCtrlSettings1.InitDialogSettings();
            textInputCtrlSettings1.InitDialogSettings();

            DisplaySourceCode();

            DialogResult dialogResult = MessageBox.Show(messageSettings1.DlgMessage,
                messageSettings1.DlgCaption,
                dialogButtons, 
                dialogIcon);

            toolStripReturnedValue.Text = dialogResult.ToString();
            toolStripTimeout.Text = DlgMgr.ClosedOnTimeout.ToString();
            toolStripAuxButton.Text = DlgMgr.AuxButtonPressed.ToString();
            toolStripCheckBox.Text = DlgMgr.CheckBoxState.ToString();
            toolStripTextInput.Text = DlgMgr.TextInputValue.Replace("\r\n", "");

            DlgMgr.DlgMonitorEnabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            messageSettings1.DlgMessageBackColor = backgroundSettings1.BackgroundColorMain;
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestMessageBox();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutXmsgDemo f = new AboutXmsgDemo();
            f.Show();
        }

        private void backgroundSettings1_OnBackgroundColorSelected(int mode, Color c)
        {
            if (mode == 0)
            {
                messageSettings1.DlgMessageBackColor = c;
            }
        }

        private void DisplaySourceCode()
        {
            generatedCode1.ClearPanes();

            generatedCode1.AddCode(dialogButtonsSettings1.SourceCodeCS, dialogButtonsSettings1.SourceCodeVB);

            generatedCode1.AddCode(dimensionSettings1.SourceCodeCS, dimensionSettings1.SourceCodeVB);
            generatedCode1.AddCode(positionSettings1.SourceCodeCS, positionSettings1.SourceCodeVB);

            generatedCode1.AddCode(backgroundSettings1.SourceCodeCS, backgroundSettings1.SourceCodeVB);
            generatedCode1.AddCode(iconSettings1.SourceCodeCS, iconSettings1.SourceCodeVB);

            generatedCode1.AddCode(textInputCtrlSettings1.SourceCodeCS, textInputCtrlSettings1.SourceCodeVB);
            generatedCode1.AddCode(hrefCtrlSettings1.SourceCodeCS, hrefCtrlSettings1.SourceCodeVB);
            generatedCode1.AddCode(checkBoxCtrlSettings1.SourceCodeCS, checkBoxCtrlSettings1.SourceCodeVB);

            generatedCode1.AddCode(messageSettings1.SourceCodeCS, messageSettings1.SourceCodeVB);

            String srcCS, srcVB;

            srcCS = CRLF + "//Dialog settings" + DRLF +
                "//Turning dialog extended features " + (chkDlgMonitor.Checked ? "on" : "OFF") + CRLF +
                "DlgMgr.DlgMonitorEnabled = " + chkDlgMonitor.Checked.ToString().ToLower() + ";" + DRLF;

            srcVB = CRLF + "'Dialog settings" + CRLF +
                "'Turning dialog extended features " + (chkDlgMonitor.Checked ? "on" : "OFF") + CRLF +
                "DlgMgr.DlgMonitorEnabled = " + chkDlgMonitor.Checked.ToString() + DRLF;

            String dialogHeader = "Extended MessageBox .NET Assembly";
            String dialogMessage = ".NET Framework: " + System.Runtime.InteropServices.RuntimeEnvironment.GetSystemVersion();

            srcCS += "MessageBox.Show(\"" + dialogMessage + "\", " + CRLF +
                "\t\"" + dialogHeader + "\", " + CRLF +
                "\tMessageBoxButtons." + dialogButtonsSettings1.DialogButtonsSelected.ToString() + ", " + CRLF +
                "\tMessageBoxIcon.Information);" + CRLF;

            srcVB += "MessageBox.Show(\"" + dialogMessage + "\", _" + CRLF +
                "\t\"" + dialogHeader + "\", _" + CRLF +
                "\tMessageBoxButtons." + dialogButtonsSettings1.DialogButtonsSelected.ToString() + ", _" + CRLF +
                "\tMessageBoxIcon.Information)" + CRLF;

            generatedCode1.AddCode(srcCS, srcVB);

            String notes = 
                "^DlgMgr members populated upon dialog closing:" + DRLF +
                "^Returns True when the dialog gets closed on timeout;" + CRLF +
                "^otherwise returns False" + CRLF +
                "^DlgMgr.ClosedOnTimeout" + DRLF +
                "^Returns aux.button ID that closed the dialog;" + CRLF +
                "^otherwise returns zero" + CRLF +
                "^DlgMgr.AuxButtonPressed" + DRLF +
                "^Returns CheckBox control Checked state;" + CRLF +
                "^returns False when the control not shown" + CRLF +
                "^DlgMgr.CheckBoxState" + DRLF +
                "^Returns text entered in the Text Input control;" + CRLF +
                "^returns empty string when the control not shown" + CRLF +
                "^DlgMgr.TextInputValue";

            generatedCode1.AddCode(notes.Replace("^", "//"), notes.Replace("^", "'"));
        }

    }
}