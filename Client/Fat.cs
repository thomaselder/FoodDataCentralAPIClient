using Newtonsoft.Json;

namespace FoodDataCentralAPI.Client
{
    public class Fat
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }
}