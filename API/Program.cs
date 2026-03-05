using API;
using System.Net.Http.Json;
using System.Text.Json;

HttpClient client = new();
client.BaseAddress = new Uri("https://pokeapi.co/api/v2/");

HttpResponseMessage result = client.GetAsync("pokemon/garchomp").Result;

string pText = result.Content.ReadAsStringAsync().Result;

Pokemon p = result.Content.ReadFromJsonAsync<Pokemon>().Result;
Console.WriteLine($"Name = {p.name}\nWight = {p.weight}\nID = {p.id}\n");
Console.WriteLine($"{p.Sprites.Back_Default}");







// Pokemon charmander = new()
// {
//     Name = "Rizzler",
//     Type = "Fire",
//     Heath = 67
// };
// 
// string charmanData = JsonSerializer.Serialize(charmander);

// File.WriteAllText(fileName, charmanData);

// Console.WriteLine(File.ReadAllText(fileName).ToString());

Console.ReadLine();