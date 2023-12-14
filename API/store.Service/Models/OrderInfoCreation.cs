using System;

namespace store.Service.Models
{
    public class OrderInfoCreation
    {
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }
    }
}
