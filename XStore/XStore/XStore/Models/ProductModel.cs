using System;

namespace XStoreApp.Models
{
    public class ProductModel
    {
        public int productId { get; set; }
        public decimal Price { get; set; }
        public string productName { get; set; }
        public string productCategory { get; set; }
        public string productDescription { get; set; }
        public int productQuantity { get; set; }
        public string Manufacturer { get; set; }
        public DateTime releaseDate { get; set; }
        public Boolean availabilty { get; set; }
        public int rating { get; set; }

    }
}
