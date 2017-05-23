using System.Drawing;
using System.Windows.Forms;
using XMsgLib.Dlg;

namespace LabTrack.Forms
{
    public static class ExtendedMsgBox
    {
        public static bool True { get; set; }
        public static void ExtendeMessagesShow()
        {
            //Dialog Button settings
            DlgMgr.ResetDlgButtons();

            DlgMgr.AssignButtonCaption(XMessageBoxButton.ButtonNo, "Non");
            DlgMgr.AssignButtonEnabled(XMessageBoxButton.ButtonNo, True);
            DlgMgr.AssignButtonToolTip(XMessageBoxButton.ButtonNo, "");
            DlgMgr.AssignButtonFont(XMessageBoxButton.ButtonNo,
                "Microsoft Sans Serif", 8, 0, 0, 0, 0, 0);

            DlgMgr.AssignButtonCaption(XMessageBoxButton.ButtonYes, "Oui");
            DlgMgr.AssignButtonEnabled(XMessageBoxButton.ButtonYes, True);
            DlgMgr.AssignButtonToolTip(XMessageBoxButton.ButtonYes, "");
            DlgMgr.AssignButtonFont(XMessageBoxButton.ButtonYes,
                "Microsoft Sans Serif", 8, 0, 0, 0, 0, 0);

            //Dialog Dimension settings
            DlgMgr.AssignDlgMaxSize(600, 0);

            //Dialog Position settings
            //absolute
            DlgMgr.AssignDlgPosition(100, 200,
                XMessageBoxPositionMode.AbsolutePosition);

            //Dialog Background settings
            DlgMgr.UdfBackcolorsEnabled = true;
            DlgMgr.ResetBackColor(XMessageBoxBackground.DlgWindow);
            DlgMgr.LoadBackColorFromSolidColor(XMessageBoxBackground.ToolBarWindow,
                Color.FromArgb(-9404272));

            //Dialog Icon settings
            DlgMgr.UdfIconsEnabled = true;
            DlgMgr.LoadIconFromFileType(XMessageBoxIcon.UserIcon,
                "*.cs");
            DlgMgr.AddWebLinkToIcon("");

            //Text Input Control settings
            DlgMgr.EnableTextInputCtrl();

            //Web Link Control settings
            //DlgMgr.EnableHrefCtrl(
            //    "http://www.news2news.com/vfp/?solution=5",
            //    "Extended MessageBox .NET web page",
            //    Color.FromArgb(-16776961));

            //CheckBox Control settings
            DlgMgr.EnableCheckBoxCtrl();

            //Message settings
            DlgMgr.AssignMessageFont("Segoe UI", 14, 0, 0, 0, 0, 0);
            DlgMgr.MessageFontColor = Color.FromArgb(-13676721);
            DlgMgr.TimeoutMilliseconds = 10000;
            DlgMgr.AddWebLinkToMessage("");


            //Dialog settings

            //Turning dialog extended features on
            DlgMgr.DlgMonitorEnabled = true;

            MessageBox.Show("Alert",
                "Hola mundo",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);

            //DlgMgr members populated upon dialog closing:

            //Returns True when the dialog gets closed on timeout;
            //otherwise returns False
            //DlgMgr.ClosedOnTimeout

            //Returns aux.button ID that closed the dialog;
            //otherwise returns zero
            //DlgMgr.AuxButtonPressed

            //Returns CheckBox control Checked state;
            //returns False when the control not shown
            //DlgMgr.CheckBoxState

            //Returns text entered in the Text Input control;
            //returns empty string when the control not shown
            //DlgMgr.TextInputValue
        }


    }
}