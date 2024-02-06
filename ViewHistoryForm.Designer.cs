namespace FitnessTracker
{
    partial class ViewHistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewHistoryForm));
            this.dgvWorkouts = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lastmonthchecked = new System.Windows.Forms.RadioButton();
            this.lastweekchecked = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textCaleries = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkouts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWorkouts
            // 
            this.dgvWorkouts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkouts.Location = new System.Drawing.Point(0, 90);
            this.dgvWorkouts.Name = "dgvWorkouts";
            this.dgvWorkouts.RowHeadersWidth = 51;
            this.dgvWorkouts.Size = new System.Drawing.Size(923, 316);
            this.dgvWorkouts.TabIndex = 0;
            this.dgvWorkouts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorkouts_CellContentClick);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(524, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Filter Your Workouts";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.comboBox1.Location = new System.Drawing.Point(175, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lastmonthchecked
            // 
            this.lastmonthchecked.AutoSize = true;
            this.lastmonthchecked.Location = new System.Drawing.Point(416, 40);
            this.lastmonthchecked.Name = "lastmonthchecked";
            this.lastmonthchecked.Size = new System.Drawing.Size(74, 20);
            this.lastmonthchecked.TabIndex = 7;
            this.lastmonthchecked.TabStop = true;
            this.lastmonthchecked.Text = "Monthly";
            this.lastmonthchecked.UseVisualStyleBackColor = true;
            this.lastmonthchecked.CheckedChanged += new System.EventHandler(this.lastmonthchecked_CheckedChanged);
            // 
            // lastweekchecked
            // 
            this.lastweekchecked.AutoSize = true;
            this.lastweekchecked.Location = new System.Drawing.Point(320, 39);
            this.lastweekchecked.Name = "lastweekchecked";
            this.lastweekchecked.Size = new System.Drawing.Size(77, 20);
            this.lastweekchecked.TabIndex = 6;
            this.lastweekchecked.TabStop = true;
            this.lastweekchecked.Text = "Weekly ";
            this.lastweekchecked.UseVisualStyleBackColor = true;
            this.lastweekchecked.CheckedChanged += new System.EventHandler(this.lastweekchecked_CheckedChanged);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(728, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Delete History";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Total Caleries Burn:";
            // 
            // textCaleries
            // 
            this.textCaleries.Location = new System.Drawing.Point(175, 436);
            this.textCaleries.Name = "textCaleries";
            this.textCaleries.ReadOnly = true;
            this.textCaleries.Size = new System.Drawing.Size(246, 22);
            this.textCaleries.TabIndex = 13;
            // 
            // ViewHistoryForm
            // 
            this.ClientSize = new System.Drawing.Size(935, 532);
            this.Controls.Add(this.textCaleries);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lastmonthchecked);
            this.Controls.Add(this.lastweekchecked);
            this.Controls.Add(this.dgvWorkouts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Workouts History";
            this.Load += new System.EventHandler(this.ViewHistoryForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkouts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton lastmonthchecked;
        private System.Windows.Forms.RadioButton lastweekchecked;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCaleries;
    }
}