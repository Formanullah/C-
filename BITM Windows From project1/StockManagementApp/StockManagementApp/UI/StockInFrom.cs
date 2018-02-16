using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementApp.Geteway;
using StockManagementApp.Manager;
using StockManagementApp.Mode;

namespace StockManagementApp.UI
{
    public partial class StockInFrom : Form
    {
        public StockInFrom()
        {
            InitializeComponent();
        }
       private ItemManeger itemManeger=new ItemManeger();
        private StockInQuantityManager stockInQuantityManager=new StockInQuantityManager();
        private CompanyManager companyManager=new CompanyManager();
        private Company company;

        private void saveQuantityButton_Click(object sender, EventArgs e)
        {
            if ((int)companyNameComboBox.SelectedValue== -1)
            {
                MessageBox.Show("Please Select a Company");
                return;
            }
            if ((int)itemComboBox.SelectedValue == -1)
            {
                MessageBox.Show("Please Select a Item");
                return;
            }
            StockInQuantity stockInQuantity=new StockInQuantity();
            stockInQuantity.CompanyId = (int) companyNameComboBox.SelectedValue;
            stockInQuantity.ItemId = (int) itemComboBox.SelectedValue;
            stockInQuantity.ReorderLevel = Convert.ToInt32(reorderlevelTextBox.Text);
            stockInQuantity.AvailableQuantity = Convert.ToInt32(availableQuantityTextBox.Text);
            int Quantity;
            if (int.TryParse(stockInQuantityTextBox.Text, out Quantity))
            {
                if (Quantity > 0)
                {
                    int availableQuantity = Convert.ToInt32(availableQuantityTextBox.Text);
                    stockInQuantity.StockQuantity = Quantity+availableQuantity;
                }
                else
                {
                    MessageBox.Show("Please Enter Amount for Stock");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Invalid Value");
                return;
            }
            stockInQuantity.Date=DateTime.Now;
            MessageBox.Show(stockInQuantityManager.SetStockIn(stockInQuantity));
            companyNameComboBox.SelectedValue = -1;
            itemComboBox.SelectedValue = -1;
            reorderlevelTextBox.Clear();
            availableQuantityTextBox.Clear();
            stockInQuantityTextBox.Clear();

        }

        private void StockInFrom_Load(object sender, EventArgs e)
        {
            company=new Company();
            company.CompanyName = "--Select--";
            company.Id = -1;
            List<Company> companies = new List<Company>();
            companies.Add(company);
            companies.AddRange(companyManager.GetAllCompanies());
            companyNameComboBox.DisplayMember = "CompanyName";
            companyNameComboBox.ValueMember = "Id";
            companyNameComboBox.DataSource = companies;

        }

        private void companyNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            company = new Company();
            company.Id = (int)companyNameComboBox.SelectedValue;
            Item defultItem = new Item();
            defultItem.ItemName = "--Select--";
            defultItem.Id = -1;
            List<Item> items = new List<Item>();
            items.Add(defultItem);
            items.AddRange(itemManeger.GetCompanyItem(company.Id));
            itemComboBox.DataSource = items;
            itemComboBox.DisplayMember = "ItemName";
            itemComboBox.ValueMember = "Id";
        }

        private void itemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Item item=itemComboBox.SelectedItem as Item;
            reorderlevelTextBox.Text = item.Reorderlevel.ToString();
            StockInQuantity newQuantity = new StockInQuantity();
            int itemId;
            int.TryParse(itemComboBox.SelectedValue.ToString(), out itemId);
            StockInQuantity stockIn = stockInQuantityManager.GetAvailableQuantity(itemId);
            if (stockIn != null)
            {
                availableQuantityTextBox.Text = stockIn.AvailableQuantity.ToString();
            }
            else
            {
                availableQuantityTextBox.Text = newQuantity.Quantity.ToString();
            }


        }
    }
}
