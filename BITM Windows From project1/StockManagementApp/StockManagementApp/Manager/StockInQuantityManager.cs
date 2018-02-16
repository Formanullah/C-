using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementApp.Geteway;
using StockManagementApp.Mode;

namespace StockManagementApp.Manager
{
    class StockInQuantityManager
    {
        private StockInQuantityGeteway stockInQuantityGeteway=new StockInQuantityGeteway();

        public StockInQuantity GetAvailableQuantity(int itemId)
        {
            return stockInQuantityGeteway.GetAvailableQuantity(itemId);
        }

        public string SetStockIn(StockInQuantity stockInQuantity)
        {
            if (stockInQuantityGeteway.IsItemExist(stockInQuantity))
            {
                stockInQuantityGeteway.SetStockIn(stockInQuantity);
                return "Update Successfully";
            }
            
            int rowAffect = stockInQuantityGeteway.SetStockIn(stockInQuantity);
            if (rowAffect > 0)
            {
                return "Store Successfully";
            }
            return "Store Failed";
        }

    }
}
