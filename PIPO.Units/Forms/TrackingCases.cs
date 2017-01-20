using LabTrack.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LabTrack.Forms
{
    public partial class TrackingCases : Form
    {
        private readonly List<CaseControlDto> _casesTrack;

        public TrackingCases(List<CaseControlDto> casesTrack)
        {
            _casesTrack = casesTrack;
            InitializeComponent();
        }

        private void TrackingCases_Load(object sender, EventArgs e)
        {
            if (_casesTrack.Count == 0)
            {
                Close();
            }
            else
            {
                dgvCaseTrack.DataSource = _casesTrack;
            }
        }
    }
}
