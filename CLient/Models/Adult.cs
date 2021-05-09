using System.Text.Json.Serialization;

namespace Models {
public class Adult : Person {
    [JsonPropertyName("job")]
    public Job Job { get; set; }

    public string ToString()
    {
        return base.ToString() + " " + Job;
    }
}
}