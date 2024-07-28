namespace EF_DietaryProject.UI
{
    partial class MealProcessesForm
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
            btnDone = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            dgwAddFood = new DataGridView();
            nudHowMuchGr = new NumericUpDown();
            lblHowMuchGr = new Label();
            cmbFoodCategory = new ComboBox();
            lblFoodCategory = new Label();
            label3 = new Label();
            dtpMealDay = new DateTimePicker();
            label2 = new Label();
            cmbMeals = new ComboBox();
            label1 = new Label();
            panel1 = new Panel();
            txtTotalCalories = new TextBox();
            lblTotalCalories = new Label();
            txtCaloryPer100g = new TextBox();
            lblCaloryPerGram = new Label();
            txtFoodName = new TextBox();
            lblFoodName = new Label();
            label4 = new Label();
            dgwDishes = new DataGridView();
            btnUpdateDish = new Button();
            btnDeleteDish = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwAddFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudHowMuchGr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwDishes).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDone);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(dgwAddFood);
            groupBox1.Controls.Add(nudHowMuchGr);
            groupBox1.Controls.Add(lblHowMuchGr);
            groupBox1.Controls.Add(cmbFoodCategory);
            groupBox1.Controls.Add(lblFoodCategory);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dtpMealDay);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbMeals);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(464, 445);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "MANAGE YOUR MEAL";
            // 
            // btnDone
            // 
            btnDone.Location = new Point(360, 228);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(98, 29);
            btnDone.TabIndex = 13;
            btnDone.Text = "DONE";
            btnDone.UseVisualStyleBackColor = true;
            btnDone.Click += btnDone_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(228, 228);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 29);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(118, 228);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(6, 228);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgwAddFood
            // 
            dgwAddFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwAddFood.Location = new Point(6, 263);
            dgwAddFood.MultiSelect = false;
            dgwAddFood.Name = "dgwAddFood";
            dgwAddFood.ReadOnly = true;
            dgwAddFood.RowHeadersWidth = 51;
            dgwAddFood.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwAddFood.Size = new Size(452, 176);
            dgwAddFood.TabIndex = 9;
            // 
            // nudHowMuchGr
            // 
            nudHowMuchGr.Location = new Point(129, 190);
            nudHowMuchGr.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            nudHowMuchGr.Name = "nudHowMuchGr";
            nudHowMuchGr.Size = new Size(281, 27);
            nudHowMuchGr.TabIndex = 8;
            nudHowMuchGr.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // lblHowMuchGr
            // 
            lblHowMuchGr.AutoSize = true;
            lblHowMuchGr.Location = new Point(6, 189);
            lblHowMuchGr.Name = "lblHowMuchGr";
            lblHowMuchGr.Size = new Size(123, 20);
            lblHowMuchGr.TabIndex = 7;
            lblHowMuchGr.Text = "How much (gr) :";
            // 
            // cmbFoodCategory
            // 
            cmbFoodCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFoodCategory.FormattingEnabled = true;
            cmbFoodCategory.Location = new Point(128, 146);
            cmbFoodCategory.Name = "cmbFoodCategory";
            cmbFoodCategory.Size = new Size(282, 28);
            cmbFoodCategory.TabIndex = 6;
            cmbFoodCategory.SelectedIndexChanged += cmbFoodCategory_SelectedIndexChanged;
            // 
            // lblFoodCategory
            // 
            lblFoodCategory.AutoSize = true;
            lblFoodCategory.Location = new Point(10, 149);
            lblFoodCategory.Name = "lblFoodCategory";
            lblFoodCategory.Size = new Size(116, 20);
            lblFoodCategory.TabIndex = 5;
            lblFoodCategory.Text = "Food Category:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 111);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 3;
            label3.Text = "Day:";
            // 
            // dtpMealDay
            // 
            dtpMealDay.Location = new Point(128, 106);
            dtpMealDay.Name = "dtpMealDay";
            dtpMealDay.Size = new Size(282, 27);
            dtpMealDay.TabIndex = 4;
            dtpMealDay.ValueChanged += dtpMealDay_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 69);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 2;
            label2.Text = "Meals:";
            // 
            // cmbMeals
            // 
            cmbMeals.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMeals.FormattingEnabled = true;
            cmbMeals.Location = new Point(128, 65);
            cmbMeals.Name = "cmbMeals";
            cmbMeals.Size = new Size(282, 28);
            cmbMeals.TabIndex = 1;
            cmbMeals.SelectedIndexChanged += cmbMeals_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 29);
            label1.Name = "label1";
            label1.Size = new Size(350, 20);
            label1.TabIndex = 0;
            label1.Text = "You can add your dish by selecting the meal time";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Location = new Point(486, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(390, 578);
            panel1.TabIndex = 1;
            // 
            // txtTotalCalories
            // 
            txtTotalCalories.Enabled = false;
            txtTotalCalories.Location = new Point(631, 90);
            txtTotalCalories.Name = "txtTotalCalories";
            txtTotalCalories.Size = new Size(162, 27);
            txtTotalCalories.TabIndex = 5;
            txtTotalCalories.Visible = false;
            // 
            // lblTotalCalories
            // 
            lblTotalCalories.AutoSize = true;
            lblTotalCalories.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTotalCalories.Location = new Point(514, 86);
            lblTotalCalories.Name = "lblTotalCalories";
            lblTotalCalories.Size = new Size(111, 20);
            lblTotalCalories.TabIndex = 4;
            lblTotalCalories.Text = "Total Calories :";
            lblTotalCalories.Visible = false;
            // 
            // txtCaloryPer100g
            // 
            txtCaloryPer100g.Enabled = false;
            txtCaloryPer100g.Location = new Point(631, 57);
            txtCaloryPer100g.Name = "txtCaloryPer100g";
            txtCaloryPer100g.Size = new Size(162, 27);
            txtCaloryPer100g.TabIndex = 3;
           
            // 
            // lblCaloryPerGram
            // 
            lblCaloryPerGram.AutoSize = true;
            lblCaloryPerGram.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCaloryPerGram.Location = new Point(496, 58);
            lblCaloryPerGram.Name = "lblCaloryPerGram";
            lblCaloryPerGram.Size = new Size(129, 20);
            lblCaloryPerGram.TabIndex = 2;
            lblCaloryPerGram.Text = "Calory per 100g :";
            // 
            // txtFoodName
            // 
            txtFoodName.Enabled = false;
            txtFoodName.Location = new Point(631, 24);
            txtFoodName.Name = "txtFoodName";
            txtFoodName.Size = new Size(162, 27);
            txtFoodName.TabIndex = 1;
            // 
            // lblFoodName
            // 
            lblFoodName.AutoSize = true;
            lblFoodName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblFoodName.Location = new Point(527, 27);
            lblFoodName.Name = "lblFoodName";
            lblFoodName.Size = new Size(98, 20);
            lblFoodName.TabIndex = 0;
            lblFoodName.Text = "Food Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(18, 477);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 6;
            label4.Text = "DISHES LIST";
            // 
            // dgwDishes
            // 
            dgwDishes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwDishes.Location = new Point(21, 513);
            dgwDishes.MultiSelect = false;
            dgwDishes.Name = "dgwDishes";
            dgwDishes.ReadOnly = true;
            dgwDishes.RowHeadersWidth = 51;
            dgwDishes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwDishes.Size = new Size(449, 188);
            dgwDishes.TabIndex = 7;
            dgwDishes.RowHeaderMouseClick += dgwDishes_RowHeaderMouseClick;
            // 
            // btnUpdateDish
            // 
            btnUpdateDish.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnUpdateDish.Location = new Point(130, 473);
            btnUpdateDish.Name = "btnUpdateDish";
            btnUpdateDish.Size = new Size(149, 29);
            btnUpdateDish.TabIndex = 14;
            btnUpdateDish.Text = "UPDATE DISH";
            btnUpdateDish.UseVisualStyleBackColor = true;
            btnUpdateDish.Click += btnUpdateDish_Click;
            // 
            // btnDeleteDish
            // 
            btnDeleteDish.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDeleteDish.Location = new Point(295, 473);
            btnDeleteDish.Name = "btnDeleteDish";
            btnDeleteDish.Size = new Size(175, 29);
            btnDeleteDish.TabIndex = 15;
            btnDeleteDish.Text = "DELETE DISH";
            btnDeleteDish.UseVisualStyleBackColor = true;
            btnDeleteDish.Click += btnDeleteDish_Click;
            // 
            // MealProcessesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(888, 713);
            Controls.Add(btnDeleteDish);
            Controls.Add(btnUpdateDish);
            Controls.Add(dgwDishes);
            Controls.Add(label4);
            Controls.Add(txtTotalCalories);
            Controls.Add(panel1);
            Controls.Add(txtCaloryPer100g);
            Controls.Add(lblTotalCalories);
            Controls.Add(txtFoodName);
            Controls.Add(groupBox1);
            Controls.Add(lblFoodName);
            Controls.Add(lblCaloryPerGram);
            Name = "MealProcessesForm";
            Text = "MealProcessesForm";
            Load += MealProcessesForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwAddFood).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudHowMuchGr).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwDishes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private DateTimePicker dtpMealDay;
        private Label label2;
        private ComboBox cmbMeals;
        private Label label1;
        private DataGridView dgwAddFood;
        private NumericUpDown nudHowMuchGr;
        private Label lblHowMuchGr;
        private ComboBox cmbFoodCategory;
        private Label lblFoodCategory;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnDone;
        private Panel panel1;
        private Label lblFoodName;
        private TextBox txtTotalCalories;
        private Label lblTotalCalories;
        private TextBox txtCaloryPer100g;
        private Label lblCaloryPerGram;
        private TextBox txtFoodName;
        private Label label4;
        private DataGridView dgwDishes;
        private Button btnUpdateDish;
        private Button btnDeleteDish;
    }
}