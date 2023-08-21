using Newtonsoft.Json;

namespace FoodDataCentralAPI.Client
{
    public class Calories
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }
}