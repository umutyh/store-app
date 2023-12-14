// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XStoreApp.ServiceClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class OrderDetailsCombined
    {
        /// <summary>
        /// Initializes a new instance of the OrderDetailsCombined class.
        /// </summary>
        public OrderDetailsCombined()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OrderDetailsCombined class.
        /// </summary>
        public OrderDetailsCombined(int? orderNumber = default(int?), System.DateTime? orderDate = default(System.DateTime?), string orderStatus = default(string), double? price = default(double?), int? quantity = default(int?), string sku = default(string))
        {
            OrderNumber = orderNumber;
            OrderDate = orderDate;
            OrderStatus = orderStatus;
            Price = price;
            Quantity = quantity;
            Sku = sku;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "orderNumber")]
        public int? OrderNumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "orderDate")]
        public System.DateTime? OrderDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "orderStatus")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "price")]
        public double? Price { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quantity")]
        public int? Quantity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public string Sku { get; set; }

    }
}