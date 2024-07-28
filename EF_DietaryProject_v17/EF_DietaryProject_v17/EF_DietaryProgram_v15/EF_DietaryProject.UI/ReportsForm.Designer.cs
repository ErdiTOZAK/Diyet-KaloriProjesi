namespace EF_DietaryProject.UI
{
    partial class ReportsForm
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
            groupBox1 = new GroupBox();
            txtTotalCalories = new TextBox();
            label1 = new Label();
            dgwEndDay = new DataGridView();
            dtpEndDay = new DateTimePicker();
            groupBox2 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            dgwMostConsumedFoods = new DataGridView();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            groupBox3 = new GroupBox();
            label4 = new Label();
            label5 = new Label();
            dtpEndByMeal = new DateTimePicker();
            dtpStartByMeal = new DateTimePicker();
            dgwMostConsumedFoodsByMeal = new DataGridView();
            groupBox4 = new GroupBox();
            btnGetInformation = new Button();
            txtSumFullName = new TextBox();
            label10 = new Label();
            txtSumAge = new TextBox();
            txtSumBMI = new TextBox();
            txtSumHeight = new TextBox();
            txtSumWeight = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwEndDay).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwMostConsumedFoods).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwMostConsumedFoodsByMeal).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTotalCalories);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dgwEndDay);
            groupBox1.Controls.Add(dtpEndDay);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(17, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(457, 339);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "THE END DAY REPORT";
            // 
            // txtTotalCalories
            // 
            txtTotalCalories.Enabled = false;
            txtTotalCalories.Location = new Point(170, 76);
            txtTotalCalories.Name = "txtTotalCalories";
            txtTotalCalories.Size = new Size(268, 27);
            txtTotalCalories.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 75);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 2;
            label1.Text = "Day's Total Calories:";
            // 
            // dgwEndDay
            // 
            dgwEndDay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwEndDay.Location = new Point(12, 112);
            dgwEndDay.MultiSelect = false;
            dgwEndDay.Name = "dgwEndDay";
            dgwEndDay.ReadOnly = true;
            dgwEndDay.RowHeadersWidth = 51;
            dgwEndDay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwEndDay.Size = new Size(426, 202);
            dgwEndDay.TabIndex = 1;
            // 
            // dtpEndDay
            // 
            dtpEndDay.Location = new Point(12, 36);
            dtpEndDay.Name = "dtpEndDay";
            dtpEndDay.Size = new Size(428, 27);
            dtpEndDay.TabIndex = 0;
            dtpEndDay.ValueChanged += dtpEndDay_ValueChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(dgwMostConsumedFoods);
            groupBox2.Controls.Add(dtpEndDate);
            groupBox2.Controls.Add(dtpStartDate);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(505, 14);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(481, 337);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "MOST CONSUMED FOODS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 77);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 4;
            label3.Text = "Choose End Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 42);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 3;
            label2.Text = "Choose Start Date:";
            // 
            // dgwMostConsumedFoods
            // 
            dgwMostConsumedFoods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwMostConsumedFoods.Location = new Point(11, 110);
            dgwMostConsumedFoods.Name = "dgwMostConsumedFoods";
            dgwMostConsumedFoods.RowHeadersWidth = 51;
            dgwMostConsumedFoods.Size = new Size(464, 202);
            dgwMostConsumedFoods.TabIndex = 2;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(153, 74);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(322, 27);
            dtpEndDate.TabIndex = 1;
            dtpEndDate.ValueChanged += dtpEndDate_ValueChanged;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(153, 37);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(322, 27);
            dtpStartDate.TabIndex = 0;
            dtpStartDate.ValueChanged += dtpStartDate_ValueChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(dtpEndByMeal);
            groupBox3.Controls.Add(dtpStartByMeal);
            groupBox3.Controls.Add(dgwMostConsumedFoodsByMeal);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox3.Location = new Point(21, 388);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(453, 344);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "MOST CONSUMED FOODS BY MEAL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 73);
            label4.Name = "label4";
            label4.Size = new Size(131, 20);
            label4.TabIndex = 6;
            label4.Text = "Choose End Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 38);
            label5.Name = "label5";
            label5.Size = new Size(139, 20);
            label5.TabIndex = 5;
            label5.Text = "Choose Start Date:";
            // 
            // dtpEndByMeal
            // 
            dtpEndByMeal.Location = new Point(151, 73);
            dtpEndByMeal.Name = "dtpEndByMeal";
            dtpEndByMeal.Size = new Size(283, 27);
            dtpEndByMeal.TabIndex = 4;
            dtpEndByMeal.ValueChanged += dtpEndByMeal_ValueChanged;
            // 
            // dtpStartByMeal
            // 
            dtpStartByMeal.Location = new Point(151, 36);
            dtpStartByMeal.Name = "dtpStartByMeal";
            dtpStartByMeal.Size = new Size(283, 27);
            dtpStartByMeal.TabIndex = 3;
            dtpStartByMeal.ValueChanged += dtpStartByMeal_ValueChanged;
            // 
            // dgwMostConsumedFoodsByMeal
            // 
            dgwMostConsumedFoodsByMeal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwMostConsumedFoodsByMeal.Location = new Point(9, 112);
            dgwMostConsumedFoodsByMeal.Name = "dgwMostConsumedFoodsByMeal";
            dgwMostConsumedFoodsByMeal.RowHeadersWidth = 51;
            dgwMostConsumedFoodsByMeal.Size = new Size(425, 210);
            dgwMostConsumedFoodsByMeal.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnGetInformation);
            groupBox4.Controls.Add(txtSumFullName);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(txtSumAge);
            groupBox4.Controls.Add(txtSumBMI);
            groupBox4.Controls.Add(txtSumHeight);
            groupBox4.Controls.Add(txtSumWeight);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label6);
            groupBox4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox4.Location = new Point(505, 388);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(481, 344);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Summaries";
            // 
            // btnGetInformation
            // 
            btnGetInformation.Location = new Point(131, 264);
            btnGetInformation.Name = "btnGetInformation";
            btnGetInformation.Size = new Size(321, 58);
            btnGetInformation.TabIndex = 10;
            btnGetInformation.Text = "Get Information";
            btnGetInformation.UseVisualStyleBackColor = true;
            btnGetInformation.Click += btnGetInformation_Click;
            // 
            // txtSumFullName
            // 
            txtSumFullName.Enabled = false;
            txtSumFullName.Location = new Point(131, 38);
            txtSumFullName.Name = "txtSumFullName";
            txtSumFullName.Size = new Size(321, 34);
            txtSumFullName.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 44);
            label10.Name = "label10";
            label10.Size = new Size(115, 28);
            label10.TabIndex = 8;
            label10.Text = "Full Name :";
            // 
            // txtSumAge
            // 
            txtSumAge.Enabled = false;
            txtSumAge.Location = new Point(131, 163);
            txtSumAge.Name = "txtSumAge";
            txtSumAge.Size = new Size(321, 34);
            txtSumAge.TabIndex = 7;
            // 
            // txtSumBMI
            // 
            txtSumBMI.Enabled = false;
            txtSumBMI.Location = new Point(131, 210);
            txtSumBMI.Name = "txtSumBMI";
            txtSumBMI.Size = new Size(321, 34);
            txtSumBMI.TabIndex = 6;
            // 
            // txtSumHeight
            // 
            txtSumHeight.Enabled = false;
            txtSumHeight.Location = new Point(131, 119);
            txtSumHeight.Name = "txtSumHeight";
            txtSumHeight.Size = new Size(321, 34);
            txtSumHeight.TabIndex = 5;
            // 
            // txtSumWeight
            // 
            txtSumWeight.Enabled = false;
            txtSumWeight.Location = new Point(131, 78);
            txtSumWeight.Name = "txtSumWeight";
            txtSumWeight.Size = new Size(321, 34);
            txtSumWeight.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(63, 216);
            label9.Name = "label9";
            label9.Size = new Size(59, 28);
            label9.TabIndex = 3;
            label9.Text = "BMI :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(63, 169);
            label8.Name = "label8";
            label8.Size = new Size(59, 28);
            label8.TabIndex = 2;
            label8.Text = "Age :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 125);
            label7.Name = "label7";
            label7.Size = new Size(85, 28);
            label7.TabIndex = 1;
            label7.Text = "Height :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 84);
            label6.Name = "label6";
            label6.Size = new Size(88, 28);
            label6.TabIndex = 0;
            label6.Text = "Weight :";
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1068, 744);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ReportsForm";
            Text = "ReportsForm";
            Load += ReportsForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwEndDay).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwMostConsumedFoods).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwMostConsumedFoodsByMeal).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtTotalCalories;
        private Label label1;
        private DataGridView dgwEndDay;
        private DateTimePicker dtpEndDay;
        private GroupBox groupBox2;
        private DataGridView dgwMostConsumedFoods;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private GroupBox groupBox3;
        private DataGridView dgwMostConsumedFoodsByMeal;
        private DateTimePicker dtpEndByMeal;
        private DateTimePicker dtpStartByMeal;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private GroupBox groupBox4;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtSumAge;
        private TextBox txtSumBMI;
        private TextBox txtSumHeight;
        private TextBox txtSumWeight;
        private TextBox txtSumFullName;
        private Label label10;
        private Button btnGetInformation;
    }
}