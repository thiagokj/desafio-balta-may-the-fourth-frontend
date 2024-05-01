using System.Text.Json.Serialization;

namespace MyTheFourth.Frontend.RebelRenegadesContext.Models;

public class StarshipDetails : StarshipSummary
{
    [JsonPropertyName("starshipClass")]
    public string StarshipClass { get; set; } = null!;

    [JsonPropertyName("costInCredits")]
    public int CostInCredits { get; set; }

    [JsonPropertyName("length")]
    public int Length { get; set; }

    [JsonPropertyName("crew")]
    public int Crew { get; set; }

    [JsonPropertyName("passengers")]
    public int Passengers { get; set; }

    [JsonPropertyName("maxAtmospheringSpeed")]
    public int MaxAtmospheringSpeed { get; set; }

    [JsonPropertyName("hyperdriveRating")]
    public string HyperdriveRating { get; set; } = null!;

    [JsonPropertyName("mglt")]
    public string Mglt { get; set; } = null!;

    [JsonPropertyName("cargoCapacity")]
    public int CargoCapacity { get; set; }

    [JsonPropertyName("consumables")]
    public string Consumables { get; set; } = null!;

    [JsonPropertyName("created")]
    public DateTime Created { get; set; }

    [JsonPropertyName("edited")]
    public DateTime Edited { get; set; }

    [JsonPropertyName("films")]
    public List<FilmSummary> Films { get; set; } = new();
}

