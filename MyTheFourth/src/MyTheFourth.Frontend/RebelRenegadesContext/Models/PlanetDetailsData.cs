using System.Text.Json.Serialization;

namespace MyTheFourth.Frontend.RebelRenegadesContext.Models;

public class PlanetDetailsData : ResponseData<PlanetDetails>
{
    [JsonPropertyName("planet")]
    public PlanetDetails? DetailItem { get; set; }

    public override PlanetDetails? DataItem
    {
        get => DetailItem ?? SlugItem;
        set => DetailItem = value;
    }
    [JsonPropertyName("planetDetails")]
    public PlanetDetails? SlugItem { get; set; }
}
