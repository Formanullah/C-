using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementApp.Mode
{
    class StockOut
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int ItemId { get; set; }
        public int TakenQuantity { get; set; }
        public string SellItem { get; set; }
        public string DemageItem { get; set; }
        public string LostItem { get; set; }
        public DateTime InsertDate { get; set; }
        public int AvailableQuantity { get; set; }
        public int ReorderLevel { get; set; }
    }
}
