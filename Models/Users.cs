using System.Security.Principal;
using System;
using System.Text.Json.Serialization;

namespace EMedicineBE.Models
{
    public class Users
    {
        [JsonPropertyName("id")]
        public int ID { get; set; }

        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("fund")]
        public Decimal Fund { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("createdOn")]
        public DateTime CreatedOn { get; set; }
    }
}
