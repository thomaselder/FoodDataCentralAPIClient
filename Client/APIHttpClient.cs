namespace FoodDataCentralAPI.Client
{
    public class APIHttpClient
    {
        private HttpClient _client;

        public APIHttpClient()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://api.nal.usda.gov/fdc/v1/");
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders.Add("X-Api-Key", APIKey.FOOD_DATA_CENTRAL_API_KEY);
        }

        public async Task<string> SearchFood(string searchTerm)
        {
            var response = await _client.GetAsync($"foods/search?query={searchTerm}");
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Success!");
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                return $"Error: {response.StatusCode}";
            }
        }

        public async Task<string> GetFood(int fdcId)
        {
            var response = await _client.GetAsync($"food/{fdcId}");
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Success!");
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                return $"Error: {response.StatusCode}";
            }
        }
    }
}