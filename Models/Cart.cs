using System.Text.Json.Serialization;

namespace EMedicineBE.Models
{
    public class Cart
    {
        [JsonPropertyName("id")]
        public int ID { get; set; }

        [JsonPropertyName ("userId")]
        public int UserId { get; set; }

        [JsonPropertyName ("unitPrice")]
        public decimal UnitPrice { get; set; }

        [JsonPropertyName("discount")]
        public decimal Discount { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("totalPrice")]
        public decimal TotalPrice { get; set; }
    }
}
