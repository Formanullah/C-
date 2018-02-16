using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementApp.Mode;

namespace StockManagementApp.Geteway
{
    class StockInQuantityGeteway
    {
        private string conString = @"Data Source=SAJIB;Initial Catalog=NewStockManagementDB;Integrated Security=True";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        private string query;

        public StockInQuantityGeteway()
        {
            connection=new SqlConnection(conString);
        }
        public StockInQuantity GetAvailableQuantity(int itemId)
        {
            query = "SELECT Quantity,ReorderLevel FROM StockIn WHERE ItemId='" + itemId + "'";
            command=new SqlCommand(query,connection);
            connection.Open();
            StockInQuantity stockIn = null;
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                stockIn=new StockInQuantity();
                stockIn.AvailableQuantity = (int) reader["Quantity"];
                stockIn.ReorderLevel = (int)reader["ReorderLevel"];
            }
            reader.Close();
            connection.Close();
            return  stockIn;
        }

        public int SetStockIn(StockInQuantity stockInQuantity)
        {
            query = "INSERT INTO StockIn (CompanyId,ItemId,Quantity,ReorderLevel,Date) VALUES ('" +
                    stockInQuantity.CompanyId + "','" + stockInQuantity.ItemId + "','" + stockInQuantity.StockQuantity +
                    "','" + stockInQuantity.ReorderLevel + "','" + stockInQuantity.Date + "')";
            command=new SqlCommand(query,connection);
            connection.Open();
            int rowAffect = command.ExecuteNonQuery();
            connection.Close();
            return rowAffect;  
        }
        public bool IsItemExist(StockInQuantity stockInQuantity)
        {
            query = "SELECT * FROM StockIn WHERE CompanyId='" + stockInQuantity.CompanyId + "' AND ItemId='"+stockInQuantity.ItemId+"'";
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
    }
}
