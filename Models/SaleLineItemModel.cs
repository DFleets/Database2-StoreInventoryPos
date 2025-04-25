using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreInventoryPos.Models
{
        public class SaleLineItemModel
        {
            public int Product_ID { get; set; }
            public string Name { get; set; }
            public int Qty { get; set; }
            public decimal UnitPrice { get; set; }

            public decimal SubTotal => Qty * UnitPrice;
        }

    
}
