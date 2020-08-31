using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateCalculatorWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateDifference(object sender, EventArgs e)
        {
            DateTime firstDateTime = DatePicker1.Value;
            DateTime secondDateTime = DatePicker2.Value;
            String selection = UnitSelector.Text;
            //if combobox has not been used we break
            if(selection == null)
            {
                return;
            } 
            else if(selection == "Day")
            {
                Debug.Write("Hello Chance");
            }
            else if(selection == "Month")
            {

            }
                

        }
    }
}
