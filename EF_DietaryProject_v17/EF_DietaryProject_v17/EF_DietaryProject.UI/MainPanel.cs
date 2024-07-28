using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_DietaryProject.UI
{
    public partial class MainPanel : Form
    {
        string username;
        public MainPanel(string username)
        {
            InitializeComponent();
            this.username = username;
            pictureBox1.ImageLocation = ".\\Images\\MealProcessPicture.png";
            //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void MainPanel_Load(object sender, EventArgs e)
        {
            // FormBorderStyle ayarlama
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            // MinimumSize ve MaximumSize ayarlama
            //this.MinimumSize = new System.Drawing.Size(475, 550);
            //this.MaximumSize = new System.Drawing.Size(475, 550);
        }

        private void btnProfileInformation_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm(username);
            profileForm.ShowDialog();
        }

        private void btnMealProcesses_Click(object sender, EventArgs e)
        {
            MealProcessesForm mealProcessesForm = new MealProcessesForm(username);
            mealProcessesForm.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new ReportsForm(username);
            reportsForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
