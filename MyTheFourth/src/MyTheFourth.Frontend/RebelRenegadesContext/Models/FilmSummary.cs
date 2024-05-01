using System.Text.Json.Serialization;

namespace MyTheFourth.Frontend.RebelRenegadesContext.Models;

public class FilmSummary
{
    [JsonPropertyName("id")]
    public string Id { get; set; } = null!;

    [JsonPropertyName("title")]
    public string Title { get; set; } = null!;

    [JsonPropertyName("slug")]
    public string? Slug { get; set; }

    [JsonPropertyName("director")]
    public string Director { get; set; } = null!;

    [JsonPropertyName("releaseDate")]
    public DateTime ReleaseDate { get; set; }
}
