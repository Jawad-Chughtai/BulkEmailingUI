namespace BulkEmailing
{
    partial class groupsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.removeAccountButton = new System.Windows.Forms.Button();
            this.groupListbox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.recieverCombobox = new System.Windows.Forms.ComboBox();
            this.tblRecieverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbEmailDataSet4 = new BulkEmailing.dbEmailDataSet4();
            this.groupNameCombobox = new System.Windows.Forms.ComboBox();
            this.tblGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbEmailDataSet3 = new BulkEmailing.dbEmailDataSet3();
            this.recieverButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newGroupButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupNameTextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tblGroupsTableAdapter = new BulkEmailing.dbEmailDataSet3TableAdapters.tblGroupsTableAdapter();
            this.tblRecieverTableAdapter = new BulkEmailing.dbEmailDataSet4TableAdapters.tblRecieverTableAdapter();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRecieverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEmailDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGroupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEmailDataSet3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(27, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1297, 576);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.removeAccountButton);
            this.panel4.Controls.Add(this.groupListbox);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(644, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(653, 538);
            this.panel4.TabIndex = 3;
            // 
            // removeAccountButton
            // 
            this.removeAccountButton.BackColor = System.Drawing.Color.Crimson;
            this.removeAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeAccountButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeAccountButton.ForeColor = System.Drawing.Color.White;
            this.removeAccountButton.Location = new System.Drawing.Point(406, 473);
            this.removeAccountButton.Name = "removeAccountButton";
            this.removeAccountButton.Size = new System.Drawing.Size(167, 37);
            this.removeAccountButton.TabIndex = 30;
            this.removeAccountButton.Text = "Remove Selected";
            this.removeAccountButton.UseVisualStyleBackColor = false;
            this.removeAccountButton.Click += new System.EventHandler(this.removeAccountButton_Click);
            // 
            // groupListbox
            // 
            this.groupListbox.FormattingEnabled = true;
            this.groupListbox.ItemHeight = 21;
            this.groupListbox.Location = new System.Drawing.Point(72, 64);
            this.groupListbox.Name = "groupListbox";
            this.groupListbox.Size = new System.Drawing.Size(501, 403);
            this.groupListbox.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(42, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Group Recipients";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.recieverCombobox);
            this.panel3.Controls.Add(this.groupNameCombobox);
            this.panel3.Controls.Add(this.recieverButton);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.newGroupButton);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.groupNameTextbox);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(638, 538);
            this.panel3.TabIndex = 2;
            // 
            // recieverCombobox
            // 
            this.recieverCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.recieverCombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.recieverCombobox.DataSource = this.tblRecieverBindingSource;
            this.recieverCombobox.DisplayMember = "email";
            this.recieverCombobox.FormattingEnabled = true;
            this.recieverCombobox.Location = new System.Drawing.Point(202, 295);
            this.recieverCombobox.Name = "recieverCombobox";
            this.recieverCombobox.Size = new System.Drawing.Size(302, 29);
            this.recieverCombobox.TabIndex = 35;
            this.recieverCombobox.ValueMember = "id";
            // 
            // tblRecieverBindingSource
            // 
            this.tblRecieverBindingSource.DataMember = "tblReciever";
            this.tblRecieverBindingSource.DataSource = this.dbEmailDataSet4;
            // 
            // dbEmailDataSet4
            // 
            this.dbEmailDataSet4.DataSetName = "dbEmailDataSet4";
            this.dbEmailDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupNameCombobox
            // 
            this.groupNameCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.groupNameCombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.groupNameCombobox.DataSource = this.tblGroupsBindingSource;
            this.groupNameCombobox.DisplayMember = "groupName";
            this.groupNameCombobox.FormattingEnabled = true;
            this.groupNameCombobox.Location = new System.Drawing.Point(202, 253);
            this.groupNameCombobox.Name = "groupNameCombobox";
            this.groupNameCombobox.Size = new System.Drawing.Size(302, 29);
            this.groupNameCombobox.TabIndex = 34;
            this.groupNameCombobox.ValueMember = "id";
            this.groupNameCombobox.SelectedIndexChanged += new System.EventHandler(this.groupNameCombobox_SelectedIndexChanged);
            // 
            // tblGroupsBindingSource
            // 
            this.tblGroupsBindingSource.DataMember = "tblGroups";
            this.tblGroupsBindingSource.DataSource = this.dbEmailDataSet3;
            // 
            // dbEmailDataSet3
            // 
            this.dbEmailDataSet3.DataSetName = "dbEmailDataSet3";
            this.dbEmailDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recieverButton
            // 
            this.recieverButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.recieverButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recieverButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieverButton.ForeColor = System.Drawing.Color.White;
            this.recieverButton.Location = new System.Drawing.Point(364, 330);
            this.recieverButton.Name = "recieverButton";
            this.recieverButton.Size = new System.Drawing.Size(140, 31);
            this.recieverButton.TabIndex = 33;
            this.recieverButton.Text = "Add Recipient";
            this.recieverButton.UseVisualStyleBackColor = false;
            this.recieverButton.Click += new System.EventHandler(this.recieverButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(70, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 21);
            this.label4.TabIndex = 31;
            this.label4.Text = "Recipient Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(70, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "Group Name: ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(55, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Add Recipent to Group";
            // 
            // newGroupButton
            // 
            this.newGroupButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.newGroupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newGroupButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGroupButton.ForeColor = System.Drawing.Color.White;
            this.newGroupButton.Location = new System.Drawing.Point(364, 99);
            this.newGroupButton.Name = "newGroupButton";
            this.newGroupButton.Size = new System.Drawing.Size(140, 31);
            this.newGroupButton.TabIndex = 26;
            this.newGroupButton.Text = "Create Group";
            this.newGroupButton.UseVisualStyleBackColor = false;
            this.newGroupButton.Click += new System.EventHandler(this.newGroupButton_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(55, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(261, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Create new Recipient Group";
            // 
            // groupNameTextbox
            // 
            this.groupNameTextbox.Location = new System.Drawing.Point(202, 64);
            this.groupNameTextbox.Name = "groupNameTextbox";
            this.groupNameTextbox.Size = new System.Drawing.Size(302, 29);
            this.groupNameTextbox.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(70, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 21);
            this.label8.TabIndex = 22;
            this.label8.Text = "Group Name: ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1297, 38);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(521, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recipient Groups";
            // 
            // tblGroupsTableAdapter
            // 
            this.tblGroupsTableAdapter.ClearBeforeFill = true;
            // 
            // tblRecieverTableAdapter
            // 
            this.tblRecieverTableAdapter.ClearBeforeFill = true;
            // 
            // groupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 600);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "groupsForm";
            this.Text = "groupsForm";
            this.Load += new System.EventHandler(this.groupsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRecieverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEmailDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGroupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEmailDataSet3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox groupNameTextbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button recieverButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button newGroupButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox groupListbox;
        private System.Windows.Forms.Button removeAccountButton;
        private System.Windows.Forms.ComboBox groupNameCombobox;
        private dbEmailDataSet3 dbEmailDataSet3;
        private System.Windows.Forms.BindingSource tblGroupsBindingSource;
        private dbEmailDataSet3TableAdapters.tblGroupsTableAdapter tblGroupsTableAdapter;
        private System.Windows.Forms.ComboBox recieverCombobox;
        private dbEmailDataSet4 dbEmailDataSet4;
        private System.Windows.Forms.BindingSource tblRecieverBindingSource;
        private dbEmailDataSet4TableAdapters.tblRecieverTableAdapter tblRecieverTableAdapter;
    }
}