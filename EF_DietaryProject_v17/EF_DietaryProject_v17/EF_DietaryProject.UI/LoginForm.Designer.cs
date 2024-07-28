namespace EF_DietaryProject.UI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            chkShowPassword = new CheckBox();
            btnLogin = new Button();
            txtLoginPassword = new TextBox();
            txtLoginUsername = new TextBox();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(514, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(chkShowPassword);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(txtLoginPassword);
            groupBox1.Controls.Add(txtLoginUsername);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(468, 277);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "LOGIN DETAILS";
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            chkShowPassword.Location = new Point(143, 152);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(134, 24);
            chkShowPassword.TabIndex = 11;
            chkShowPassword.Text = "Show password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Goldenrod;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(139, 199);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(297, 51);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Location = new Point(142, 96);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.PlaceholderText = "Enter your password";
            txtLoginPassword.Size = new Size(294, 34);
            txtLoginPassword.TabIndex = 8;
            // 
            // txtLoginUsername
            // 
            txtLoginUsername.Location = new Point(142, 55);
            txtLoginUsername.Name = "txtLoginUsername";
            txtLoginUsername.PlaceholderText = "Enter your username";
            txtLoginUsername.Size = new Size(294, 34);
            txtLoginUsername.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 96);
            label4.Name = "label4";
            label4.Size = new Size(106, 28);
            label4.TabIndex = 3;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 54);
            label3.Name = "label3";
            label3.Size = new Size(111, 28);
            label3.TabIndex = 2;
            label3.Text = "Username:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(715, 457);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Button btnLogin;
        private TextBox txtLoginPassword;
        private TextBox txtLoginUsername;
        private Label label4;
        private Label label3;
        private CheckBox chkShowPassword;
    }
}