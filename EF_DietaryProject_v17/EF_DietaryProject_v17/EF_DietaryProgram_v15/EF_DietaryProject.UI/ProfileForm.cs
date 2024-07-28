using EF_DietaryProject.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_DietaryProject.UI
{
    public partial class ProfileForm : Form
    {
        string username;
        public ProfileForm(string username)
        {
            InitializeComponent();
            ResetData();
            this.username = username;
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            var user = UnitOfWork.Instance.AppUserRepository.GetAll().FirstOrDefault(x => x.Username == username);

            var userDetail = UnitOfWork.Instance.AppUserDetailRepository.GetAll().FirstOrDefault(x => x.AppUserId == user.Id);

            userDetail.Weight = Convert.ToInt16(nudWeight.Value);
            userDetail.Height = Convert.ToInt16(nudHeight.Value);
            userDetail.GenderId = (int)cmbGender.SelectedValue;
            userDetail.BirthDate = dtpBirthDate.Value;
            userDetail.TargetId = (int)cmbTarget.SelectedValue;

            UnitOfWork.Instance.AppUserDetailRepository.Update(userDetail);

            MessageBox.Show("The profile details have been saved.");

            MainPanel mainPanel = new MainPanel(username);
            mainPanel.Show();
            this.Hide();
        }

        private void ResetData()
        {
            cmbGender.DataSource = UnitOfWork.Instance.GenderRepository.GetAll();
            cmbTarget.DataSource = UnitOfWork.Instance.TargetRepository.GetAll();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            // FormBorderStyle ayarlama
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            // MinimumSize ve MaximumSize ayarlama
            this.MinimumSize = new System.Drawing.Size(400, 525);
            this.MaximumSize = new System.Drawing.Size(400, 525);

            cmbGender.ValueMember = "Id";
            cmbGender.DisplayMember = "Name";
            cmbTarget.ValueMember = "Id";
            cmbTarget.DisplayMember = "Name";

            var user = UnitOfWork.Instance.AppUserRepository.GetAll().FirstOrDefault(x => x.Username == username);

            var userDetail = UnitOfWork.Instance.AppUserDetailRepository.GetAll().FirstOrDefault(x => x.AppUserId == user.Id);

            nudWeight.Value = Convert.ToDecimal(userDetail.Weight);
            nudHeight.Value = Convert.ToDecimal(userDetail.Height);

            if (userDetail.GenderId == null)
            {
                cmbGender.SelectedValue = 0;
            }
            else
            {
                cmbGender.SelectedValue = (int)userDetail.GenderId;
            }

            if (userDetail.TargetId == null)
            {
                cmbTarget.SelectedValue = 0;
            }
            else
            {
                dtpBirthDate.Value = userDetail.BirthDate;
            }

        }
    }
}
