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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.emailAccountTextbox = new System.Windows.Forms.TextBox();
            this.subjectTextbox = new System.Windows.Forms.TextBox();
            this.emailGroupsTextbox = new System.Windows.Forms.TextBox();
            this.emailTextTextbox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.attachmentListbox = new System.Windows.Forms.ListBox();
            this.addAttachmentButton = new System.Windows.Forms.Button();
            this.sendEmailButton = new System.Windows.Forms.Button();
            this.removeAttachmentButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.removeAttachmentButton);
            this.panel1.Controls.Add(this.sendEmailButton);
            this.panel1.Controls.Add(this.addAttachmentButton);
            this.panel1.Controls.Add(this.attachmentListbox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.emailTextTextbox);
            this.panel1.Controls.Add(this.emailGroupsTextbox);
            this.panel1.Controls.Add(this.subjectTextbox);
            this.panel1.Controls.Add(this.emailAccountTextbox);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(189, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "From email account:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(189, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(189, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email Text:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(189, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "To email groups: ";
            // 
            // emailAccountTextbox
            // 
            this.emailAccountTextbox.Location = new System.Drawing.Point(399, 76);
            this.emailAccountTextbox.Name = "emailAccountTextbox";
            this.emailAccountTextbox.Size = new System.Drawing.Size(608, 29);
            this.emailAccountTextbox.TabIndex = 5;
            // 
            // subjectTextbox
            // 
            this.subjectTextbox.Location = new System.Drawing.Point(399, 118);
            this.subjectTextbox.Name = "subjectTextbox";
            this.subjectTextbox.Size = new System.Drawing.Size(608, 29);
            this.subjectTextbox.TabIndex = 6;
            // 
            // emailGroupsTextbox
            // 
            this.emailGroupsTextbox.Location = new System.Drawing.Point(399, 158);
            this.emailGroupsTextbox.Name = "emailGroupsTextbox";
            this.emailGroupsTextbox.Size = new System.Drawing.Size(608, 29);
            this.emailGroupsTextbox.TabIndex = 7;
            // 
            // emailTextTextbox
            // 
            this.emailTextTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTextTextbox.Location = new System.Drawing.Point(193, 255);
            this.emailTextTextbox.Name = "emailTextTextbox";
            this.emailTextTextbox.Size = new System.Drawing.Size(814, 230);
            this.emailTextTextbox.TabIndex = 8;
            this.emailTextTextbox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(1013, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Add Attachment:";
            // 
            // attachmentListbox
            // 
            this.attachmentListbox.FormattingEnabled = true;
            this.attachmentListbox.ItemHeight = 21;
            this.attachmentListbox.Location = new System.Drawing.Point(1017, 292);
            this.attachmentListbox.Name = "attachmentListbox";
            this.attachmentListbox.Size = new System.Drawing.Size(261, 193);
            this.attachmentListbox.TabIndex = 10;
            // 
            // addAttachmentButton
            // 
            this.addAttachmentButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.addAttachmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAttachmentButton.ForeColor = System.Drawing.Color.White;
            this.addAttachmentButton.Location = new System.Drawing.Point(1199, 255);
            this.addAttachmentButton.Name = "addAttachmentButton";
            this.addAttachmentButton.Size = new System.Drawing.Size(79, 31);
            this.addAttachmentButton.TabIndex = 11;
            this.addAttachmentButton.Text = "Add";
            this.addAttachmentButton.UseVisualStyleBackColor = false;
            // 
            // sendEmailButton
            // 
            this.sendEmailButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.sendEmailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendEmailButton.ForeColor = System.Drawing.Color.White;
            this.sendEmailButton.Location = new System.Drawing.Point(193, 507);
            this.sendEmailButton.Name = "sendEmailButton";
            this.sendEmailButton.Size = new System.Drawing.Size(175, 43);
            this.sendEmailButton.TabIndex = 12;
            this.sendEmailButton.Text = "Send Email";
            this.sendEmailButton.UseVisualStyleBackColor = false;
            // 
            // removeAttachmentButton
            // 
            this.removeAttachmentButton.BackColor = System.Drawing.Color.Crimson;
            this.removeAttachmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeAttachmentButton.ForeColor = System.Drawing.Color.White;
            this.removeAttachmentButton.Location = new System.Drawing.Point(1186, 507);
            this.removeAttachmentButton.Name = "removeAttachmentButton";
            this.removeAttachmentButton.Size = new System.Drawing.Size(92, 33);
            this.removeAttachmentButton.TabIndex = 13;
            this.removeAttachmentButton.Text = "Remove";
            this.removeAttachmentButton.UseVisualStyleBackColor = false;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox emailGroupsTextbox;
        private System.Windows.Forms.TextBox subjectTextbox;
        private System.Windows.Forms.TextBox emailAccountTextbox;
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
    }
}