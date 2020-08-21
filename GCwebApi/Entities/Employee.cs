using Newtonsoft.Json;

namespace GC.WebApi.Tests.Entities
{
    [JsonObject]
    public class Employee
    {
        [JsonProperty(PropertyName = "id")]     
        public int Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "salary")]
        public decimal Salary { get; set; }

        [JsonProperty(PropertyName = "age")]
        public int Age { get; set; }

    }
}
