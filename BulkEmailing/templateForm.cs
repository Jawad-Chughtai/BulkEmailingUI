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
    public partial class templateForm : Form
    {
        public templateForm()
        {
            InitializeComponent();
        }

        //form load event
        private void templateForm_Load(object sender, EventArgs e)
        {
            typeCombobox.SelectedItem = "Plain Text";
            refreshCombobox();
        }

        private void refreshCombobox()
        {
            
            // TODO: This line of code loads data into the 'dbEmailDataSet2.tblTemplate' table. You can move, or remove it, as needed.
            this.tblTemplateTableAdapter.Fill(this.dbEmailDataSet2.tblTemplate);
        }

        private void createTemplateButton_Click(object sender, EventArgs e)
        {
            if(validateTemplate())
            {
                try
                {
                    sendData();
                    refreshCombobox();
                }

                catch(Exception ex)
                {
                    MessageBox.Show((ex.Message).ToString());
                    MessageBox.Show("Something went wrong. Data could not be saved.");
                }

                finally
                {
                    resetForm();
                }
            }

        }

        //method to validate template details
        private bool validateTemplate()
        {
            if(templateNameTexbox.Text == "")
            {
                MessageBox.Show("Please enter Template Name");
                return false;
            }

            else if(templateTextbox.Text == "")
            {
                MessageBox.Show("Please enter Template Text");
                return false;
            }

            else
            {
                return true;
            }
        }


        //method to send data to database
        private void sendData()
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spTemplate_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@templateName", templateNameTexbox.Text));
            cmd.Parameters.Add(new SqlParameter("@template", templateTextbox.Text));
            cmd.Parameters.Add(new SqlParameter("@type", (typeCombobox.SelectedItem).ToString()));

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


        //method to reset form
        private void resetForm()
        {
            templateTextbox.Text = "";
            templateNameTexbox.Text = "";
            templateViewTextbox.Text = "";
            templateNameCombobox.Refresh();
        }


        //method to display existing template
        private void viewTemplateButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spTemplate_GetById", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", Convert.ToInt32(templateNameCombobox.SelectedValue)));
            SqlDataReader rd;
            try
            {
                con.Open();
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    templateViewTextbox.Text = rd["template"].ToString();
                    templateTypeTextbox.Text = rd["type"].ToString();
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Something went wrong.");
            }

            finally
            {
                con.Close();
            }
        }


        //method to delete selected template
        private void deleteTemplateButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spTemplate_DeleteById", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", Convert.ToInt32(templateNameCombobox.SelectedValue)));

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                refreshCombobox();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Something went wrong.");
            }

            finally
            {
                con.Close();
            }
        }


    }
}
