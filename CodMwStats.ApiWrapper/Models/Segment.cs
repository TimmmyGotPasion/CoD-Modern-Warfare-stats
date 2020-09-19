using Newtonsoft.Json;

namespace CodMwStats.ApiWrapper.Models
{
    public class Segment
    {
        [JsonProperty("stats")]
        public Stats Stats { get; set; }
    }
}