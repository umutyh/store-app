// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace XStoreApp.ServiceClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class OrderDetailCreation
    {
        /// <summary>
        /// Initializes a new instance of the OrderDetailCreation class.
        /// </summary>
        public OrderDetailCreation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OrderDetailCreation class.
        /// </summary>
        public OrderDetailCreation(int? orderNumber = default(int?), double? price = default(double?), int? quantity = default(int?), string sku = default(string))
        {
            OrderNumber = orderNumber;
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
