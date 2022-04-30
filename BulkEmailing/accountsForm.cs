using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulkEmailing
{
    public partial class accountsForm : Form
    {
        public accountsForm()
        {
            InitializeComponent();
            string query = "spReciever_GetAll";
            wireupListbox(query);
        }

        //add reciever button click method
        private void newRecieverButton_Click(object sender, EventArgs e)
        {
            if (validateReciever())
            {
                try
                {
                    sendRecieverData();
                }
                
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Something went wrong. Data could not be saved.");
                }

                finally
                {
                    resetReciever(); 
                    string query = "spReciever_GetAll";
                    wireupListbox(query);
                }
            }
        }


        //method to validate reciever details
        private bool validateReciever()
        {
            if (firstNameTextbox.Text == "")
            {
                MessageBox.Show("Please enter First name");
                return false;
            }

            else if (lastNameTextbox.Text == "")
            {
                MessageBox.Show("Please enter Last name");
                return false;
            }

            else if (recieverEmailTextbox.Text == "")
            {
                MessageBox.Show("Please enter Email");
                return false;
            }

            else return true;
        }

        //method to send reciever data to database
        private void sendRecieverData()
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spReciever_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@firstName", firstNameTextbox.Text));
            cmd.Parameters.Add(new SqlParameter("@lastName", lastNameTextbox.Text));
            cmd.Parameters.Add(new SqlParameter("@email", recieverEmailTextbox.Text));

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }

            finally
            {
                con.Close();
            }
        }


        //method to reset reciever details
        private void resetReciever()
        {
            firstNameTextbox.Text = "";
            lastNameTextbox.Text = "";
            recieverEmailTextbox.Text = "";
        }


        // add sender account button click method
        private void newSenderButton_Click(object sender, EventArgs e)
        {
            if(validateSender())
            {
                try
                {
                    sendSenderData();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Something went wrong. Data could not be saved.");
                }

                finally
                {
                    resetSender(); 
                    string query = "spSender_GetAll";
                    wireupListbox(query);
                }
            }
        }


        //method to validate sender details
        private bool validateSender()
        {
            if(senderEmailTextbox.Text  == "")
            {
                MessageBox.Show("Please enter Email");
                return false;
            }

            else if(senderPasswordTextbox.Text == "")
            {
                MessageBox.Show("Please enter Password");
                return false;
            }

            else return true;
        }


        //method to reset sender details
        private void resetSender()
        {
            senderEmailTextbox.Text = "";
            senderPasswordTextbox.Text = "";
        }

        // method to send sender account data to database
        private void sendSenderData()
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spSender_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@email", senderEmailTextbox.Text));
            cmd.Parameters.Add(new SqlParameter("@password", senderPasswordTextbox.Text));

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }

            finally
            {
                con.Close();
            }
        }

        //listbox controls
        private void viewRecieverButton_Click(object sender, EventArgs e)
        {
            string query = "spReciever_GetAll";
            wireupListbox(query);
            nameLabel.Text = "Existing Recievers";
        }

        private void viewSenderButton_Click(object sender, EventArgs e)
        {
            string query = "spSender_GetAll";
            wireupListbox(query);
            nameLabel.Text = "Existing Senders";
        }


        //method to wire upp list box

        private void wireupListbox(string query)
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();

            try
            {
                con.Open();
                da.SelectCommand = cmd;
                da.Fill(ds);
                da.Dispose();
                cmd.Dispose();

                viewListbox.DataSource = ds.Tables[0];
                viewListbox.DisplayMember = "email";
                viewListbox.ValueMember = "id";
            }

            finally
            {
                con.Close();
            }
        }

        //remove button onclick method
        private void removeAccountButton_Click(object sender, EventArgs e)
        {
            if (nameLabel.Text == "Existing Recievers")
            {
                string query = "spReciever_GetAll";
                string removeQuery = "spReciever_DeleteById";
                removeAccount(query, removeQuery);
            }

            else if (nameLabel.Text == "Existing Senders")
            {
                string query = "spReciever_GetAll";
                string removeQuery = "spSender_DeleteById";
                removeAccount(query, removeQuery);
            }
        }

        //method to remove account from database
        private void removeAccount(string query, string removeQuery)
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand(removeQuery, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", Convert.ToInt32(viewListbox.SelectedValue)));

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Something went wrong.");
            }

            finally
            {
                con.Close();
                wireupListbox(query);
            }
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog import = new OpenFileDialog();
            import.Multiselect = false;
            import.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";

            if(import.ShowDialog() == DialogResult.OK)
            {
                string fileName = import.FileName;
                string fileExt = Path.GetExtension(fileName);
                if(fileExt == ".xls" || fileExt == ".xlsx")
                {
                    MessageBox.Show("Are you sure you want to import this file?\n" + fileName, "Confirm Open File", MessageBoxButtons.YesNo);
                }

                else
                {
                    MessageBox.Show("Invalid File Type");
                }
            }
        }
    }
}
