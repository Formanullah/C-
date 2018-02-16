using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementApp.Mode
{
    class StockInQuantity
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int ItemId { get; set; }
        public int AvailableQuantity { get; set; }
        public int StockQuantity { get; set; }
        public int ReorderLevel { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get
        {
            return 0;
        }
        }
    }
}
