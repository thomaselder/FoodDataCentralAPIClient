using Newtonsoft.Json;

namespace FoodDataCentralAPI.Client
{
    public class Protein
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }
}