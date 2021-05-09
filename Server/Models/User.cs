using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Models
{
    public class User
    {
        [Key, MinLength(5)] 
        [JsonPropertyName("username")]
        public string Username { get; set; }
        
        [Required, MinLength(7)]
        [JsonPropertyName("password")]
        public string Password { get; set; }
        [JsonPropertyName("role")]
        public string Role { get; set; }
        [JsonPropertyName("age")]
        public int Age { get; set; }

        public string ToString()
        {
            return Username + " " + Role + " " + Age;
        }
    }
}