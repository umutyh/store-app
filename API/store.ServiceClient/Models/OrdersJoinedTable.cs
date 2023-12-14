using System;
using System.Collections.Generic;
using System.Text;

namespace store.Database.Models
{
    public partial class OrdersJoinedTable
    {
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Sku { get; set; }
    }
}
