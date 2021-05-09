using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;

namespace Models {
public class Family {
    [Required]
    [JsonPropertyName("city")]
    public string City { get; set; }
    [Required]
    [JsonPropertyName("floor")]
    public string Floor { get; set; }
    [Required]
    [JsonPropertyName("streetname")]
    public string StreetName { get; set; }
    [Required]
    [JsonPropertyName("housenumber")]
    public int HouseNumber { get; set; }
    
    public string Address()
    {
        return City + StreetName + HouseNumber + Floor;
    }

    public ICollection<Adult> Adults { get; set; }
    public ICollection<Child> Children{ get; set; }

    public Family() {
        Adults = new List<Adult>();
        Children = new List<Child>();
    }

    public string ToString()
    {
        return City + " " + StreetName + " " + HouseNumber + " " + Floor + "Adults: " + Adults.ToList() + "\n " +
               "Children: " + Children.ToList();
    }
}


}