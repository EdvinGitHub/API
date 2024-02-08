namespace API;

using System.Text.Json.Serialization;


public class Digimon

{
    [JsonPropertyName("name")]
    public string Name { get; set; }
  
    [JsonPropertyName("types")]
    public List<DigimonType> Types { get; set; }
    // public string Type { get; set; }
}

public class DigimonType {
    [JsonPropertyName("type")]
    public string Name { get; set; }
}   