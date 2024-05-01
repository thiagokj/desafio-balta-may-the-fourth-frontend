using System.Text.Json.Serialization;

namespace MyTheFourth.Frontend.RebelRenegadesContext.Models;

public class StarshipDetailsData : ResponseData<StarshipDetails>
{

    [JsonPropertyName("starshipDetails")]
    public override StarshipDetails? DataItem { get; set; }
}
