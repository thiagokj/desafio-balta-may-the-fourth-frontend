using System.Text.Json.Serialization;

namespace MyTheFourth.Frontend.RebelRenegadesContext.Models;

public class SpecieSummary
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;

    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    [JsonPropertyName("slug")]
    public string? Slug { get; set; }

    [JsonPropertyName("classification")]
    public string Classification { get; set; } = null!;

    [JsonPropertyName("designation")]
    public string Designation { get; set; } = null!;

    [JsonPropertyName("language")]
    public string Language { get; set; } = null!;
}
