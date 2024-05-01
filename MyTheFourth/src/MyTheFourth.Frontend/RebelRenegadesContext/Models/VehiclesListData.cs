using System.Text.Json.Serialization;

namespace MyTheFourth.Frontend.RebelRenegadesContext.Models;

public class VehiclesListData : ResponseData<PagedData<VehicleSummary>>
{
    [JsonPropertyName("vehicles")]
    public override PagedData<VehicleSummary>? DataItem { get; set; }
}
