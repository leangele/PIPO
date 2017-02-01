using LabTrack.DAL;
using LabTrack.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LabTrack.Forms
{
    public partial class DataCases : Form
    {
        public bool IsAdministrationOn { get; set; }
        private static UnitOfWork _unitOfWork;

        readonly List<Configuration> _listConfig;
        private List<Area> _listAreas;
        public int Seconds { get; set; }
        public DataCases(UnitOfWork unitOfWork, bool isAdministrationOn)
        {
            IsAdministrationOn = isAdministrationOn;
            _unitOfWork = unitOfWork;
            InitializeComponent();
            InitialCharge();
            _listConfig = _unitOfWork.ListConfigurations();
            Seconds = 0;
            timer1.Interval = 1000;
            timer1.Start();
        }


        private void InitialCharge()
        {
            _listAreas = _unitOfWork.DalAreas.ListAreas();
            _listAreas.Insert(0, new Area { Id = 0, Name = "All Areas" });

            cbxAreasInform.DataSource = _listAreas;
            cbxAreasInform.ValueMember = "id";
            cbxAreasInform.DisplayMember = "name";
        }
        private void CompareDataByDay(List<CaseControlDto> lisCases)
        {
            var objArea = (Area)cbxAreasInform.SelectedItem;
            var closedToday =
                lisCases.Where(x => x.DtFinish != null && x.IdArea == objArea.Id)
                    .Where(y => y.DtFinish != null && y.DtFinish.Value.Date == DateTime.Now.Date)
                    .ToList();
            double average, secondTotal;
            var unitsClosedToday = CalculateAverage(closedToday, out average, out secondTotal);
            var casesAreaOpenToday = lisCases.Where(x => x.DtRecive != null && (x.IdArea == objArea.Id && x.DtRecive.Value.Date == DateTime.Now.Date)).ToList();
            lblCasesCosedToday.Text = closedToday.Count.ToString();
            lblCasesOpenToday.Text = casesAreaOpenToday.Count.ToString();
            lblAreaNamePrinted.Text = objArea.Name;
            lblNamePerson.Text = objArea.NamePerson;
            lblUnitCosedToday.Text = unitsClosedToday.ToString();

            var timeConsumed = TimeSpan.FromSeconds(secondTotal);
            var minutes = string.IsNullOrWhiteSpace((TimeSpan.FromSeconds(average).Minutes).ToString("##"))
                ? "0"
                : (TimeSpan.FromSeconds(average).Minutes).ToString("##");
            var seconds = (TimeSpan.FromSeconds(average).Seconds).ToString("##");
            lblAveragePerUnitToday.Text = string.IsNullOrWhiteSpace((average).ToString("##")) ? "0" : $"{minutes}:{seconds}";

            lblTimePerDayInCases.Text = timeConsumed.ToString((@"dd\.hh\:mm\:ss"));

        }



        private void CompareDataByWeek(List<CaseControlDto> lisCases)
        {
            var actualDay = DateTime.Now;
            var delta = DayOfWeek.Monday - actualDay.DayOfWeek;
            var monday = actualDay.AddDays(delta);

            var textArea = (Area)cbxAreasInform.SelectedItem;
            var casesAreaClosedThisWeek =
                lisCases
                    .Where(x => x.DtFinish != null &&
                        x.IdArea == textArea.Id)
                    .Where(y => y.DtFinish != null &&
                        y.DtFinish.Value.Date >= monday.Date &&
                        y.DtFinish.Value.Date <= actualDay.Date)
                    .ToList();

            var closedThisWeek =
                lisCases.Where(y => y.IdArea == textArea.Id &&
                                    y.DtFinish != null &&
                                    y.DtFinish.Value.Date >= monday.Date &&
                                    y.DtFinish.Value.Date <= actualDay.Date);

            double average, secondTotal;

            var unitsClosedThisWeek = CalculateAverage(closedThisWeek, out average, out secondTotal);


            var casesAreaOpenThisWeek = lisCases
                .Where(x => x.DtRecive != null && (x.DtFinish == null &&
                                                   x.IdArea == textArea.Id &&
                                                   x.DtRecive.Value.Date >= monday.Date &&
                                                   x.DtRecive.Value.Date <= actualDay.Date))
                .ToList();

            lblCasesCosedThisWeek.Text = casesAreaClosedThisWeek.Count.ToString();
            lblCasesOpenThisweek.Text = casesAreaOpenThisWeek.Count.ToString();
            lblUnidCosedThisWeek.Text = unitsClosedThisWeek.ToString();
            lblAreaNamePrinted.Text = textArea.Name;
            lblNamePerson.Text = textArea.NamePerson;

            var timeConsumed = TimeSpan.FromSeconds(secondTotal);
            var minutes = string.IsNullOrWhiteSpace((TimeSpan.FromSeconds(average).Minutes).ToString("##"))
                ? "0"
                : (TimeSpan.FromSeconds(average).Minutes).ToString("##");
            var seconds = (TimeSpan.FromSeconds(average).Seconds).ToString("##");
            lblAveragePerUnitThisWeek.Text = string.IsNullOrWhiteSpace((average).ToString("##")) ? "0" : $"{minutes}:{seconds}";

            lblTimePerWeekInCases.Text = timeConsumed.ToString((@"dd\.hh\:mm\:ss"));
        }

        private static int CalculateAverage(IEnumerable<CaseControlDto> closedThisWeek, out double average, out double secondTotal)
        {
            var caseControlDtos = closedThisWeek as IList<CaseControlDto> ?? closedThisWeek.ToList();
            secondTotal = caseControlDtos
                .Aggregate<CaseControlDto, double>(0, (current, caseControlDto) => caseControlDto.DtStart != null ? (caseControlDto.DtFinish != null ? current + ((DateTime)caseControlDto.DtFinish)
                    .Subtract(((DateTime)caseControlDto.DtStart)).TotalSeconds : 0) : 0);

            var unitsClosed = _unitOfWork.DalCases.FindCasesByRange(caseControlDtos).Sum(x => x.Units);


            average = Math.Abs(secondTotal) > 0 && unitsClosed != 0 ? secondTotal / unitsClosed : 0;


            return unitsClosed;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CompareDataByDay(ListCases());
            CompareDataByWeek(ListCases());
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            var singleOrDefault = _listConfig.SingleOrDefault(x => x.Name == "ChangeAreasSeconds");
            if (singleOrDefault != null && Seconds > int.Parse(singleOrDefault.Value))
            {
                var amountItems = cbxAreasInform.Items.Count;
                if (amountItems == cbxAreasInform.SelectedIndex + 1)
                    cbxAreasInform.SelectedIndex = 0;
                else
                    cbxAreasInform.SelectedIndex = cbxAreasInform.SelectedIndex + 1;
                Seconds = 0;
            }
            else
            {
                Seconds++;
            }
        }

        public List<CaseControlDto> ListCases()
        {
            return _unitOfWork.DalCasesControl.ListCases();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
