namespace store.Service.Models
{
    public  class ProductForCreation
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public string category { get; set; }
        public decimal price { get; set; }
    }
}
