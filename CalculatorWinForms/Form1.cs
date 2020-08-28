using CalculatorBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWinForms
{
    public partial class Date : Form
    {
        public CalcLogic Calc { get; set; }
        public Date()
        {
            InitializeComponent();
            Calc = new CalcLogic();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void firstDatePicker_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime firstDateTime = firstDatePicker.Value;
            DateTime secondDateTime = secondDatePicker.Value;
            var days = Calc.DifferenceOfDates(firstDateTime, secondDateTime);
            difference.Text = days.ToString();
            if(days < 2.0)
            {
                dayLabel.Text = "Day";
            }
            else
            {
                dayLabel.Text = "Days";
            }
            dataGridView1.Rows.Add(firstDateTime, secondDateTime, days);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
