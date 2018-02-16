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
    public partial class CompanyNameUl : Form
    {
        public CompanyNameUl()
        {
            InitializeComponent();
        }
        CompanyManager companyManager=new CompanyManager();
        private void saveCompanyNameButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(companyNameTextBox.Text))
            {
                MessageBox.Show("Please Enter a Company Name");
                return;
            }
            Company newCompany=new Company();
            newCompany.CompanyName = companyNameTextBox.Text;
            newCompany.Date=DateTime.Now;
            MessageBox.Show(companyManager.SaveCompany(newCompany));
            companyNameTextBox.Clear();
            PopulatedCopmanyListView();
        }

        private void CompanyNameUl_Load(object sender, EventArgs e)
        {
            PopulatedCopmanyListView();
        }

        private void PopulatedCopmanyListView()
        {
            companyListView.Items.Clear();
            int count = 0;
            List<Company> companies = companyManager.GetAllCompanies();
            foreach (Company company in companies)
            {
                count++;
                ListViewItem item = new ListViewItem();
                item.Text = count.ToString();
                item.SubItems.Add(company.CompanyName);
                companyListView.Items.Add(item);
            }
        }
    }
}
