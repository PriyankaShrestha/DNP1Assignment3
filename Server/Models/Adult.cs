using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Transactions;

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