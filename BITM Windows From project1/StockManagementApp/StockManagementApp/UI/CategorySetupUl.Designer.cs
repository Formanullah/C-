namespace StockManagementApp.UI
{
    partial class CategorySetupUl
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
            this.ItemUlButton = new System.Windows.Forms.Button();
            this.companyUlBotton = new System.Windows.Forms.Button();
            this.hiddenDateLevel = new System.Windows.Forms.Label();
            this.hiddenIdLabel = new System.Windows.Forms.Label();
            this.categoryListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.saveCategoryButton = new System.Windows.Forms.Button();
            this.categoryNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stockInButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stockInButton);
            this.groupBox1.Controls.Add(this.ItemUlButton);
            this.groupBox1.Controls.Add(this.companyUlBotton);
            this.groupBox1.Controls.Add(this.hiddenDateLevel);
            this.groupBox1.Controls.Add(this.hiddenIdLabel);
            this.groupBox1.Controls.Add(this.categoryListView);
            this.groupBox1.Controls.Add(this.saveCategoryButton);
            this.groupBox1.Controls.Add(this.categoryNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 446);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category List";
            // 
            // ItemUlButton
            // 
            this.ItemUlButton.Location = new System.Drawing.Point(216, 357);
            this.ItemUlButton.Name = "ItemUlButton";
            this.ItemUlButton.Size = new System.Drawing.Size(122, 27);
            this.ItemUlButton.TabIndex = 11;
            this.ItemUlButton.Text = "ItemUl";
            this.ItemUlButton.UseVisualStyleBackColor = true;
            this.ItemUlButton.Click += new System.EventHandler(this.ItemUlButton_Click);
            // 
            // companyUlBotton
            // 
            this.companyUlBotton.Location = new System.Drawing.Point(84, 352);
            this.companyUlBotton.Name = "companyUlBotton";
            this.companyUlBotton.Size = new System.Drawing.Size(126, 32);
            this.companyUlBotton.TabIndex = 10;
            this.companyUlBotton.Text = "Company Ul";
            this.companyUlBotton.UseVisualStyleBackColor = true;
            this.companyUlBotton.Click += new System.EventHandler(this.companyUlBotton_Click);
            // 
            // hiddenDateLevel
            // 
            this.hiddenDateLevel.AutoSize = true;
            this.hiddenDateLevel.Location = new System.Drawing.Point(80, 76);
            this.hiddenDateLevel.Name = "hiddenDateLevel";
            this.hiddenDateLevel.Size = new System.Drawing.Size(51, 20);
            this.hiddenDateLevel.TabIndex = 9;
            this.hiddenDateLevel.Text = "label2";
            this.hiddenDateLevel.Visible = false;
            // 
            // hiddenIdLabel
            // 
            this.hiddenIdLabel.AutoSize = true;
            this.hiddenIdLabel.Location = new System.Drawing.Point(160, 72);
            this.hiddenIdLabel.Name = "hiddenIdLabel";
            this.hiddenIdLabel.Size = new System.Drawing.Size(51, 20);
            this.hiddenIdLabel.TabIndex = 8;
            this.hiddenIdLabel.Text = "label2";
            this.hiddenIdLabel.Visible = false;
            // 
            // categoryListView
            // 
            this.categoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.categoryListView.FullRowSelect = true;
            this.categoryListView.GridLines = true;
            this.categoryListView.Location = new System.Drawing.Point(84, 115);
            this.categoryListView.Name = "categoryListView";
            this.categoryListView.Size = new System.Drawing.Size(376, 213);
            this.categoryListView.TabIndex = 7;
            this.categoryListView.UseCompatibleStateImageBehavior = false;
            this.categoryListView.View = System.Windows.Forms.View.Details;
            this.categoryListView.DoubleClick += new System.EventHandler(this.categoryListView_DoubleClick);
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
            // saveCategoryButton
            // 
            this.saveCategoryButton.Location = new System.Drawing.Point(304, 72);
            this.saveCategoryButton.Name = "saveCategoryButton";
            this.saveCategoryButton.Size = new System.Drawing.Size(152, 28);
            this.saveCategoryButton.TabIndex = 6;
            this.saveCategoryButton.Text = "Save";
            this.saveCategoryButton.UseVisualStyleBackColor = true;
            this.saveCategoryButton.Click += new System.EventHandler(this.saveCategoryButton_Click);
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.Location = new System.Drawing.Point(137, 36);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Size = new System.Drawing.Size(321, 26);
            this.categoryNameTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // stockInButton
            // 
            this.stockInButton.Location = new System.Drawing.Point(361, 360);
            this.stockInButton.Name = "stockInButton";
            this.stockInButton.Size = new System.Drawing.Size(99, 23);
            this.stockInButton.TabIndex = 12;
            this.stockInButton.Text = "Stock In Ul";
            this.stockInButton.UseVisualStyleBackColor = true;
            this.stockInButton.Click += new System.EventHandler(this.stockInButton_Click);
            // 
            // CategorySetupUl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 462);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CategorySetupUl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategorySetupUl";
            this.Load += new System.EventHandler(this.CategorySetupUl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView categoryListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button saveCategoryButton;
        private System.Windows.Forms.TextBox categoryNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hiddenIdLabel;
        private System.Windows.Forms.Label hiddenDateLevel;
        private System.Windows.Forms.Button companyUlBotton;
        private System.Windows.Forms.Button ItemUlButton;
        private System.Windows.Forms.Button stockInButton;
    }
}

