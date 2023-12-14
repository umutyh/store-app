using System;
using System.Collections.Generic;
using System.Text;

namespace XStoreApp.Models
{
    public class OrderDetailsModel
    {
        public int OrderNumber { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Sku { get; set; }

    }
}
