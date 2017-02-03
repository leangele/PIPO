using LabTrack.DAL;
using System;
using System.Windows.Forms;

namespace LabTrack.Forms
{
    public partial class ModifyUnits : Form
    {
        private UnitOfWork UnitOfWork { get; set; }
        public Case Case { get; set; }


        public ModifyUnits(UnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
            InitializeComponent();
        }

        private void ModifyUnits_Load(object sender, System.EventArgs e)
        {
            try
            {
                Case = UnitOfWork.DalCases.FindCaseByCode(Case.Code);
                LblCase.Text = Case.Code.ToString();
                nudUnits.Text = Case.Units.ToString();
            }
            catch (Exception ex)
            {
                General.ControlErrorEx(ex, Name);
            }

        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            AddRemoveUnitsScaner(Case);
            Close();
        }

        private void AddRemoveUnitsScaner(Case caseForChange)
        {
            caseForChange.Units = int.Parse(nudUnits.Text);
            UnitOfWork.SaveData();
        }
    }
}
