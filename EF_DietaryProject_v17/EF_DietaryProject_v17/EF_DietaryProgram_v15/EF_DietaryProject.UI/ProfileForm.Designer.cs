namespace EF_DietaryProject.UI
{
    partial class ProfileForm
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
            btnSaveProfile = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            nudWeight = new NumericUpDown();
            nudHeight = new NumericUpDown();
            cmbGender = new ComboBox();
            dtpBirthDate = new DateTimePicker();
            cmbTarget = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nudWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHeight).BeginInit();
            SuspendLayout();
            // 
            // btnSaveProfile
            // 
            btnSaveProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSaveProfile.Location = new Point(54, 331);
            btnSaveProfile.Name = "btnSaveProfile";
            btnSaveProfile.Size = new Size(299, 73);
            btnSaveProfile.TabIndex = 1;
            btnSaveProfile.Text = "SAVE PROFILE";
            btnSaveProfile.UseVisualStyleBackColor = true;
            btnSaveProfile.Click += btnSaveProfile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(54, 30);
            label1.Name = "label1";
            label1.Size = new Size(82, 28);
            label1.TabIndex = 3;
            label1.Text = "Weight:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(54, 86);
            label2.Name = "label2";
            label2.Size = new Size(79, 28);
            label2.TabIndex = 4;
            label2.Text = "Height:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(48, 141);
            label3.Name = "label3";
            label3.Size = new Size(85, 28);
            label3.TabIndex = 5;
            label3.Text = "Gender:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(24, 198);
            label4.Name = "label4";
            label4.Size = new Size(109, 28);
            label4.TabIndex = 6;
            label4.Text = "Birth Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(60, 252);
            label5.Name = "label5";
            label5.Size = new Size(73, 28);
            label5.TabIndex = 7;
            label5.Text = "Target:";
            // 
            // nudWeight
            // 
            nudWeight.DecimalPlaces = 2;
            nudWeight.Location = new Point(151, 34);
            nudWeight.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudWeight.Name = "nudWeight";
            nudWeight.Size = new Size(202, 27);
            nudWeight.TabIndex = 8;
            // 
            // nudHeight
            // 
            nudHeight.DecimalPlaces = 1;
            nudHeight.Location = new Point(151, 91);
            nudHeight.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nudHeight.Name = "nudHeight";
            nudHeight.Size = new Size(202, 27);
            nudHeight.TabIndex = 9;
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(151, 141);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(202, 28);
            cmbGender.TabIndex = 10;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(150, 200);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(203, 27);
            dtpBirthDate.TabIndex = 11;
            // 
            // cmbTarget
            // 
            cmbTarget.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTarget.FormattingEnabled = true;
            cmbTarget.Location = new Point(151, 257);
            cmbTarget.Name = "cmbTarget";
            cmbTarget.Size = new Size(202, 28);
            cmbTarget.TabIndex = 12;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightGreen;
            ClientSize = new Size(401, 448);
            Controls.Add(cmbTarget);
            Controls.Add(dtpBirthDate);
            Controls.Add(cmbGender);
            Controls.Add(nudHeight);
            Controls.Add(nudWeight);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSaveProfile);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ProfileForm";
            Text = "ProfileForm";
            Load += ProfileForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSaveProfile;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown nudWeight;
        private NumericUpDown nudHeight;
        private ComboBox cmbGender;
        private DateTimePicker dtpBirthDate;
        private ComboBox cmbTarget;
    }
}