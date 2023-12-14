using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace store.Service.Models
{
    [Table("Orders")]
    public class OrderInfoServiceDB
    {
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }
    }
}
