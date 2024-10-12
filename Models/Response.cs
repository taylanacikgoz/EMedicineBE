using System.Text.Json.Serialization;

namespace EMedicineBE.Models
{
    public class Response
    {
        [JsonPropertyName("statusCode")]
        public int StatusCode { get; set; }

        [JsonPropertyName("statusMessage")]
        public string? StatusMessage { get; set; }

        [JsonPropertyName("allUsers")]
        public List<Users> listUsers { get; set; }

        [JsonPropertyName("user")]
        public Users user { get; set; }

        [JsonPropertyName("allMedicines")]
        public List<Medicines> listMedicines { get; set; }

        [JsonPropertyName("medicine")]
        public Medicines medicine { get; set; }

        [JsonPropertyName("carts")]
        public List<Cart> listCart { get; set; }

        [JsonPropertyName("allOrders")]
        public List<Orders> listOrders { get; set; }

        [JsonPropertyName("order")]
        public Orders order {  get; set; }

        [JsonPropertyName("orderItems")]
        public List<OrderItems> orderItems { get; set; }

        [JsonPropertyName("orderItem")]
        public OrderItems orderItem { get; set; }
    }
}
