using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using StockManagementApp.Mode;

namespace StockManagementApp.Geteway
{
    class ItemGeteway
    {
        private string conString = @"Data Source=SAJIB;Initial Catalog=NewStockManagementDB;Integrated Security=True";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        private string query;

        public ItemGeteway()
        {
            connection=new SqlConnection(conString);
        }

        public int SaveItem(Item item)
        {
            query = "INSERT INTO Item (CategoryId,CompanyId,ItemName,ReorderLevel,Date) VALUES('" + item.CategoryId +
                    "','" + item.CompanyId + "','" + item.ItemName + "','" + item.Reorderlevel + "','" + item.Date +
                    "')";
            command=new SqlCommand(query,connection);
            connection.Open();
            int rowAffect = command.ExecuteNonQuery();
            connection.Close();
            return rowAffect;
        }

        public bool IsItemExist(string item)
        {
            query = "SELECT * FROM Item WHERE ItemName='" +item + "'";
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

        public List<Item> GetCompanyItem(int id)
        {
            query = "SELECT * FROM Item WHERE CompanyId='" + id + "'";
            command=new SqlCommand(query,connection);
            connection.Open();
            reader = command.ExecuteReader();
            List<Item>items=new List<Item>();
            while (reader.Read())
            {
                Item item=new Item();
                item.Id = (int) reader["Id"];
                item.CategoryId = (int) reader["CategoryId"];
                item.CompanyId = (int) reader["CompanyId"];
                item.ItemName = (string) reader["ItemName"];
                item.Reorderlevel = (int) reader["ReorderLevel"];
                item.Date = (DateTime) reader["Date"];
                items.Add(item);
            }
            reader.Close();
            connection.Close();
            return items;
        }
        
    }
}
