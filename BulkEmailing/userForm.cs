using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulkEmailing
{
    public partial class userForm : Form
    {
        public userForm()
        {
            InitializeComponent();
        }

        private void userForm_Load(object sender, EventArgs e)
        {
            wireupListbox();
        }

        // create new user button click function
        private void newRecieverButton_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                try
                {
                    sendData();
                }

                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Something went wrong. Data could not be saved.");
                }

                finally
                {
                    resetForm();
                }
            }
        }

        //method to validate user details
        private bool validateForm()
        {
            if (firstNameTextbox.Text == "")
            {
                MessageBox.Show("Please enter First Name");
                return false;
            }

            else if (lastNameTextbox.Text == "")
            {
                MessageBox.Show("Please enter Last Name");
                return false;
            }

            else if (emailTextbox.Text == "")
            {
                MessageBox.Show("Please enter Email");
                return false;
            }

            else if (passwordTextbox.Text == "")
            {
                MessageBox.Show("Please enter Password");
                return false;
            }

            else if (confirmTextbox.Text == "" || confirmTextbox.Text != passwordTextbox.Text)
            {
                MessageBox.Show("Passwords do not match");
                return false;
            }

            else if (contactTextbox.Text == "")
            {
                MessageBox.Show("Please enter Contact");
                return false;
            }

            else return true;
        }


        //method to reset the form
        private void resetForm()
        {
            firstNameTextbox.Text = "";
            lastNameTextbox.Text = "";
            emailTextbox.Text = "";
            usernameTextbox.Text = "";
            passwordTextbox.Text = "";
            confirmTextbox.Text = "";
            contactTextbox.Text = "";
            wireupListbox();
        }


        //method to send data to database
        private void sendData()
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spUser_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@firstName", firstNameTextbox.Text));
            cmd.Parameters.Add(new SqlParameter("@lastName", lastNameTextbox.Text));
            cmd.Parameters.Add(new SqlParameter("@email", emailTextbox.Text));
            cmd.Parameters.Add(new SqlParameter("@username", usernameTextbox.Text));
            cmd.Parameters.Add(new SqlParameter("@password", passwordTextbox.Text));
            cmd.Parameters.Add(new SqlParameter("@contact", contactTextbox.Text));


            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }

            finally
            {
                con.Close();
                resetForm();
            }


        }


        //method to put data in the listbox 
        private void wireupListbox()
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spUser_GetDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                da.Dispose();
                cmd.Dispose();
                usersListbox.DataSource = ds.Tables[0];
                usersListbox.DisplayMember = "username";
                usersListbox.ValueMember = "id";
               
            }

            finally
            {
                con.Close();
            }

        }

        private void removeUserButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spUser_DeleteByID", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", Convert.ToInt32(usersListbox.SelectedValue)));
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Something went wrong. Data could not be deleted.");
            }
            finally
            {
                con.Close();
                wireupListbox();
            }
        }

    }
}
