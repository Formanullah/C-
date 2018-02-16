using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementApp.Geteway;
using StockManagementApp.Mode;

namespace StockManagementApp.Manager
{
    class ItemManeger
    {
        ItemGeteway itemGeteway=new ItemGeteway();
        
        public string SaveItem(Item item)
        {
            if (itemGeteway.IsItemExist(item.ItemName))
            {
                return "Item Name Already Exist";
            }
            int rowAffect = itemGeteway.SaveItem(item);
            if (rowAffect>0)
            {
                return "Save Successfully";
            }
            return "Save Failed";
        }

        public List<Item> GetCompanyItem(int id)
        {
            return itemGeteway.GetCompanyItem(id);
        }

    }
}
