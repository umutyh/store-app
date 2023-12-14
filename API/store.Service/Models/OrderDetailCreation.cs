namespace store.Service.Models
{
    public class OrderDetailCreation
    {
        public int OrderNumber { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Sku { get; set; }
    }
}
