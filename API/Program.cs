using API;
using RestSharp;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;


List<string> DigimonType= new List<string>();
RestClient client = new RestClient("https://digi-api.com/api/v1/");
int what = Convert.ToInt32(Console.ReadLine());
while(what < 1 || what > 3)
{
    what = Convert.ToInt32(Console.ReadLine());
}
if(what == 1)
{
    string digimonName = Console.ReadLine();
    RestRequest request = new RestRequest($"digimon/"+digimonName);

    RestResponse response = client.GetAsync(request).Result;
    Digimon d = JsonSerializer.Deserialize<Digimon>(response.Content);
    for (int i = 0; i < 1471; i++)
    {
    request = new RestRequest($"digimon/"+i);
        
    if (d.Name == digimonName)
    {
        i = 1472;
    }

    }
Console.WriteLine(d.Name);
Console.WriteLine(d.Types[0].Name);
// Console.WriteLine(d.Name);
// Console.WriteLine(d.Types[0].Name);
}
if(what == 2)
{
string digimonNumber = Console.ReadLine();

RestRequest request = new RestRequest($"digimon/"+digimonNumber);
RestResponse response = client.GetAsync(request).Result;
Digimon d = JsonSerializer.Deserialize<Digimon>(response.Content);
Console.WriteLine(d.Name);
Console.WriteLine(d.Types[0].Name);
}
if(what == 3)
{
    RestRequest request = new RestRequest($"digimon/");

    RestResponse response = client.GetAsync(request).Result;
    Digimon d = JsonSerializer.Deserialize<Digimon>(response.Content);
    string digimonType = Console.ReadLine();
    for (int i = 0; i < 1471; i++)
    {
    request = new RestRequest($"digimon/"+i);
    string DigimonName = d.Name;
    
    }
    for (int i = 0; i < 1471; i++){   
    if (d.Types[i].Name == digimonType)
    {
        DigimonType.Add(d.Name);
        Console.WriteLine(DigimonType[i]);
    }
    }
}
Console.ReadLine();