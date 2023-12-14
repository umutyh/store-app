using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace store.Domain.Models
{
    [Table("Table_1")]
    public class Products
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public string category { get; set; }
        public string productDescription { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }
        public string manufacturer { get; set; }
        public DateTime releaseDate { get; set; }
        public bool availability { get; set; }
        public decimal rating { get; set; }
    }
}
