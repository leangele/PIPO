using LabTrack.DAL;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Windows.Forms;

namespace LabTrack.Forms
{
    [SuppressMessage("ReSharper", "PrivateFieldCanBeConvertedToLocalVariable")]
    public partial class Admin : Form
    {
        private readonly UnitOfWork _unitOfWork;
        public bool IsLoged { get; set; }
        public bool GetValueLogin { get; set; }

        private readonly List<Configuration> _listConfig;

        public Admin(UnitOfWork unitOfWork, bool isLoged)
        {
            _unitOfWork = unitOfWork;
            IsLoged = isLoged;
            _listConfig = _unitOfWork.ListConfigurations();
            InitializeComponent();
        }


        private void formAdmin_Load(object sender, EventArgs e)
        {
            ModifyForm();
        }

        private void ModifyForm()
        {
            if (!IsLoged) return;
            btnLogin.Text = @"LogOut";
            txtPassword.Enabled = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LogInLogOut();
        }

        private void LogInLogOut()
        {
            var singleOrDefault = _listConfig.SingleOrDefault(x => x.Name == "Password");
            if (singleOrDefault != null && txtPassword.Text == singleOrDefault.Value)
            {
                ChangeStatusLog(true);
            }
            else if (txtPassword.Enabled)
            {
                var Title = "Error";
                var message = $"Password incorrect!";

                AutoClosingMessageBox.Show(message, Title, 10000);
            }
            else
            {
                ChangeStatusLog(false);
            }
        }

        private void ChangeStatusLog(bool status)
        {
            IsLoged = status;
            ModifyForm();
            Close();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != Convert.ToChar(Keys.Enter)) return;
            LogInLogOut();
        }
    }
}
