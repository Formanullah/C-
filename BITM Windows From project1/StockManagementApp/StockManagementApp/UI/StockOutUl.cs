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
    public partial class StockOutUl : Form
    {
        public StockOutUl()
        {
            InitializeComponent();
        }
        private CompanyManager companyManager=new CompanyManager();
        private ItemManeger itemManeger=new ItemManeger();
        private Company company;
        private StockInQuantityManager stockInQuantityManager=new StockInQuantityManager();
        private void addButton_Click(object sender, EventArgs e)
        {
            if ((int)companyNameComboBox.SelectedValue == -1)
            {
                MessageBox.Show("Please Select a Company");
                return;
            }
            if ((int)itemNameComboBox.SelectedValue == -1)
            {
                MessageBox.Show("Please Select a Item");
                return;
            }
           StockOut newStockOut=new StockOut();
            newStockOut.CompanyId = (int) companyNameComboBox.SelectedValue;
            newStockOut.ItemId = (int) itemNameComboBox.SelectedValue;
            int Quantity;
            if (int.TryParse(QuantityTextBox.Text, out Quantity))
            {
                if (Quantity > 0)
                {
                    int availableQuantity = Convert.ToInt32(availableQuantityTextBox.Text);
                    newStockOut.TakenQuantity = Quantity;
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
            newStockOut.InsertDate=DateTime.Now;
            //newStockOut.AvailableQuantity = Convert.ToInt32(availableQuantityTextBox.Text) - Convert.ToInt32(QuantityTextBox.Text);
            //newStockOut.ReorderLevel = Convert.ToInt32(reorderlevelTextBox.Text);
            //if (newStockOut.AvailableQuantity>newStockOut.TakenQuantity)
            //{
            //    int count = 0;
            //    List<StockOut> stockOuts = new List<StockOut>();
            //    stockOuts.Add(newStockOut);
            //    foreach (StockOut stockOut in stockOuts)
            //    {
            //        count++;
            //        ListViewItem item=new ListViewItem();
            //        item.Text = count.ToString();
            //        if (!list)
            //        {
                        
            //        }
            //    }
            //}
            companyNameComboBox.SelectedValue = -1;
            itemNameComboBox.SelectedValue = -1;
            reorderlevelTextBox.Clear();
            availableQuantityTextBox.Clear();
            QuantityTextBox.Clear();
        }

        private void StockOutUl_Load(object sender, EventArgs e)
        {
            company = new Company();
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
            itemNameComboBox.DataSource = items;
            itemNameComboBox.DisplayMember = "ItemName";
            itemNameComboBox.ValueMember = "Id";
        }

        private void itemNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item item = itemNameComboBox.SelectedItem as Item;
            reorderlevelTextBox.Text = item.Reorderlevel.ToString();
            StockInQuantity newQuantity = new StockInQuantity();
            int itemId;
            int.TryParse(itemNameComboBox.SelectedValue.ToString(), out itemId);
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

        private void sellButton_Click(object sender, EventArgs e)
        {

        }

        private void damageButton_Click(object sender, EventArgs e)
        {

        }

        private void lostButton_Click(object sender, EventArgs e)
        {

        }
    }
}
