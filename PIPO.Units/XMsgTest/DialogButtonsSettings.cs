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
    public partial class DialogButtonsSettings : XMsgTestUserControl
    {
        public MessageBoxButtons DialogButtonsSelected
        {
            get
            {
                MessageBoxButtons dialogButtons = MessageBoxButtons.OK;

                switch (comboDlgButtons.SelectedIndex)
                {
                    case 0:
                        dialogButtons = MessageBoxButtons.AbortRetryIgnore;
                        break;
                    case 1:
                        dialogButtons = MessageBoxButtons.OK;
                        break;
                    case 2:
                        dialogButtons = MessageBoxButtons.OKCancel;
                        break;
                    case 3:
                        dialogButtons = MessageBoxButtons.RetryCancel;
                        break;
                    case 4:
                        dialogButtons = MessageBoxButtons.YesNo;
                        break;
                    case 5:
                        dialogButtons = MessageBoxButtons.YesNoCancel;
                        break;
                }
                return dialogButtons;
            }
            set
            {
                switch (value)
                {
                    case MessageBoxButtons.AbortRetryIgnore:
                        comboDlgButtons.SelectedIndex = 0;
                        break;
                    case MessageBoxButtons.OK:
                        comboDlgButtons.SelectedIndex = 1;
                        break;
                    case MessageBoxButtons.OKCancel:
                        comboDlgButtons.SelectedIndex = 2;
                        break;
                    case MessageBoxButtons.RetryCancel:
                        comboDlgButtons.SelectedIndex = 3;
                        break;
                    case MessageBoxButtons.YesNo:
                        comboDlgButtons.SelectedIndex = 4;
                        break;
                    case MessageBoxButtons.YesNoCancel:
                        comboDlgButtons.SelectedIndex = 5;
                        break;
                    default:
                        comboDlgButtons.SelectedIndex = 1;
                        break;
                }
            }
        }

        public DialogButtonsSettings()
        {
            InitializeComponent();

            dbsAbort.ButtonId = XMessageBoxButton.ButtonAbort;
            dbsAux01.ButtonId = XMessageBoxButton.ButtonAux01;
            dbsAux02.ButtonId = XMessageBoxButton.ButtonAux02;
            dbsAux03.ButtonId = XMessageBoxButton.ButtonAux03;
            dbsButton07.ButtonId = XMessageBoxButton.Button07;
            dbsCancel.ButtonId = XMessageBoxButton.ButtonCancel;
            dbsContinue.ButtonId = XMessageBoxButton.ButtonContinue;
            dbsHelp.ButtonId = XMessageBoxButton.ButtonHelp;
            dbsIgnore.ButtonId = XMessageBoxButton.ButtonIgnore;
            dbsNo.ButtonId = XMessageBoxButton.ButtonNo;
            dbsOk.ButtonId = XMessageBoxButton.ButtonOk;
            dbsRetry.ButtonId = XMessageBoxButton.ButtonRetry;
            dbsTryAgain.ButtonId = XMessageBoxButton.ButtonTryAgain;
            dbsYes.ButtonId = XMessageBoxButton.ButtonYes;
        }

        public override void InitDialogSettings()
        {
            srcCS = "//Dialog Button settings" + CRLF;
            srcVB = "'Dialog Button settings" + CRLF;

            DlgMgr.ResetDlgButtons();
            srcCS += "DlgMgr.ResetDlgButtons();" + CRLF;
            srcVB += "DlgMgr.ResetDlgButtons()" + CRLF;

            dbsAbort.InitDialogSettings();
            dbsAux01.InitDialogSettings();
            dbsAux02.InitDialogSettings();
            dbsAux03.InitDialogSettings();
            dbsButton07.InitDialogSettings();
            dbsCancel.InitDialogSettings();
            dbsContinue.InitDialogSettings();
            dbsHelp.InitDialogSettings();
            dbsIgnore.InitDialogSettings();
            dbsNo.InitDialogSettings();
            dbsOk.InitDialogSettings();
            dbsRetry.InitDialogSettings();
            dbsTryAgain.InitDialogSettings();
            dbsYes.InitDialogSettings();

            srcCS += dbsAbort.SourceCodeCS +
                dbsAux01.SourceCodeCS +
                dbsAux02.SourceCodeCS +
                dbsAux03.SourceCodeCS +
                dbsButton07.SourceCodeCS +
                dbsCancel.SourceCodeCS +
                dbsContinue.SourceCodeCS +
                dbsHelp.SourceCodeCS +
                dbsIgnore.SourceCodeCS +
                dbsNo.SourceCodeCS +
                dbsOk.SourceCodeCS +
                dbsRetry.SourceCodeCS +
                dbsTryAgain.SourceCodeCS +
                dbsYes.SourceCodeCS;

            srcVB += dbsAbort.SourceCodeVB +
                dbsAux01.SourceCodeVB +
                dbsAux02.SourceCodeVB +
                dbsAux03.SourceCodeVB +
                dbsButton07.SourceCodeVB +
                dbsCancel.SourceCodeVB +
                dbsContinue.SourceCodeVB +
                dbsHelp.SourceCodeVB +
                dbsIgnore.SourceCodeVB +
                dbsNo.SourceCodeVB +
                dbsOk.SourceCodeVB +
                dbsRetry.SourceCodeVB +
                dbsTryAgain.SourceCodeVB +
                dbsYes.SourceCodeVB;
        }
    }
}
