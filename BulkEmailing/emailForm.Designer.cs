namespace BulkEmailing
{
    partial class emailForm
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
            this.templateTypeTextbox = new System.Windows.Forms.TextBox();
            this.templateCombobox = new System.Windows.Forms.ComboBox();
            this.dbEmailDataSet2 = new BulkEmailing.dbEmailDataSet2();
            this.tblTemplateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbEmailDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupCombobox = new System.Windows.Forms.ComboBox();
            this.tblGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbEmailDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbEmailDataSet3 = new BulkEmailing.dbEmailDataSet3();
            this.senderCombobox = new System.Windows.Forms.ComboBox();
            this.tblSenderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbEmailDataSet5 = new BulkEmailing.dbEmailDataSet5();
            this.label7 = new System.Windows.Forms.Label();
            this.removeAttachmentButton = new System.Windows.Forms.Button();
            this.sendEmailButton = new System.Windows.Forms.Button();
            this.addAttachmentButton = new System.Windows.Forms.Button();
            this.attachmentListbox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.emailTextTextbox = new System.Windows.Forms.RichTextBox();
            this.subjectTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tblTemplateTableAdapter = new BulkEmailing.dbEmailDataSet2TableAdapters.tblTemplateTableAdapter();
            this.tblGroupsTableAdapter = new BulkEmailing.dbEmailDataSet3TableAdapters.tblGroupsTableAdapter();
            this.tblSenderTableAdapter = new BulkEmailing.dbEmailDataSet5TableAdapters.tblSenderTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbEmailDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTemplateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEmailDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGroupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEmailDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEmailDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSenderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEmailDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.templateTypeTextbox);
            this.panel1.Controls.Add(this.templateCombobox);
            this.panel1.Controls.Add(this.groupCombobox);
            this.panel1.Controls.Add(this.senderCombobox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.removeAttachmentButton);
            this.panel1.Controls.Add(this.sendEmailButton);
            this.panel1.Controls.Add(this.addAttachmentButton);
            this.panel1.Controls.Add(this.attachmentListbox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.emailTextTextbox);
            this.panel1.Controls.Add(this.subjectTextbox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(30, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1297, 576);
            this.panel1.TabIndex = 0;
            // 
            // templateTypeTextbox
            // 
            this.templateTypeTextbox.Location = new System.Drawing.Point(909, 207);
            this.templateTypeTextbox.Name = "templateTypeTextbox";
            this.templateTypeTextbox.ReadOnly = true;
            this.templateTypeTextbox.Size = new System.Drawing.Size(98, 29);
            this.templateTypeTextbox.TabIndex = 19;
            this.templateTypeTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // templateCombobox
            // 
            this.templateCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.templateCombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.templateCombobox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dbEmailDataSet2, "tblTemplate.id", true));
            this.templateCombobox.DataSource = this.tblTemplateBindingSource;
            this.templateCombobox.DisplayMember = "templateName";
            this.templateCombobox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templateCombobox.FormattingEnabled = true;
            this.templateCombobox.Location = new System.Drawing.Point(399, 207);
            this.templateCombobox.Name = "templateCombobox";
            this.templateCombobox.Size = new System.Drawing.Size(503, 29);
            this.templateCombobox.TabIndex = 18;
            this.templateCombobox.ValueMember = "id";
            this.templateCombobox.SelectedIndexChanged += new System.EventHandler(this.templateCombobox_SelectedIndexChanged);
            // 
            // dbEmailDataSet2
            // 
            this.dbEmailDataSet2.DataSetName = "dbEmailDataSet2";
            this.dbEmailDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblTemplateBindingSource
            // 
            this.tblTemplateBindingSource.DataMember = "tblTemplate";
            this.tblTemplateBindingSource.DataSource = this.dbEmailDataSet2BindingSource;
            // 
            // dbEmailDataSet2BindingSource
            // 
            this.dbEmailDataSet2BindingSource.DataSource = this.dbEmailDataSet2;
            this.dbEmailDataSet2BindingSource.Position = 0;
            // 
            // groupCombobox
            // 
            this.groupCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.groupCombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.groupCombobox.DataSource = this.tblGroupsBindingSource;
            this.groupCombobox.DisplayMember = "groupName";
            this.groupCombobox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCombobox.FormattingEnabled = true;
            this.groupCombobox.Location = new System.Drawing.Point(399, 161);
            this.groupCombobox.Name = "groupCombobox";
            this.groupCombobox.Size = new System.Drawing.Size(608, 29);
            this.groupCombobox.TabIndex = 17;
            this.groupCombobox.ValueMember = "id";
            // 
            // tblGroupsBindingSource
            // 
            this.tblGroupsBindingSource.DataMember = "tblGroups";
            this.tblGroupsBindingSource.DataSource = this.dbEmailDataSet3BindingSource;
            // 
            // dbEmailDataSet3BindingSource
            // 
            this.dbEmailDataSet3BindingSource.DataSource = this.dbEmailDataSet3;
            this.dbEmailDataSet3BindingSource.Position = 0;
            // 
            // dbEmailDataSet3
            // 
            this.dbEmailDataSet3.DataSetName = "dbEmailDataSet3";
            this.dbEmailDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // senderCombobox
            // 
            this.senderCombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.senderCombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.senderCombobox.DataSource = this.tblSenderBindingSource;
            this.senderCombobox.DisplayMember = "email";
            this.senderCombobox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senderCombobox.FormattingEnabled = true;
            this.senderCombobox.Location = new System.Drawing.Point(399, 79);
            this.senderCombobox.Name = "senderCombobox";
            this.senderCombobox.Size = new System.Drawing.Size(608, 29);
            this.senderCombobox.TabIndex = 16;
            this.senderCombobox.ValueMember = "id";
            // 
            // tblSenderBindingSource
            // 
            this.tblSenderBindingSource.DataMember = "tblSender";
            this.tblSenderBindingSource.DataSource = this.dbEmailDataSet5;
            // 
            // dbEmailDataSet5
            // 
            this.dbEmailDataSet5.DataSetName = "dbEmailDataSet5";
            this.dbEmailDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(226, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Select Template:";
            // 
            // removeAttachmentButton
            // 
            this.removeAttachmentButton.BackColor = System.Drawing.Color.Crimson;
            this.removeAttachmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeAttachmentButton.ForeColor = System.Drawing.Color.White;
            this.removeAttachmentButton.Location = new System.Drawing.Point(1182, 524);
            this.removeAttachmentButton.Name = "removeAttachmentButton";
            this.removeAttachmentButton.Size = new System.Drawing.Size(92, 33);
            this.removeAttachmentButton.TabIndex = 13;
            this.removeAttachmentButton.Text = "Remove";
            this.removeAttachmentButton.UseVisualStyleBackColor = false;
            this.removeAttachmentButton.Click += new System.EventHandler(this.removeAttachmentButton_Click);
            // 
            // sendEmailButton
            // 
            this.sendEmailButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.sendEmailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendEmailButton.ForeColor = System.Drawing.Color.White;
            this.sendEmailButton.Location = new System.Drawing.Point(193, 524);
            this.sendEmailButton.Name = "sendEmailButton";
            this.sendEmailButton.Size = new System.Drawing.Size(175, 43);
            this.sendEmailButton.TabIndex = 12;
            this.sendEmailButton.Text = "Send Email";
            this.sendEmailButton.UseVisualStyleBackColor = false;
            this.sendEmailButton.Click += new System.EventHandler(this.sendEmailButton_Click);
            // 
            // addAttachmentButton
            // 
            this.addAttachmentButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.addAttachmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAttachmentButton.ForeColor = System.Drawing.Color.White;
            this.addAttachmentButton.Location = new System.Drawing.Point(1195, 240);
            this.addAttachmentButton.Name = "addAttachmentButton";
            this.addAttachmentButton.Size = new System.Drawing.Size(79, 31);
            this.addAttachmentButton.TabIndex = 11;
            this.addAttachmentButton.Text = "Add";
            this.addAttachmentButton.UseVisualStyleBackColor = false;
            this.addAttachmentButton.Click += new System.EventHandler(this.addAttachmentButton_Click);
            // 
            // attachmentListbox
            // 
            this.attachmentListbox.FormattingEnabled = true;
            this.attachmentListbox.ItemHeight = 21;
            this.attachmentListbox.Location = new System.Drawing.Point(1013, 277);
            this.attachmentListbox.Name = "attachmentListbox";
            this.attachmentListbox.Size = new System.Drawing.Size(261, 235);
            this.attachmentListbox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(1013, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Add Attachment:";
            // 
            // emailTextTextbox
            // 
            this.emailTextTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextTextbox.Location = new System.Drawing.Point(193, 272);
            this.emailTextTextbox.Name = "emailTextTextbox";
            this.emailTextTextbox.Size = new System.Drawing.Size(814, 246);
            this.emailTextTextbox.TabIndex = 8;
            this.emailTextTextbox.Text = "";
            // 
            // subjectTextbox
            // 
            this.subjectTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectTextbox.Location = new System.Drawing.Point(399, 118);
            this.subjectTextbox.Name = "subjectTextbox";
            this.subjectTextbox.Size = new System.Drawing.Size(608, 29);
            this.subjectTextbox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(226, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "To email groups: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(189, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email Text:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(226, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(226, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "From email account:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(542, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Send Emails";
            // 
            // tblTemplateTableAdapter
            // 
            this.tblTemplateTableAdapter.ClearBeforeFill = true;
            // 
            // tblGroupsTableAdapter
            // 
            this.tblGroupsTableAdapter.ClearBeforeFill = true;
            // 
            // tblSenderTableAdapter
            // 
            this.tblSenderTableAdapter.ClearBeforeFill = true;
            // 
            // emailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 600);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "emailForm";
            this.Text = "emailForm";
            this.Load += new System.EventHandler(this.emailForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbEmailDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTemplateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEmailDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblGroupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEmailDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEmailDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSenderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEmailDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox subjectTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox attachmentListbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox emailTextTextbox;
        private System.Windows.Forms.Button sendEmailButton;
        private System.Windows.Forms.Button addAttachmentButton;
        private System.Windows.Forms.Button removeAttachmentButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox templateCombobox;
        private System.Windows.Forms.ComboBox groupCombobox;
        private System.Windows.Forms.ComboBox senderCombobox;
        private dbEmailDataSet2 dbEmailDataSet2;
        private System.Windows.Forms.BindingSource dbEmailDataSet2BindingSource;
        private System.Windows.Forms.BindingSource tblTemplateBindingSource;
        private dbEmailDataSet2TableAdapters.tblTemplateTableAdapter tblTemplateTableAdapter;
        private System.Windows.Forms.BindingSource dbEmailDataSet3BindingSource;
        private dbEmailDataSet3 dbEmailDataSet3;
        private System.Windows.Forms.BindingSource tblGroupsBindingSource;
        private dbEmailDataSet3TableAdapters.tblGroupsTableAdapter tblGroupsTableAdapter;
        private dbEmailDataSet5 dbEmailDataSet5;
        private System.Windows.Forms.BindingSource tblSenderBindingSource;
        private dbEmailDataSet5TableAdapters.tblSenderTableAdapter tblSenderTableAdapter;
        private System.Windows.Forms.TextBox templateTypeTextbox;
    }
}