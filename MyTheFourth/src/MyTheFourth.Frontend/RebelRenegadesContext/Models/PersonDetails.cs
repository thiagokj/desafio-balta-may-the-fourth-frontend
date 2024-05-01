using System.Text.Json.Serialization;

namespace MyTheFourth.Frontend.RebelRenegadesContext.Models;

public class PersonDetails : PersonSummary
{
    [JsonPropertyName("eyeColor")]
    public string EyeColor { get; set; } = null!;

    [JsonPropertyName("hairColor")]
    public string HairColor { get; set; } = null!;

    [JsonPropertyName("height")]
    public int Height { get; set; }

    [JsonPropertyName("mass")]
    public string Mass { get; set; } = null!;

    [JsonPropertyName("skinColor")]
    public string SkinColor { get; set; } = null!;

    [JsonPropertyName("created")]
    public DateTime Created { get; set; }

    [JsonPropertyName("edited")]
    public DateTime Edited { get; set; }

    [JsonPropertyName("homeworld")]
    public PlanetSummary Homeworld { get; set; } = null!;

    [JsonPropertyName("films")]
    public List<FilmSummary> Films { get; set; } = new();
}
