namespace CalculatorWinForms
{
    partial class Date
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
            this.DateCalculatorLbl = new System.Windows.Forms.Label();
            this.FirstDateLabel = new System.Windows.Forms.Label();
            this.firstDatePicker = new System.Windows.Forms.DateTimePicker();
            this.secondDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.difference = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DateCalculatorLbl
            // 
            this.DateCalculatorLbl.AutoSize = true;
            this.DateCalculatorLbl.Location = new System.Drawing.Point(12, 15);
            this.DateCalculatorLbl.Name = "DateCalculatorLbl";
            this.DateCalculatorLbl.Size = new System.Drawing.Size(88, 15);
            this.DateCalculatorLbl.TabIndex = 0;
            this.DateCalculatorLbl.Text = "Date Calculator";
            this.DateCalculatorLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // FirstDateLabel
            // 
            this.FirstDateLabel.AutoSize = true;
            this.FirstDateLabel.Location = new System.Drawing.Point(12, 53);
            this.FirstDateLabel.Name = "FirstDateLabel";
            this.FirstDateLabel.Size = new System.Drawing.Size(56, 15);
            this.FirstDateLabel.TabIndex = 1;
            this.FirstDateLabel.Text = "First Date";
            this.FirstDateLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // firstDatePicker
            // 
            this.firstDatePicker.Location = new System.Drawing.Point(183, 53);
            this.firstDatePicker.Name = "firstDatePicker";
            this.firstDatePicker.Size = new System.Drawing.Size(200, 23);
            this.firstDatePicker.TabIndex = 4;
            this.firstDatePicker.ValueChanged += new System.EventHandler(this.firstDatePicker_ValueChanged);
            // 
            // secondDatePicker
            // 
            this.secondDatePicker.Location = new System.Drawing.Point(183, 113);
            this.secondDatePicker.Name = "secondDatePicker";
            this.secondDatePicker.Size = new System.Drawing.Size(200, 23);
            this.secondDatePicker.TabIndex = 4;
            this.secondDatePicker.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Second Date";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calculate Difference In Days";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // difference
            // 
            this.difference.AutoSize = true;
            this.difference.Location = new System.Drawing.Point(183, 238);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(0, 15);
            this.difference.TabIndex = 6;
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Location = new System.Drawing.Point(280, 238);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(0, 15);
            this.dayLabel.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(830, 581);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DateCalculatorLbl);
            this.tabPage1.Controls.Add(this.dayLabel);
            this.tabPage1.Controls.Add(this.FirstDateLabel);
            this.tabPage1.Controls.Add(this.difference);
            this.tabPage1.Controls.Add(this.firstDatePicker);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.secondDatePicker);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(822, 553);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(822, 553);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(386, 304);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Text = "dataGridView1";
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 590);
            this.Controls.Add(this.tabControl1);
            this.Name = "Date";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DateCalculatorLbl;
        private System.Windows.Forms.Label FirstDateLabel;
        private System.Windows.Forms.DateTimePicker firstDatePicker;
        private System.Windows.Forms.DateTimePicker secondDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label difference;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

