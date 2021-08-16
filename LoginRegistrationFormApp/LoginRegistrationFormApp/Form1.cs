using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegistrationFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Error check variable
            int error = 0;

            //Getting input from controls
            String fname = txtFname.Text;
            String lname = txtLname.Text;
            String address = txtAdd.Text;
            String email = txtEmail.Text;
            String phone = txtPhone.Text;
            String username = txtUser.Text;
            String password = txtPass.Text;

            
            String gender = cmbGender.Text;

            //Validations

            //No field should be blank.
            if (fname == "" || lname == "" || gender == "Select" || address == "" || email == "" || phone == "" || username == "" || password == "")
            {
                error += 1;
            } 

            //Password length should be atleast 7 characters long.
            if(password.Length <= 6)
            {
                error += 1;
                MessageBox.Show("Password should be atleast 7 characters", "Error");
                return;
            }

            //Final error check and display result accordingly.
            if (error >= 1)
            {
                MessageBox.Show("Please fill all the details", "Error");
            } else
            {
                MessageBox.Show("Welcome! Your account number is : 101", "Successful");
            }


        }


    }
}
