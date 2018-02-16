using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementApp.Geteway;
using StockManagementApp.Mode;

namespace StockManagementApp.Manager
{
    class CategoryManager
    {
        private CategoryGeteway categoryGeteway=new CategoryGeteway();

        public string SaveCategory(Category category)
        {
            if (categoryGeteway.IsCategoryExist(category))
            {
                return "Category Name already Exist";
            }
            int rowAffect = categoryGeteway.SaveCategory(category);
            if (rowAffect > 0)
            {
                return "Save Successfully";
            }
            return "Save Failed";
        }

        public List<Category> GetAllCategories()
        {
            return categoryGeteway.GetAllCategories();
        }

        public string UpdateCategory(Category category)
        {
            if (categoryGeteway.IsCategoryExist(category))
            {
                return "Category Name is Exist";
            }
            int rowAffect = categoryGeteway.UpdateCategory(category);
            if (rowAffect > 0)
            {
                return "Updated Successfully";
            }
            return "Updated Failed";
        }
    }
}
