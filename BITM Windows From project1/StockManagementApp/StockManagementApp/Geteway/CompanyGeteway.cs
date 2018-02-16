using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementApp.Mode;

namespace StockManagementApp.Geteway
{
    class CompanyGeteway
    {
        private string conString = @"Data Source=SAJIB;Initial Catalog=NewStockManagementDB;Integrated Security=True";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        private string query;

        public CompanyGeteway()
        {
            connection=new SqlConnection(conString);
        }

        public int SaveCompany(Company company)
        {
            query = "INSERT INTO Company(CompanyName,Date) VALUES('" + company.CompanyName + "','" + company.Date + "')";
            command=new SqlCommand(query,connection);
            connection.Open();
            int rowAffect = command.ExecuteNonQuery();
            connection.Close();
            return rowAffect;
        }
        public bool IsCompanyExist(Company company)
        {

            query = "SELECT * FROM Company WHERE CompanyName='" + company.CompanyName + "'";
            command = new SqlCommand();
            command.CommandText = query;
            command.Connection = connection;
            command.Connection.Open();
            reader = command.ExecuteReader();
            bool IsExist = reader.HasRows;
            reader.Close();
            connection.Close();
            return IsExist;
        }
        public List<Company> GetAllCompanies()
        {
            query = "SELECT * FROM Company";
            command = new SqlCommand(query, connection);
            connection.Open();
            reader = command.ExecuteReader();
            List<Company> companies = new List<Company>();
            while (reader.Read())
            {
                Company company=new Company();
                company.Id = (int)reader["Id"];
                company.CompanyName = (string) reader["CompanyName"];
                company.Date = (DateTime)reader["Date"];
               companies.Add(company);
            }
            reader.Close();
            connection.Close();
            return companies;
        }
    }
}
