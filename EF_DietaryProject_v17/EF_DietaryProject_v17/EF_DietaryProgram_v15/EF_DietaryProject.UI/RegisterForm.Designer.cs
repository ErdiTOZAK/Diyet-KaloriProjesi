namespace EF_DietaryProject.UI
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            groupBox1 = new GroupBox();
            btnRegister = new Button();
            txtRegRetypePassword = new TextBox();
            txtRegPassword = new TextBox();
            txtRegUsername = new TextBox();
            txtRegSurname = new TextBox();
            txtRegName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            groupBox1.Controls.Add(btnRegister);
            groupBox1.Controls.Add(txtRegRetypePassword);
            groupBox1.Controls.Add(txtRegPassword);
            groupBox1.Controls.Add(txtRegUsername);
            groupBox1.Controls.Add(txtRegSurname);
            groupBox1.Controls.Add(txtRegName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(14, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(553, 331);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "REGISTRATION DETAILS";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.SteelBlue;
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(211, 258);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(297, 51);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtRegRetypePassword
            // 
            txtRegRetypePassword.Location = new Point(214, 208);
            txtRegRetypePassword.Name = "txtRegRetypePassword";
            txtRegRetypePassword.Size = new Size(294, 34);
            txtRegRetypePassword.TabIndex = 9;
            // 
            // txtRegPassword
            // 
            txtRegPassword.Location = new Point(214, 167);
            txtRegPassword.Name = "txtRegPassword";
            txtRegPassword.Size = new Size(294, 34);
            txtRegPassword.TabIndex = 8;
            // 
            // txtRegUsername
            // 
            txtRegUsername.Location = new Point(214, 126);
            txtRegUsername.Name = "txtRegUsername";
            txtRegUsername.Size = new Size(294, 34);
            txtRegUsername.TabIndex = 7;
            // 
            // txtRegSurname
            // 
            txtRegSurname.Location = new Point(214, 86);
            txtRegSurname.Name = "txtRegSurname";
            txtRegSurname.Size = new Size(294, 34);
            txtRegSurname.TabIndex = 6;
            // 
            // txtRegName
            // 
            txtRegName.Location = new Point(214, 46);
            txtRegName.Name = "txtRegName";
            txtRegName.Size = new Size(294, 34);
            txtRegName.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 208);
            label5.Name = "label5";
            label5.Size = new Size(178, 28);
            label5.TabIndex = 4;
            label5.Text = "Retype Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 167);
            label4.Name = "label4";
            label4.Size = new Size(106, 28);
            label4.TabIndex = 3;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 125);
            label3.Name = "label3";
            label3.Size = new Size(111, 28);
            label3.TabIndex = 2;
            label3.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 86);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 1;
            label2.Text = "Surname:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 46);
            label1.Name = "label1";
            label1.Size = new Size(73, 28);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(601, 120);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.Location = new Point(14, 366);
            label6.Name = "label6";
            label6.Size = new Size(371, 20);
            label6.TabIndex = 2;
            label6.Text = "The password must fulfill the following requirements:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label7.Location = new Point(49, 395);
            label7.Name = "label7";
            label7.Size = new Size(145, 20);
            label7.TabIndex = 3;
            label7.Text = "At least 8 characters";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label8.Location = new Point(49, 424);
            label8.Name = "label8";
            label8.Size = new Size(191, 20);
            label8.TabIndex = 4;
            label8.Text = "At least 2 uppercase letters";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label9.Location = new Point(49, 456);
            label9.Name = "label9";
            label9.Size = new Size(188, 20);
            label9.TabIndex = 5;
            label9.Text = "At least 3 lowercase letters";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label10.Location = new Point(48, 485);
            label10.Name = "label10";
            label10.Size = new Size(339, 20);
            label10.TabIndex = 6;
            label10.Text = "Should contain at least two of !, :, +, * characters";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label11.Location = new Point(49, 514);
            label11.Name = "label11";
            label11.Size = new Size(357, 20);
            label11.TabIndex = 7;
            label11.Text = "The same character can be present more than once";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(52, 547);
            label12.Name = "label12";
            label12.Size = new Size(29, 20);
            label12.TabIndex = 8;
            label12.Text = "     ";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Thistle;
            ClientSize = new Size(825, 585);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RegisterForm";
            Text = "RegisterForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnRegister;
        private TextBox txtRegRetypePassword;
        private TextBox txtRegPassword;
        private TextBox txtRegUsername;
        private TextBox txtRegSurname;
        private TextBox txtRegName;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}