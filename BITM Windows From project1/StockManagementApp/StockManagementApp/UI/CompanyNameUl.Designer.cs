namespace StockManagementApp.UI
{
    partial class CompanyNameUl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.companyListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saveCompanyNameButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.companyListView);
            this.groupBox1.Controls.Add(this.saveCompanyNameButton);
            this.groupBox1.Controls.Add(this.companyNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 432);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Company List";
            // 
            // companyListView
            // 
            this.companyListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.companyListView.FullRowSelect = true;
            this.companyListView.GridLines = true;
            this.companyListView.Location = new System.Drawing.Point(98, 151);
            this.companyListView.Name = "companyListView";
            this.companyListView.Size = new System.Drawing.Size(376, 213);
            this.companyListView.TabIndex = 7;
            this.companyListView.UseCompatibleStateImageBehavior = false;
            this.companyListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "SI";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 308;
            // 
            // saveCompanyNameButton
            // 
            this.saveCompanyNameButton.Location = new System.Drawing.Point(315, 97);
            this.saveCompanyNameButton.Name = "saveCompanyNameButton";
            this.saveCompanyNameButton.Size = new System.Drawing.Size(152, 34);
            this.saveCompanyNameButton.TabIndex = 6;
            this.saveCompanyNameButton.Text = "Save";
            this.saveCompanyNameButton.UseVisualStyleBackColor = true;
            this.saveCompanyNameButton.Click += new System.EventHandler(this.saveCompanyNameButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.Location = new System.Drawing.Point(165, 58);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(309, 26);
            this.companyNameTextBox.TabIndex = 5;
            // 
            // CompanyNameUl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 456);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CompanyNameUl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompanyNameUl";
            this.Load += new System.EventHandler(this.CompanyNameUl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView companyListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button saveCompanyNameButton;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.Label label1;
    }
}