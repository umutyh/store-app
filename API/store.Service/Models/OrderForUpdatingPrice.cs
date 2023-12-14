using System;
using System.Collections.Generic;
using System.Text;

namespace store.Service.Models
{
    public class OrderForUpdatingPriceAndQuantity
    {
        public int? Price { get; set; }
        public int? Quantity { get; set; }
    }
}
