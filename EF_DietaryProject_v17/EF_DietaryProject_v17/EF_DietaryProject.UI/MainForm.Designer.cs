namespace EF_DietaryProject.UI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pictureBox1 = new PictureBox();
            btnLogin = new Button();
            btnRegister = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(911, 330);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Khaki;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnLogin.Location = new Point(222, 492);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(203, 85);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Gold;
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnRegister.Location = new Point(465, 492);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(203, 85);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.White;
            label1.Location = new Point(273, 346);
            label1.Name = "label1";
            label1.Size = new Size(360, 28);
            label1.TabIndex = 3;
            label1.Text = "Welcome to TET-Dietary Application";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(155, 395);
            label2.Name = "label2";
            label2.Size = new Size(592, 28);
            label2.TabIndex = 4;
            label2.Text = "With this application, you can track your daily calory intake. ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(222, 444);
            label3.Name = "label3";
            label3.Size = new Size(454, 28);
            label3.TabIndex = 5;
            label3.Text = "To use the application, please login or register.";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Teal;
            ClientSize = new Size(908, 589);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(pictureBox1);
            Name = "MainForm";
            Text = "Hoşgeldiniz";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnLogin;
        private Button btnRegister;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
