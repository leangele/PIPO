using PIPO.Units.DAL;
using PIPO.Units.DTO;
using PIPO.Units.Interfaces;
using PIPO.Units.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PIPO.Units.Forms
{
    public partial class ProductivityForm : Form
    {
        public IUnitOfWork UnitOfWork { get; set; }
        List<CaseControlDto> listCases;
        public int seconds { get; set; }

        public ProductivityForm()
        {
            InitializeComponent();
            InitialCharge();
            seconds = 0;
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void InitialCharge()
        {
            UnitOfWork = new UnitOfWork(new CasesControlEntities());
            listCases = ListCases().OrderByDescending(x => x.Id).ToList();
            dgvData.DataSource = listCases;
            dgvData.Columns[0].Visible = false;
            //CalculateColors();
            var listAreas = UnitOfWork.DalAreas.ListAreas();
            var listAreas2 = UnitOfWork.DalAreas.ListAreas();

            cbxArea.DataSource = listAreas;
            cbxArea.ValueMember = "id";
            cbxArea.DisplayMember = "name";

            cbxAreasInform.DataSource = listAreas2;
            cbxAreasInform.ValueMember = "id";
            cbxAreasInform.DisplayMember = "name";
            CompareData(listCases);
        }

        //private void CalculateColors()
        //{
        //    int index = 0;
        //    foreach (DataGridViewRow row in dgvData.Rows)
        //    {
        //        var dtFinish = listCases[index].DtFinish;
        //        var dtRecive = listCases[index].DtRecive;

        //        if (dtRecive != null)
        //        {
        //            var difDates2 = DateTime.Now.Date.Subtract(((DateTime)dtRecive).Date).Days;
        //            var difDates = (DateTime.Now - dtRecive);
        //            if (dtFinish == null && difDates < new TimeSpan(3, 0, 0, 0))
        //            {
        //                row.DefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.Red };
        //                row.Selected = true;

        //            }
        //        }
        //        index = +1;
        //    }
        //}

        private void CompareData(List<CaseControlDto> lisCases)
        {
            var textArea = (Area)cbxAreasInform.SelectedItem;
            var casesAreaClosedToday =
                lisCases.Where(x => x.DtFinish != null && x.IdArea == textArea.Id)
                    .Where(y => y.DtFinish != null && y.DtFinish.Value.Date == DateTime.Now.Date)
                    .ToList();
            var casesAreaOpenToday = lisCases.Where(x => x.DtFinish == null && x.IdArea == textArea.Id).ToList();
            lblCasesCosedToday.Text = casesAreaClosedToday.Count.ToString();
            lblCasesOpenToday.Text = casesAreaOpenToday.Count.ToString();
            lblAreaNamePrinted.Text = textArea.Name;
            lblNamePerson.Text = textArea.NamePerson;
        }


        private void CreateCase()
        {
            int nro;
            int.TryParse(txtCode.Text, out nro);
            var idArea = int.Parse(cbxArea.SelectedValue.ToString());
            var objCase = UnitOfWork.DalCases.FindCaseByCode(nro);
            if (objCase != null)
            {
                var data = UnitOfWork.DalCasesControl.GetCaseControlByIdAreaAndCode(nro, idArea);
                if (data == null)
                {
                    UnitOfWork.DalCasesControl.CreateCaseControl(nro, idArea);
                }
                else
                {
                    if (data.dtFinish == null && data.dtStart == null)
                    {
                        data.dtStart = DateTime.Now;
                    }
                    else
                    {
                        if (data.dtFinish == null)
                        {
                            data.dtFinish = DateTime.Now;
                        }
                        else
                        {
                            MessageBox.Show(
                                $"Case Create and saved at:Recived{data.dtRecive} Stared{data.dtStart} Finished{data.dtFinish}");
                        }

                    }
                }
                objCase.IsInProduction = true;

                //UnitOfWork.DalCases.ModifyCase(objCase);
                UnitOfWork.SaveData();
                txtCode.Text = string.Empty;
                dgvData.DataSource = ListCases().OrderByDescending(x => x.Id).ToList();



            }
            else
            {
                MessageBox.Show(Resources.ProductivityForm_CreateCase_Case_not_created_previously);
            }


        }


        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                CreateCase();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");

            if (seconds > 5)
            {
                var amountItems = cbxAreasInform.Items.Count;
                if (amountItems == cbxAreasInform.SelectedIndex + 1)
                {
                    cbxAreasInform.SelectedIndex = 0;
                }
                else
                {
                    cbxAreasInform.SelectedIndex = cbxAreasInform.SelectedIndex + 1;
                }

                seconds = 0;
            }
            else
            {
                seconds += 1;
            }

        }

        private void cbxAreasInform_SelectedIndexChanged(object sender, EventArgs e)
        {
            CompareData(ListCases());
        }

        private List<CaseControlDto> ListCases()
        {
            return UnitOfWork.DalCasesControl.ListCases();
        }

        private void dgvData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            listCases = ListCases().OrderByDescending(x => x.Id).ToList();
            var dtFinish = listCases[e.RowIndex].DtFinish;
            var dtRecive = listCases[e.RowIndex].DtRecive;
            //var difDates = DateTime.Now - dtRecive;

            var difDates = DateTime.Now.Date.Subtract(((DateTime)dtRecive).Date).Days;

            var xHoursMaximun = int.Parse(Resources.xHoursMaximun);
            var xHoursMinimun = int.Parse(Resources.xHoursMinimun);


            if (dtFinish == null)
            {
                if (difDates < xHoursMinimun)
                {
                    dgvData.Rows[e.RowIndex].DefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.Green };
                }
                else if (xHoursMinimun < difDates && difDates < xHoursMaximun)

                {
                    dgvData.Rows[e.RowIndex].DefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.Yellow };
                }
                else
                {
                    dgvData.Rows[e.RowIndex].DefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.Red };
                }
            }
            else
            {
                dgvData.Rows[e.RowIndex].DefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.White };
            }
        }
    }
}
