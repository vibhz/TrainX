namespace FitnessTracker
{
    partial class ViewMealHistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMealHistoryForm));
            this.dgvCheatMeals = new System.Windows.Forms.DataGridView();
            this.lastweekchecked = new System.Windows.Forms.RadioButton();
            this.lastmonthchecked = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheatMeals)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCheatMeals
            // 
            this.dgvCheatMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheatMeals.Location = new System.Drawing.Point(3, 65);
            this.dgvCheatMeals.Name = "dgvCheatMeals";
            this.dgvCheatMeals.RowHeadersWidth = 51;
            this.dgvCheatMeals.Size = new System.Drawing.Size(743, 296);
            this.dgvCheatMeals.TabIndex = 0;
            this.dgvCheatMeals.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheatMeals_CellContentClick);
            // 
            // lastweekchecked
            // 
            this.lastweekchecked.AutoSize = true;
            this.lastweekchecked.Location = new System.Drawing.Point(338, 20);
            this.lastweekchecked.Name = "lastweekchecked";
            this.lastweekchecked.Size = new System.Drawing.Size(108, 17);
            this.lastweekchecked.TabIndex = 1;
            this.lastweekchecked.TabStop = true;
            this.lastweekchecked.Text = "Last Week Meals";
            this.lastweekchecked.UseVisualStyleBackColor = true;
            this.lastweekchecked.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lastmonthchecked
            // 
            this.lastmonthchecked.AutoSize = true;
            this.lastmonthchecked.Location = new System.Drawing.Point(501, 20);
            this.lastmonthchecked.Name = "lastmonthchecked";
            this.lastmonthchecked.Size = new System.Drawing.Size(109, 17);
            this.lastmonthchecked.TabIndex = 2;
            this.lastmonthchecked.TabStop = true;
            this.lastmonthchecked.Text = "Last Month Meals";
            this.lastmonthchecked.UseVisualStyleBackColor = true;
            this.lastmonthchecked.CheckedChanged += new System.EventHandler(this.lastmonthchecked_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(197, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filter Your Cheat Meals";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(668, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewMealHistoryForm
            // 
            this.ClientSize = new System.Drawing.Size(752, 369);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lastmonthchecked);
            this.Controls.Add(this.lastweekchecked);
            this.Controls.Add(this.dgvCheatMeals);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewMealHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meal History";
            this.Load += new System.EventHandler(this.ViewMealHistoryForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheatMeals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton lastweekchecked;
        private System.Windows.Forms.RadioButton lastmonthchecked;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}