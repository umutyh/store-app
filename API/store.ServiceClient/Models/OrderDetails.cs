﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
//#nullable disable
using System;
using System.Collections.Generic;

namespace store.Database.Models
{
    public partial class OrderDetails
    {
        public int OrderNumber { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Sku { get; set; }
    }
}