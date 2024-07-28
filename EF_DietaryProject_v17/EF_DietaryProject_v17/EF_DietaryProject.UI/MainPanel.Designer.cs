namespace EF_DietaryProject.UI
{
    partial class MainPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPanel));
            pictureBox1 = new PictureBox();
            btnMealProcesses = new Button();
            pictureBox2 = new PictureBox();
            btnReports = new Button();
            pictureBox3 = new PictureBox();
            btnProfileInformation = new Button();
            pictureBox4 = new PictureBox();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(44, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnMealProcesses
            // 
            btnMealProcesses.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnMealProcesses.Location = new Point(140, 48);
            btnMealProcesses.Name = "btnMealProcesses";
            btnMealProcesses.Size = new Size(257, 75);
            btnMealProcesses.TabIndex = 1;
            btnMealProcesses.Text = "MEAL PROCESSES";
            btnMealProcesses.UseVisualStyleBackColor = true;
            btnMealProcesses.Click += btnMealProcesses_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(44, 154);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 77);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // btnReports
            // 
            btnReports.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnReports.Location = new Point(140, 154);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(257, 77);
            btnReports.TabIndex = 3;
            btnReports.Text = "REPORTS";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(44, 263);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(80, 74);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // btnProfileInformation
            // 
            btnProfileInformation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnProfileInformation.Location = new Point(140, 260);
            btnProfileInformation.Name = "btnProfileInformation";
            btnProfileInformation.Size = new Size(257, 77);
            btnProfileInformation.TabIndex = 5;
            btnProfileInformation.Text = "PROFILE INFORMATION";
            btnProfileInformation.UseVisualStyleBackColor = true;
            btnProfileInformation.Click += btnProfileInformation_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(44, 365);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(79, 70);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnExit.Location = new Point(140, 365);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(257, 70);
            btnExit.TabIndex = 7;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // MainPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(458, 468);
            Controls.Add(btnExit);
            Controls.Add(pictureBox4);
            Controls.Add(btnProfileInformation);
            Controls.Add(pictureBox3);
            Controls.Add(btnReports);
            Controls.Add(pictureBox2);
            Controls.Add(btnMealProcesses);
            Controls.Add(pictureBox1);
            Name = "MainPanel";
            Text = "MainPanel";
            Load += MainPanel_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnMealProcesses;
        private PictureBox pictureBox2;
        private Button btnReports;
        private PictureBox pictureBox3;
        private Button btnProfileInformation;
        private PictureBox pictureBox4;
        private Button btnExit;
    }
}