using System.Text.Json.Serialization;

namespace EMedicineBE.Models
{
    public class OrderItems
    {
        [JsonPropertyName("id")]
        public int ID { get; set; }

        [JsonPropertyName ("orderId")]
        public int OrderID { get; set; }

        [JsonPropertyName("medicineId")]
        public int MedicineId { get; set; }

        [JsonPropertyName("unitPrice")]
        public decimal UnitPrice { get; set; }

        [JsonPropertyName("discount")]
        public decimal Discount { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("totalPrice")]
        public decimal TotalPrice { get; set; }
    }
}
