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
            General.OpenAndCloseForm(Name);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //string reportPath = Path.Combine(@"C:\Users\jeffry tobon\Documents\Visual Studio 2015\Projects\PIPO.Units\PIPO.Units", $"Reports\\{ReportName}");
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
