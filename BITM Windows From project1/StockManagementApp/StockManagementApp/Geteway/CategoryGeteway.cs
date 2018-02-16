using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementApp.Mode;

namespace StockManagementApp.Geteway
{
    class CategoryGeteway
    {
        private string conString = @"Data Source=SAJIB;Initial Catalog=NewStockManagementDB;Integrated Security=True";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        private string query;

        public CategoryGeteway()
        {
            connection = new SqlConnection(conString);
        }

        public int SaveCategory(Category category)
        {
            query = "INSERT INTO Category (CategoryName,date) VALUES('"+category.CategoryName+"','"+category.Date+"')";
            command=new SqlCommand(query,connection);
            connection.Open();
            int rowAffect = command.ExecuteNonQuery();
            connection.Close();
            return rowAffect;
        }
        public bool IsCategoryExist(Category category)
        {

            query = "SELECT * FROM Category WHERE CategoryName='" + category.CategoryName + "'AND Id <>'"+category.Id+"'";
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

        public List<Category> GetAllCategories()
        {
            query = "SELECT * FROM Category";
            command=new SqlCommand(query,connection);
            connection.Open();
            reader = command.ExecuteReader();
            List<Category>categories=new List<Category>();
            while (reader.Read())
            {
                Category category=new Category();
                category.Id = (int) reader["Id"];
                category.CategoryName = (string) reader["CategoryName"];
                category.Date =  (DateTime) reader["Date"];
                category.Updated =   reader["Updated"];
                categories.Add(category);
            }
            reader.Close();
            connection.Close();
            return categories;
        }

        public int UpdateCategory(Category category)
        {
            query = "UPDATE Category SET CategoryName='"+category.CategoryName+"',Date='"+category.Updated+"',Updated='"+category.Date+"' WHERE Id='" + category.Id + "'";
            command=new SqlCommand(query,connection);
            connection.Open();
            int rowAffect = command.ExecuteNonQuery();
            connection.Close();
            return rowAffect;
        }
    }
}
