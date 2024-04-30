using System.Text.Json.Serialization;

namespace MyTheFourth.Frontend.RebelRenegadesContext.Models;

public class PlanetSummary
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;

    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    [JsonPropertyName("slug")]
    public string? Slug { get; set; }
    [JsonPropertyName("gravity")]
    public string Gravity { get; set; } = null!;

    [JsonPropertyName("population")]
    public int Population { get; set; }

    [JsonPropertyName("climate")]
    public string Climate { get; set; } = null!;
}
