using System.Text.Json.Serialization;

namespace MyTheFourth.Frontend.RebelRenegadesContext.Models;

public class PlanetDetails : PlanetSummary
{

    [JsonPropertyName("diameter")]
    public int Diameter { get; set; }

    [JsonPropertyName("rotationPeriod")]
    public int RotationPeriod { get; set; }

    [JsonPropertyName("orbitalPeriod")]
    public int OrbitalPeriod { get; set; }

    [JsonPropertyName("terrain")]
    public string Terrain { get; set; } = null!;

    [JsonPropertyName("surfaceWater")]
    public string SurfaceWater { get; set; } = null!;

    [JsonPropertyName("created")]
    public DateTime Created { get; set; }

    [JsonPropertyName("edited")]
    public DateTime Edited { get; set; }

    [JsonPropertyName("residents")]
    public List<PersonSummary> Residents { get; set; } = new();

    [JsonPropertyName("films")]
    public List<FilmSummary> Films { get; set; } = new();
}