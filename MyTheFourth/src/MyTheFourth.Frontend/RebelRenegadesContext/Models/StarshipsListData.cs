using System.Text.Json.Serialization;

namespace MyTheFourth.Frontend.RebelRenegadesContext.Models;

public class StarshipsListData : ResponseData<PagedData<StarshipSummary>>
{
    [JsonPropertyName("starships")]
    public override PagedData<StarshipSummary>? DataItem { get; set; }
}
