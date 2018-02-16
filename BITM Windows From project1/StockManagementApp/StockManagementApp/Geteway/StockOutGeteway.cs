using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementApp.Mode;

namespace StockManagementApp.Geteway
{
    class StockOutGeteway
    {
        private string conString = @"Data Source=SAJIB;Initial Catalog=NewStockManagementDB;Integrated Security=True";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        private string query;

        public StockOutGeteway()
        {
            connection=new SqlConnection(conString);
        }
        
    }
}
