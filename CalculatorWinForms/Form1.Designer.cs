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
            this.SuspendLayout();
            // 
            // DateCalculatorLbl
            // 
            this.DateCalculatorLbl.AutoSize = true;
            this.DateCalculatorLbl.Location = new System.Drawing.Point(13, 13);
            this.DateCalculatorLbl.Name = "DateCalculatorLbl";
            this.DateCalculatorLbl.Size = new System.Drawing.Size(88, 15);
            this.DateCalculatorLbl.TabIndex = 0;
            this.DateCalculatorLbl.Text = "Date Calculator";
            this.DateCalculatorLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // FirstDateLabel
            // 
            this.FirstDateLabel.AutoSize = true;
            this.FirstDateLabel.Location = new System.Drawing.Point(13, 51);
            this.FirstDateLabel.Name = "FirstDateLabel";
            this.FirstDateLabel.Size = new System.Drawing.Size(56, 15);
            this.FirstDateLabel.TabIndex = 1;
            this.FirstDateLabel.Text = "First Date";
            this.FirstDateLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // firstDatePicker
            // 
            this.firstDatePicker.Location = new System.Drawing.Point(184, 51);
            this.firstDatePicker.Name = "firstDatePicker";
            this.firstDatePicker.Size = new System.Drawing.Size(200, 23);
            this.firstDatePicker.TabIndex = 4;
            this.firstDatePicker.ValueChanged += new System.EventHandler(this.firstDatePicker_ValueChanged);
            // 
            // secondDatePicker
            // 
            this.secondDatePicker.Location = new System.Drawing.Point(184, 111);
            this.secondDatePicker.Name = "secondDatePicker";
            this.secondDatePicker.Size = new System.Drawing.Size(200, 23);
            this.secondDatePicker.TabIndex = 4;
            this.secondDatePicker.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Second Date";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 190);
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
            this.difference.Location = new System.Drawing.Point(184, 239);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(0, 15);
            this.difference.TabIndex = 6;
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Location = new System.Drawing.Point(281, 239);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(0, 15);
            this.dayLabel.TabIndex = 7;
            // 
            // Date
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondDatePicker);
            this.Controls.Add(this.firstDatePicker);
            this.Controls.Add(this.FirstDateLabel);
            this.Controls.Add(this.DateCalculatorLbl);
            this.Name = "Date";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

