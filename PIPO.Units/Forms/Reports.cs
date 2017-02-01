using CrystalDecisions.CrystalReports.Engine;
using System;
using System.IO;
using System.Windows.Forms;

namespace LabTrack.Forms
{
    public partial class Reports : Form
    {
        public string ReportName { get; set; }
        public Reports(string reportName)
        {
            ReportName = reportName;
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string reportPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"Reports\\{ReportName}");
            var cryRpt = new ReportDocument();
            cryRpt.Load(reportPath);
            cryRpt.SetParameterValue("@DateStart", dtpStartDate.Text);
            cryRpt.SetParameterValue("@DateEnd", dtpFinisDate.Text);
            cryRpt.SetDatabaseLogon("prod", "prod");
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }
    }
}
