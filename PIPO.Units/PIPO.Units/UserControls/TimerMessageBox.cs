using System;
using System.Windows.Forms;

namespace LabTrack.UserControls
{
    public partial class TimerMessageBox : UserControl
    {
        public string Message
        {
            get { return Message; }
            set
            {
                lblMesage.Text = value;

            }
        }

        public int Sec { get; set; }

        private int _sec;

        public TimerMessageBox(string message, int time, TypeMessage typeMessage = TypeMessage.Information)
        {
            Message = message;
            _sec = time;
            InitializeComponent();
            timClose.Interval = 1000;
            timClose.Start();
        }

        private void TimerMessageBox_Load(object sender, EventArgs e)
        {

        }

        private void timClose_Tick(object sender, EventArgs e)
        {
            _sec--;
            if (_sec <= 0)
            {
                Application.Exit();
            }
        }
    }
}
