using System;

namespace XStoreApp.Models
{
    public class OrdersModel
    {
        public int orderNumber { get; set; }
        public DateTime orderDate { get; set; }
        public string orderStatus { get; set; }
    }
}
