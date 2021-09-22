using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dateTimePickerAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            //Validation
            dtpDOB.MaxDate = DateTime.Now;

        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            //Binding Control to variable
            //Method to get value from string
            string selectedDate = dtpDOB.Value.ToShortDateString();

            MessageBox.Show("Your date of birth is :" + selectedDate, "Registration Successfull");

        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            //Get how many years a person is old (AS WE NEED ONLY DATE OF BIRTH IN ORDER TO GET AGE.)
            int Age = DateTime.Today.Year - dtpDOB.Value.Year; // CurrentYear - BirthDate

            MessageBox.Show("Your age is :" + Age.ToString() , "Registration Successfull");
        }
    }
}
