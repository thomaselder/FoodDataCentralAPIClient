using System.Text.Json.Serialization;

namespace FoodDataCentralAPI.Client
{
    public class FoodGetDOM
    {
        private double _servingSize;

        [JsonPropertyName("fdcId")]
        public int FdcId { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("servingSize")]
        public double ServingSize
        {
            get => _servingSize;
            set
            {
                _servingSize = value;
            }
        }

        [JsonPropertyName("servingSizeUnit")]
        public string ServingSizeUnit { get; set; }

        [JsonPropertyName("labelNutrients")]
        public LabelNutrients? LabelNutrients { get; set; }
    }
}