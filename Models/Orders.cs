using System.Text.Json.Serialization;

namespace EMedicineBE.Models
{
    public class Orders
    {
        [JsonPropertyName("id")]
        public int ID { get; set; }

        [JsonPropertyName ("userId")]
        public int UserId { get; set; }

        [JsonPropertyName("orderNo")]
        public string OrderNo { get; set; }

        [JsonPropertyName("orderTotal")]
        public decimal OrderTotal { get; set; }

        [JsonPropertyName("orderStatus")]
        public string OrderStatus { get; set; }
    }
}
