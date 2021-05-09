using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Models {
public class Person {
    [JsonPropertyName("cprnumber")]
    public int CPRNumber { get; set; }
    
    [Required]
    [JsonPropertyName("firstname")]
    public string FirstName { get; set; }
    
    [Required]
    [JsonPropertyName("lastname")]
    public string LastName { get; set; }
    [JsonPropertyName("haircolor")]
    public string HairColor { get; set; }
    [JsonPropertyName("eyecolor")]
    public string EyeColor { get; set; }
    
    [Required, Range(1,100)]
    [JsonPropertyName("age")]
    public int Age { get; set; }
    [JsonPropertyName("weight")]
    public float Weight { get; set; }
    [JsonPropertyName("height")]
    public int Height { get; set; }
    [JsonPropertyName("sex")]
    public string Sex { get; set; }
    public string ToString()
    {
        return CPRNumber + " " + FirstName + " " + LastName + " " + HairColor + " " + EyeColor + " "
               + Age + " " + Weight + " " + Height + " " + Sex;
    }
}


}