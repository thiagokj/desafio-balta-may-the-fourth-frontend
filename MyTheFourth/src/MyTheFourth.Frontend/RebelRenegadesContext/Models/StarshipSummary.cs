using System.Text.Json.Serialization;

namespace MyTheFourth.Frontend.RebelRenegadesContext.Models;

public class StarshipSummary
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;

    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    [JsonPropertyName("slug")]
    public string? Slug { get; set; }

    [JsonPropertyName("model")]
    public string Model { get; set; } = null!;

    [JsonPropertyName("manufacturer")]
    public string Manufacturer { get; set; } = null!;
}
