namespace FoodDataCentralAPI.Client
{
    public class FoodDataJsonDeserializer
    {
        public object DeserializeJsonResponseDynamic(string jsonResponse)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject(jsonResponse);
        }

        public FoodGetDOM DeserializeGetJsonResponse(string jsonResponse)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<FoodGetDOM>(jsonResponse);
        }

        /* public FoodSearchDOM DeserializeSearchJsonResponse(string jsonResponse)
         {
             return Newtonsoft.Json.JsonConvert.DeserializeObject<FoodSearchDOM>(jsonResponse);
         }*/
    }
}