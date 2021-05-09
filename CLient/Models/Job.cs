using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Models
{
    public class Job
    {
        [JsonPropertyName("jobtitle")]
        public string JobTitle { get; set; }
        [JsonPropertyName("salary")]
        public int Salary { get; set; }
    }
}