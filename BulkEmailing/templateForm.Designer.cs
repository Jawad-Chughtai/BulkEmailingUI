namespace BulkEmailing
{
    partial class templateForm
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
            this.templateNameCombobox = new System.Windows.Forms.ComboBox();
            this.tblTemplateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbEmailDataSet2 = new BulkEmailing.dbEmailDataSet2();
            this.deleteTemplateButton = new System.Windows.Forms.Button();
            this.templateViewTextbox = new System.Windows.Forms.RichTextBox();
            this.viewTemplateButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.typeCombobox = new System.Windows.Forms.ComboBox();
            this.createTemplateButton = new System.Windows.Forms.Button();
            this.templateTextbox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.templateNameTexbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tblTemplateTableAdapter = new BulkEmailing.dbEmailDataSet2TableAdapters.tblTemplateTableAdapter();
            this.templateTypeTextbox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTemplateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEmailDataSet2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.templateTypeTextbox);
            this.panel1.Controls.Add(this.templateNameCombobox);
            this.panel1.Controls.Add(this.deleteTemplateButton);
            this.panel1.Controls.Add(this.templateViewTextbox);
            this.panel1.Controls.Add(this.viewTemplateButton);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(27, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1297, 576);
            this.panel1.TabIndex = 1;
            // 
            // templateNameCombobox
            // 
            this.templateNameCombobox.DataSource = this.tblTemplateBindingSource;
            this.templateNameCombobox.DisplayMember = "templateName";
            this.templateNameCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.templateNameCombobox.FormattingEnabled = true;
            this.templateNameCombobox.Location = new System.Drawing.Point(892, 105);
            this.templateNameCombobox.Name = "templateNameCombobox";
            this.templateNameCombobox.Size = new System.Drawing.Size(302, 29);
            this.templateNameCombobox.TabIndex = 32;
            this.templateNameCombobox.ValueMember = "id";
            // 
            // tblTemplateBindingSource
            // 
            this.tblTemplateBindingSource.DataMember = "tblTemplate";
            this.tblTemplateBindingSource.DataSource = this.dbEmailDataSet2;
            // 
            // dbEmailDataSet2
            // 
            this.dbEmailDataSet2.DataSetName = "dbEmailDataSet2";
            this.dbEmailDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deleteTemplateButton
            // 
            this.deleteTemplateButton.BackColor = System.Drawing.Color.Crimson;
            this.deleteTemplateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTemplateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTemplateButton.ForeColor = System.Drawing.Color.White;
            this.deleteTemplateButton.Location = new System.Drawing.Point(1027, 523);
            this.deleteTemplateButton.Name = "deleteTemplateButton";
            this.deleteTemplateButton.Size = new System.Drawing.Size(167, 31);
            this.deleteTemplateButton.TabIndex = 31;
            this.deleteTemplateButton.Text = "Delete Template";
            this.deleteTemplateButton.UseVisualStyleBackColor = false;
            this.deleteTemplateButton.Click += new System.EventHandler(this.deleteTemplateButton_Click);
            // 
            // templateViewTextbox
            // 
            this.templateViewTextbox.Location = new System.Drawing.Point(748, 192);
            this.templateViewTextbox.Name = "templateViewTextbox";
            this.templateViewTextbox.Size = new System.Drawing.Size(446, 316);
            this.templateViewTextbox.TabIndex = 29;
            this.templateViewTextbox.Text = "";
            // 
            // viewTemplateButton
            // 
            this.viewTemplateButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.viewTemplateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewTemplateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTemplateButton.ForeColor = System.Drawing.Color.White;
            this.viewTemplateButton.Location = new System.Drawing.Point(1054, 147);
            this.viewTemplateButton.Name = "viewTemplateButton";
            this.viewTemplateButton.Size = new System.Drawing.Size(140, 31);
            this.viewTemplateButton.TabIndex = 28;
            this.viewTemplateButton.Text = "View Template";
            this.viewTemplateButton.UseVisualStyleBackColor = false;
            this.viewTemplateButton.Click += new System.EventHandler(this.viewTemplateButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(744, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Template Name:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(699, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Existing Templates";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.typeCombobox);
            this.panel3.Controls.Add(this.createTemplateButton);
            this.panel3.Controls.Add(this.templateTextbox);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.templateNameTexbox);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(638, 538);
            this.panel3.TabIndex = 5;
            // 
            // typeCombobox
            // 
            this.typeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCombobox.FormattingEnabled = true;
            this.typeCombobox.Items.AddRange(new object[] {
            "Plain Text",
            "HTML"});
            this.typeCombobox.Location = new System.Drawing.Point(437, 29);
            this.typeCombobox.Name = "typeCombobox";
            this.typeCombobox.Size = new System.Drawing.Size(110, 29);
            this.typeCombobox.TabIndex = 28;
            // 
            // createTemplateButton
            // 
            this.createTemplateButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.createTemplateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTemplateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTemplateButton.ForeColor = System.Drawing.Color.White;
            this.createTemplateButton.Location = new System.Drawing.Point(390, 485);
            this.createTemplateButton.Name = "createTemplateButton";
            this.createTemplateButton.Size = new System.Drawing.Size(158, 31);
            this.createTemplateButton.TabIndex = 27;
            this.createTemplateButton.Text = "Create Template";
            this.createTemplateButton.UseVisualStyleBackColor = false;
            this.createTemplateButton.Click += new System.EventHandler(this.createTemplateButton_Click);
            // 
            // templateTextbox
            // 
            this.templateTextbox.Location = new System.Drawing.Point(102, 154);
            this.templateTextbox.Name = "templateTextbox";
            this.templateTextbox.Size = new System.Drawing.Size(446, 316);
            this.templateTextbox.TabIndex = 25;
            this.templateTextbox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(98, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Template:";
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
            this.label9.Size = new System.Drawing.Size(196, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Create new Template";
            // 
            // templateNameTexbox
            // 
            this.templateNameTexbox.Location = new System.Drawing.Point(246, 67);
            this.templateNameTexbox.Name = "templateNameTexbox";
            this.templateNameTexbox.Size = new System.Drawing.Size(302, 29);
            this.templateNameTexbox.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(98, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 21);
            this.label8.TabIndex = 22;
            this.label8.Text = "Template Name:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1297, 38);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(533, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Templates";
            // 
            // tblTemplateTableAdapter
            // 
            this.tblTemplateTableAdapter.ClearBeforeFill = true;
            // 
            // templateTypeTextbox
            // 
            this.templateTypeTextbox.Location = new System.Drawing.Point(892, 149);
            this.templateTypeTextbox.Name = "templateTypeTextbox";
            this.templateTypeTextbox.ReadOnly = true;
            this.templateTypeTextbox.Size = new System.Drawing.Size(98, 29);
            this.templateTypeTextbox.TabIndex = 20;
            this.templateTypeTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // templateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 600);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "templateForm";
            this.Text = "templateForm";
            this.Load += new System.EventHandler(this.templateForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblTemplateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEmailDataSet2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox templateTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox templateNameTexbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox templateViewTextbox;
        private System.Windows.Forms.Button viewTemplateButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button createTemplateButton;
        private System.Windows.Forms.Button deleteTemplateButton;
        private System.Windows.Forms.ComboBox typeCombobox;
        private System.Windows.Forms.ComboBox templateNameCombobox;
        private dbEmailDataSet2 dbEmailDataSet2;
        private System.Windows.Forms.BindingSource tblTemplateBindingSource;
        private dbEmailDataSet2TableAdapters.tblTemplateTableAdapter tblTemplateTableAdapter;
        private System.Windows.Forms.TextBox templateTypeTextbox;
    }
}