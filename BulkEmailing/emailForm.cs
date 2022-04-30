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
using System.Net.Mail;
using System.Web;

namespace BulkEmailing
{
    public partial class emailForm : Form
    {
        public emailForm()
        {
            InitializeComponent();
        }


        //form load method
        private void emailForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbEmailDataSet5.tblSender' table. You can move, or remove it, as needed.
            this.tblSenderTableAdapter.Fill(this.dbEmailDataSet5.tblSender);
            // TODO: This line of code loads data into the 'dbEmailDataSet3.tblGroups' table. You can move, or remove it, as needed.
            this.tblGroupsTableAdapter.Fill(this.dbEmailDataSet3.tblGroups);
            // TODO: This line of code loads data into the 'dbEmailDataSet2.tblTemplate' table. You can move, or remove it, as needed.
            this.tblTemplateTableAdapter.Fill(this.dbEmailDataSet2.tblTemplate);

        }


        //template drop down onchange method
        private void templateCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spTemplate_GetById", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", Convert.ToInt32(templateCombobox.SelectedValue)));
            SqlDataReader rd;
            try
            {
                con.Open();
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    emailTextTextbox.Text = rd["template"].ToString();
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

        //send email button onclick method
        private void sendEmailButton_Click(object sender, EventArgs e)
        {
            if (senderCombobox.SelectedValue == null)
            {
                MessageBox.Show("Sender is not selected");
            }

            else if (subjectTextbox.Text == "")
            {
                MessageBox.Show("Please enter Subject of the email");
            }

            else if (groupCombobox.SelectedValue == null)
            {
                MessageBox.Show("Group is not selected");
            }

            else if (emailTextTextbox.Text == "")
            {
                MessageBox.Show("Please write Email Text");
            }

            else
            {
                var confirm = MessageBox.Show("Are you sure you want to send this email?", "Confirm Send", MessageBoxButtons.YesNoCancel);

                if (confirm == DialogResult.No)
                {
                    return;
                }

                else if (confirm == DialogResult.Cancel)
                {
                    return;
                }

                else if (confirm == DialogResult.Yes)
                {
                    sendEmail();
                }
            }
        }

        //method to save email to database
        private void sendEmail()
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spSentEmail_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@sender", Convert.ToInt32(senderCombobox.SelectedValue)));
            cmd.Parameters.Add(new SqlParameter("@group", Convert.ToInt32(groupCombobox.SelectedValue)));
            cmd.Parameters.Add(new SqlParameter("@subject", subjectTextbox.Text));
            cmd.Parameters.Add(new SqlParameter("@email", emailTextTextbox.Text));
            cmd.Parameters.Add(new SqlParameter("@date", DateTime.Now.Date));

            try
            {
                con.Open();
                sendEmailToGroup();
                cmd.ExecuteNonQuery();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Something went wrong. Message could not be sent.");
            }

            finally
            {
                con.Close();
                resetForm();
            }
        }


        // method to reset form details
        private void resetForm()
        {
            senderCombobox.SelectedIndex = 0;
            subjectTextbox.Text = "";
            groupCombobox.SelectedIndex = 0;
            templateCombobox.SelectedIndex = 0;
            emailTextTextbox.Text = "";
            templateTypeTextbox.Text = "";
        }


        // method to add attachments
        private void addAttachmentButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog attachment = new OpenFileDialog();
            attachment.Multiselect = false;
            
            if(attachment.ShowDialog() == DialogResult.OK)
            {
                string fileName = attachment.FileName;
                attachmentListbox.Items.Add(fileName);
            }
        }

        // method to remove attachments
        private void removeAttachmentButton_Click(object sender, EventArgs e)
        {
            attachmentListbox.Items.Remove(attachmentListbox.SelectedItem);
        }

        // method to send email to group
        private void sendEmailToGroup()
        {

        }

    }
}
