using LabTrack.DAL;
using LabTrack.DTO;
using LabTrack.Interfaces;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LabTrack.Forms
{
    public partial class Report : Form
    {
        private static IUnitOfWork UnitOfWork { get; set; }
        public bool IsAdministrationOn { get; set; }

        public Report(UnitOfWork unitOfWork, bool isAdministrationOn)
        {
            UnitOfWork = unitOfWork;
            IsAdministrationOn = isAdministrationOn;
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {


            reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dsCustomers = GetData();
            var datasource = new ReportDataSource("UnitPerDay", dsCustomers);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(datasource);
            reportViewer1.RefreshReport();
        }

        private IEnumerable<SearchInformationOutDto> GetData()
        {

            return
                UnitOfWork.DalStoredProcedures.ListUnitsPerDay(new SearchInformationDto
                {
                    DateStart = DateTime.Parse(dtpStart.Text),
                    DateEnd = DateTime.Parse(dtpEnd.Text),
                    Filter = cbxFilter.SelectedItem.ToString()
                });
        }
    }
}
