using System;

namespace store.Service.Models
{
    public class OrderDetailsCombined
    {
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Sku { get; set; }
    }
}
