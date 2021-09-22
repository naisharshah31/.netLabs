using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace primeMoviesLabTest
{
    public partial class Form1 : Form
    {

        //SQL Connection
        SqlConnection sc = new SqlConnection();
        SqlCommand com = new SqlCommand();
        
        
        public Form1()
        {
            InitializeComponent();
            sc.ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\source\repos\primeMoviesLabTest\primeMoviesLabTest\primeMovies.mdf;Integrated Security=True");
            sc.Open();
            com.Connection = sc;
            dtpDOB.MaxDate = DateTime.Now;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {

            String fname = txtFirstname.Text;
            String lname = txtLastname.Text;
            String gender = cmbGender.Text;
            String username = txtUsername.Text;
            String password = txtPassword.Text;
            
            string dt = dtpDOB.Value.ToShortDateString();


            int userExist = -1;
            int error = 0;

            String subscribed = "";

            if (chkSubscribe.Checked == true)
            {
                subscribed = "true";
            } else
            {
                subscribed = "false";
            }

            //Validation
            //No field should be blank.
            if (fname == "" || lname == "" || gender == "Select" || dt == "" || username == "" || password == "")
            {
                error += 1;
            }

            //Username exist check (READ)
            String checkUsernameQuery = "SELECT username FROM users1947258 WHERE username = '" + username + "';";
            com.CommandText = (checkUsernameQuery);
            SqlDataReader reader = com.ExecuteReader();

            if (reader.HasRows == true)
            {
                MessageBox.Show("Username already taken! Try with other username", "Error");
                sc.Close();
                return;
            }



            if ( error == 0 )
            {
                //INSERT QUERY
                String insertQuery = "INSERT INTO users1947258 VALUES('" + username + "','" + password + "','" + fname + "','" + lname + "','" + gender + "','" + dt + "','" + subscribed + "');";
                com.CommandText = (insertQuery);
                int result = com.ExecuteNonQuery();

                //Output received from database after query execution
                if (result > 0)
                {
                    MessageBox.Show("Welcome! Watch unlimited free movies", "Successful");
                }
                else
                {
                    MessageBox.Show("Some Error ", "Failure");
                }

                sc.Close();

            } else
            {
                MessageBox.Show("Please fill all the details", "Error");
            }
            


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            

        }
    }
}
