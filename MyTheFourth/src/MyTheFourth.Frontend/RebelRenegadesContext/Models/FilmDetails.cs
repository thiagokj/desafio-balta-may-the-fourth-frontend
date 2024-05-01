using System.Text.Json.Serialization;

namespace MyTheFourth.Frontend.RebelRenegadesContext.Models;

public class FilmDetails : FilmSummary
{
    [JsonPropertyName("episodeId")]
    public int EpisodeId { get; set; }

    [JsonPropertyName("openingCrawl")]
    public string OpeningCrawl { get; set; } = null!;

    [JsonPropertyName("producer")]
    public string Producer { get; set; } = null!;

    [JsonPropertyName("created")]
    public DateTime Created { get; set; }

    [JsonPropertyName("edited")]
    public DateTime Edited { get; set; }

    [JsonPropertyName("speciesList")]
    public List<SpecieSummary> Species { get; set; } = new();

    [JsonPropertyName("starships")]
    public List<StarshipSummary> Starships { get; set; } = new();

    [JsonPropertyName("vehicles")]
    public List<VehicleSummary> Vehicles { get; set; } = new();

    [JsonPropertyName("characters")]
    public List<PersonSummary> Characters { get; set; } = new();

    [JsonPropertyName("planets")]
    public List<PlanetSummary> Planets { get; set; } = new();
}
