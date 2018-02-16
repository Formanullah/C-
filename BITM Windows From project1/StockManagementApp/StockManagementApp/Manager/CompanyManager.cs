using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementApp.Geteway;
using StockManagementApp.Mode;

namespace StockManagementApp.Manager
{
    class CompanyManager
    {
        private CompanyGeteway companyGeteway=new CompanyGeteway();

        public string SaveCompany(Company company)
        {
            if (companyGeteway.IsCompanyExist(company))
            {
                return "Company Name Already Exist";
            }
            int rowAffect = companyGeteway.SaveCompany(company);
            if (rowAffect > 0)
            {
                return "Save Successfully";
            }
            return "Save Failed";
        }

        public List<Company> GetAllCompanies()
        {
            return companyGeteway.GetAllCompanies();
        }
    }
}
