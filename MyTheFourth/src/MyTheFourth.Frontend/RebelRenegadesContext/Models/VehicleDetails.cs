using System.Text.Json.Serialization;

namespace MyTheFourth.Frontend.RebelRenegadesContext.Models;

public class VehicleDetails : VehicleSummary
{

    [JsonPropertyName("vehicleClass")]
    public string VehicleClass { get; set; } = null!;

    [JsonPropertyName("length")]
    public int Length { get; set; }

    [JsonPropertyName("costInCredits")]
    public int CostInCredits { get; set; }

    [JsonPropertyName("crew")]
    public string Crew { get; set; } = null!;

    [JsonPropertyName("passengers")]
    public int Passengers { get; set; }

    [JsonPropertyName("maxAtmospheringSpeed")]
    public int MaxAtmospheringSpeed { get; set; }

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