using Newtonsoft.Json;

namespace FoodDataCentralAPI.Client
{
    public class Carbohydrates
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }
}