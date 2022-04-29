namespace BulkEmailing
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.newUserButton = new System.Windows.Forms.Button();
            this.groupsButton = new System.Windows.Forms.Button();
            this.emailAccountsButton = new System.Windows.Forms.Button();
            this.sendEmailButton = new System.Windows.Forms.Button();
            this.newTemplateButton = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 724);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1350, 5);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Menu;
            this.panel5.Controls.Add(this.newTemplateButton);
            this.panel5.Controls.Add(this.closeButton);
            this.panel5.Controls.Add(this.newUserButton);
            this.panel5.Controls.Add(this.groupsButton);
            this.panel5.Controls.Add(this.emailAccountsButton);
            this.panel5.Controls.Add(this.sendEmailButton);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1350, 108);
            this.panel5.TabIndex = 2;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.Menu;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
            this.closeButton.Location = new System.Drawing.Point(1171, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(179, 108);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.closeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // newUserButton
            // 
            this.newUserButton.BackColor = System.Drawing.SystemColors.Menu;
            this.newUserButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.newUserButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.newUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newUserButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUserButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.newUserButton.Image = ((System.Drawing.Image)(resources.GetObject("newUserButton.Image")));
            this.newUserButton.Location = new System.Drawing.Point(538, 0);
            this.newUserButton.Name = "newUserButton";
            this.newUserButton.Size = new System.Drawing.Size(177, 108);
            this.newUserButton.TabIndex = 3;
            this.newUserButton.Text = "Add New User";
            this.newUserButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.newUserButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.newUserButton.UseVisualStyleBackColor = false;
            // 
            // groupsButton
            // 
            this.groupsButton.BackColor = System.Drawing.SystemColors.Menu;
            this.groupsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupsButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.groupsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.groupsButton.Image = ((System.Drawing.Image)(resources.GetObject("groupsButton.Image")));
            this.groupsButton.Location = new System.Drawing.Point(356, 0);
            this.groupsButton.Name = "groupsButton";
            this.groupsButton.Size = new System.Drawing.Size(182, 108);
            this.groupsButton.TabIndex = 2;
            this.groupsButton.Text = "Recipient Groups";
            this.groupsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.groupsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.groupsButton.UseVisualStyleBackColor = false;
            // 
            // emailAccountsButton
            // 
            this.emailAccountsButton.BackColor = System.Drawing.SystemColors.Menu;
            this.emailAccountsButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.emailAccountsButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.emailAccountsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emailAccountsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAccountsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.emailAccountsButton.Image = ((System.Drawing.Image)(resources.GetObject("emailAccountsButton.Image")));
            this.emailAccountsButton.Location = new System.Drawing.Point(171, 0);
            this.emailAccountsButton.Name = "emailAccountsButton";
            this.emailAccountsButton.Size = new System.Drawing.Size(185, 108);
            this.emailAccountsButton.TabIndex = 1;
            this.emailAccountsButton.Text = "Email Accounts";
            this.emailAccountsButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.emailAccountsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.emailAccountsButton.UseVisualStyleBackColor = false;
            // 
            // sendEmailButton
            // 
            this.sendEmailButton.BackColor = System.Drawing.SystemColors.Menu;
            this.sendEmailButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.sendEmailButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.sendEmailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendEmailButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendEmailButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.sendEmailButton.Image = ((System.Drawing.Image)(resources.GetObject("sendEmailButton.Image")));
            this.sendEmailButton.Location = new System.Drawing.Point(0, 0);
            this.sendEmailButton.Name = "sendEmailButton";
            this.sendEmailButton.Size = new System.Drawing.Size(171, 108);
            this.sendEmailButton.TabIndex = 0;
            this.sendEmailButton.Text = "Send Email";
            this.sendEmailButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sendEmailButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.sendEmailButton.UseVisualStyleBackColor = false;
            this.sendEmailButton.Click += new System.EventHandler(this.sendEmailButton_Click);
            // 
            // newTemplateButton
            // 
            this.newTemplateButton.BackColor = System.Drawing.SystemColors.Menu;
            this.newTemplateButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.newTemplateButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.newTemplateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newTemplateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTemplateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(239)))));
            this.newTemplateButton.Image = ((System.Drawing.Image)(resources.GetObject("newTemplateButton.Image")));
            this.newTemplateButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.newTemplateButton.Location = new System.Drawing.Point(715, 0);
            this.newTemplateButton.Name = "newTemplateButton";
            this.newTemplateButton.Size = new System.Drawing.Size(177, 108);
            this.newTemplateButton.TabIndex = 5;
            this.newTemplateButton.Text = "Create Template";
            this.newTemplateButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.newTemplateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.newTemplateButton.UseVisualStyleBackColor = false;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DashboardForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button newUserButton;
        private System.Windows.Forms.Button groupsButton;
        private System.Windows.Forms.Button emailAccountsButton;
        private System.Windows.Forms.Button sendEmailButton;
        private System.Windows.Forms.Button newTemplateButton;
    }
}

