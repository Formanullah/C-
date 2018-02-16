using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementApp.Manager;
using StockManagementApp.Mode;

namespace StockManagementApp.UI
{
    public partial class SetupItemUl : Form
    {
        public SetupItemUl()
        {
            InitializeComponent();
        }
        private ItemManeger itemManeger=new ItemManeger();
        private CategoryManager itemCategoryManager=new CategoryManager();
        private CompanyManager itemCompanyManager=new CompanyManager();
        private int reorderAmount;

        private void saveItemButton_Click(object sender, EventArgs e)
        {
            if ((int)categoryComboBox.SelectedValue==-1)
            {
                MessageBox.Show("Please Select a Category");
                return;
            }
            if ((int)companyNameComboBox.SelectedValue== -1)
            {
                MessageBox.Show("Please Select a Company");
                return;
            }
            if (string.IsNullOrEmpty(itemNameTextBox.Text))
            {
                MessageBox.Show("Please Enter a Item Name");
                return;
            }
            Item newItem=new Item();
            newItem.CategoryId = (int) categoryComboBox.SelectedValue;
            newItem.CompanyId = (int) companyNameComboBox.SelectedValue;
            newItem.ItemName = itemNameTextBox.Text;
            if (int.TryParse(reorderlevelTextBox.Text,out reorderAmount ))
            {
                reorderAmount = Convert.ToInt32(reorderlevelTextBox.Text);
            }
            else
            {
                reorderAmount = 0;
            }
            newItem.Reorderlevel = reorderAmount;
            newItem.Date=DateTime.Now;
            MessageBox.Show(itemManeger.SaveItem(newItem));

        }

        private void SetupItemUl_Load(object sender, EventArgs e)
        {
            Category defaultCategory=new Category();
            defaultCategory.CategoryName = "--Select--";
            defaultCategory.Id = -1;
            List<Category>categories=new List<Category>();
            categories.Add(defaultCategory);
            categories.AddRange(itemCategoryManager.GetAllCategories());
            categoryComboBox.DisplayMember = "CategoryName";
            categoryComboBox.ValueMember = "Id";
            categoryComboBox.DataSource = categories;
            Company defaultCompany=new Company();
            defaultCompany.CompanyName = "--Select--";
            defaultCompany.Id = -1;
            List<Company>companies=new List<Company>();
            companies.Add(defaultCompany);
            companies.AddRange(itemCompanyManager.GetAllCompanies());
            companyNameComboBox.DisplayMember = "CompanyName";
            companyNameComboBox.ValueMember = "Id";
            companyNameComboBox.DataSource = companies;
        }
    }
}
