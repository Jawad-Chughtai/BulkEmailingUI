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
    public partial class groupsForm : Form
    {
        public groupsForm()
        {
            InitializeComponent();
        }

        //form load method
        private void groupsForm_Load(object sender, EventArgs e)
        {
            wireupCombobox();
            wireupListbox();
        }


        //new group create button onclick method
        private void newGroupButton_Click(object sender, EventArgs e)
        {
            if(groupNameTextbox.Text != "")
            {
                try
                {
                    SqlConnection con = dbConnection.getCon();
                    SqlCommand cmd = new SqlCommand("spGroup_Insert", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@name", groupNameTextbox.Text));
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

                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Something went wrong. Data could not be saved.");
                }

                finally
                {
                    groupNameTextbox.Text = "";
                    wireupCombobox();
                }
            }

            else
            {
                MessageBox.Show("Please enter Group Name");
            }

        }


        //wire up combobox method
        private void wireupCombobox()
        {
            // TODO: This line of code loads data into the 'dbEmailDataSet4.tblReciever' table. You can move, or remove it, as needed.
            this.tblRecieverTableAdapter.Fill(this.dbEmailDataSet4.tblReciever);
            // TODO: This line of code loads data into the 'dbEmailDataSet3.tblGroups' table. You can move, or remove it, as needed.
            this.tblGroupsTableAdapter.Fill(this.dbEmailDataSet3.tblGroups);

        }

        private void recieverButton_Click(object sender, EventArgs e)
        {
            if(groupNameCombobox.SelectedValue == null)
            {
                MessageBox.Show("Please select a group");
            }

            else if(recieverCombobox.SelectedValue == null)
            {
                MessageBox.Show("Please select a reciever");
            }

            else
            {
                addToGroup();
            }
        }

        //method to add reciever to group in database
        private void addToGroup()
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spEmailGroups_Insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@groupID", groupNameCombobox.SelectedValue));
            cmd.Parameters.Add(new SqlParameter("@recieverID", recieverCombobox.SelectedValue));

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }

            finally
            {
                con.Close();
                wireupListbox();
            }
        }

        //method to add data to the list box
        private void wireupListbox()
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spEmailGroups_GetById", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@id", Convert.ToInt32(groupNameCombobox.SelectedValue)));

            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();

            try
            {
                con.Open();
                da.SelectCommand = cmd;
                da.Fill(ds);
                da.Dispose();
                groupListbox.DataSource = ds.Tables[0];
                groupListbox.DisplayMember = "email";
                groupListbox.ValueMember = "id";

            }

            finally
            {
                con.Close();
            }
        }

        private void removeAccountButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = dbConnection.getCon();
            SqlCommand cmd = new SqlCommand("spEmailGroups_DeleteById", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@recieverID", Convert.ToInt32(groupListbox.SelectedValue)));
            cmd.Parameters.Add(new SqlParameter("@groupID", Convert.ToInt32(groupNameCombobox.SelectedValue)));

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }

            finally
            {
                con.Close();
                wireupListbox();
            }
        }

        private void groupNameCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            wireupListbox();
        }

    }
}
