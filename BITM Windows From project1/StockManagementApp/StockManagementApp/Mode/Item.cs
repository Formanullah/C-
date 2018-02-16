using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementApp.Mode
{
    class Item
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int CompanyId { get; set; }
        public string ItemName { get; set; }
        public int Reorderlevel { get; set; }
        public DateTime Date { get; set; }
    }
}
