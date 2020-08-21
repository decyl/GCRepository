using Newtonsoft.Json;

namespace GC.WebApi.Tests.Entities
{
    [JsonObject]
    public class EmployeeResponse
    {
        [JsonProperty(PropertyName ="status")]
        public string Status { get; set; }

        [JsonProperty(PropertyName ="data")]
        public Employee Employee { get; set; }
    }
}
