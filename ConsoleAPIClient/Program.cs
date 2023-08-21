// See https://aka.ms/new-console-template for more information
using FoodDataCentralAPI.Client;

var client = new APIHttpClient();
var deserializer = new FoodDataJsonDeserializer();
var filePath = Path.Combine(System.AppContext.BaseDirectory, "searchFoodResult.json");
Console.WriteLine($"Making request to get food with search term(s)");
var response = await client.GetFood(2015943);
FoodGetDOM deserializedResponse = deserializer.DeserializeGetJsonResponse(response);

Console.WriteLine($"Response deserialized.");
//Console.WriteLine($"Writing response to {filePath}");
//var writer = new StreamWriter(new FileStream(filePath, FileMode.Create));
//writer.Write(response);
//writer.Close();
//Console.WriteLine($"Done writing response to {filePath}");