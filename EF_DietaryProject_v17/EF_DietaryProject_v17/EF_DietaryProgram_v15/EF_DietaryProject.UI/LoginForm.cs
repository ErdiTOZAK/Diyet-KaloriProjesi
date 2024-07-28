using EF_DietaryProject.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EF_DietaryProject.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLoginUsername.Text) || string.IsNullOrWhiteSpace(txtLoginPassword.Text))
            {
                MessageBox.Show("Please fill out all the texts.");
            }
            else
            {
                var result = UnitOfWork.Instance.AppUserRepository.GetAll().FirstOrDefault(x => x.Username == txtLoginUsername.Text && x.Password == HashMethod.SHA256_hash(txtLoginPassword.Text));

                if (result != null)
                {
                    MessageBox.Show("Login is successfull");

                    if (!IsProfileInfoEntered())
                    {
                        ProfileForm profileForm = new ProfileForm(txtLoginUsername.Text);
                        profileForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MainPanel mainPanel = new MainPanel(txtLoginUsername.Text);
                        mainPanel.Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("Login failed. Wrong username or password.");
                }
            }
        }

        private bool IsProfileInfoEntered()
        {
            var user = UnitOfWork.Instance.AppUserRepository.GetAll().FirstOrDefault(x => x.Username == txtLoginUsername.Text);

            var userDetail = UnitOfWork.Instance.AppUserDetailRepository.GetAll().FirstOrDefault(x => x.AppUserId == user.Id);

            if (userDetail.TargetId == null)
            {
                return false;
            }
            return true;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtLoginPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtLoginPassword.UseSystemPasswordChar = true;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Şifre kutusunu başlangıçta gizli yap
            txtLoginPassword.UseSystemPasswordChar = true;

            // Checkbox'ı başlangıçta işaretlenmemiş olarak ayarla
            chkShowPassword.Checked = false;
        }
    }
}
