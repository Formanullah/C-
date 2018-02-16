using System;
using System.Collections.Generic;
using System.Windows.Forms;
using StockManagementApp.Manager;
using StockManagementApp.Mode;

namespace StockManagementApp.UI
{
    public partial class CategorySetupUl : Form
    {
        private CategoryManager categoryManager=new CategoryManager();
        
        public CategorySetupUl()
        {
            InitializeComponent();
        }

        private void saveCategoryButton_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(categoryNameTextBox.Text))
            {
                MessageBox.Show("Please Enter a category name");
                return;
            }
            Category newCategory=new Category();
            newCategory.CategoryName = categoryNameTextBox.Text;
            newCategory.Date=DateTime.Now;
            if (saveCategoryButton.Text=="Save")
            {
                MessageBox.Show(categoryManager.SaveCategory(newCategory));
                categoryNameTextBox.Clear();
            }
            else
            {
                newCategory.Id = Convert.ToInt32(hiddenIdLabel.Text);
                newCategory.Updated = Convert.ToDateTime(hiddenDateLevel.Text);
                MessageBox.Show(categoryManager.UpdateCategory(newCategory));
                saveCategoryButton.Text = "Save";
                categoryNameTextBox.Clear();
            }
            CategoryListView();
        }

        private void categoryListView_DoubleClick(object sender, EventArgs e)
        {
            Category category=categoryListView.SelectedItems[0].Tag as Category;
            categoryNameTextBox.Text = category.CategoryName;
            hiddenIdLabel.Text = category.Id.ToString();
            hiddenDateLevel.Text = category.Date.ToString();
            saveCategoryButton.Text = "Edit";

        }

        private void CategorySetupUl_Load(object sender, EventArgs e)
        {
            CategoryListView();
        }

        private void CategoryListView()
        {
            int count = 0;
            categoryListView.Items.Clear();
            List<Category> categories = categoryManager.GetAllCategories();
            foreach (Category category in categories)
            {
                count++;
                ListViewItem item = new ListViewItem();
                item.Text = count.ToString();
                item.SubItems.Add(category.CategoryName);
                item.Tag = category;
                categoryListView.Items.Add(item);
            }
        }

        private void companyUlBotton_Click(object sender, EventArgs e)
        {
          CompanyNameUl companyNameUl=new CompanyNameUl();
            this.Hide();
            companyNameUl.Show();
        }

        private void ItemUlButton_Click(object sender, EventArgs e)
        {
            SetupItemUl setupItemUl=new SetupItemUl();
            this.Hide();
            setupItemUl.Show();
        }

        private void stockInButton_Click(object sender, EventArgs e)
        {
            StockInFrom stockInFrom=new StockInFrom();
            this.Hide();
            stockInFrom.Show();
        }
    }
}
