using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulkEmailing
{
    public partial class DashboardForm : Form
    {
        Form activeForm = null;
        public DashboardForm()
        {
            InitializeComponent();
            emailForm formObj = new emailForm();
            openChildForm(formObj);
        }


        //method to open child forms inside parent container
        private void openChildForm(Form formObj)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            formObj.MdiParent = this;
            formObj.Show();
            formObj.Dock = DockStyle.Fill;
            formObj.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            formObj.TopLevel = false;
            activeForm = formObj;
        }


        //exit button onclick method to close the application
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //emailing form open on send email button click event
        private void sendEmailButton_Click(object sender, EventArgs e)
        {
            emailForm formObj = new emailForm();
            openChildForm(formObj);
        }

        //email accounts button onclick method to open accounts form
        private void emailAccountsButton_Click(object sender, EventArgs e)
        {
            accountsForm formObj = new accountsForm();
            openChildForm(formObj);
        }

        //groups button onclick method to open groups form
        private void groupsButton_Click(object sender, EventArgs e)
        {
            groupsForm formObj = new groupsForm();
            openChildForm(formObj);
        }

        //user button onclick method to open users form
        private void newUserButton_Click(object sender, EventArgs e)
        {
            userForm formObj = new userForm();
            openChildForm(formObj);
        }

        //template button onclick method to open template form
        private void newTemplateButton_Click(object sender, EventArgs e)
        {
            templateForm formObj = new templateForm();
            openChildForm(formObj);
        }
    }
}
