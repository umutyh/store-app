using System.ComponentModel.DataAnnotations.Schema;

namespace store.Service.Models
{
    [Table("OrderDetails")]
    public class OrderDetailServiceDB
    {
        public int OrderNumber { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Sku { get; set; }
    }
}
