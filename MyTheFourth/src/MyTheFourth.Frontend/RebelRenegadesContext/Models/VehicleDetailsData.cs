using System.Text.Json.Serialization;

namespace MyTheFourth.Frontend.RebelRenegadesContext.Models;

public class VehicleDetailsData : ResponseData<VehicleDetails>
{

    [JsonPropertyName("vehicleDetails")]
    public override VehicleDetails? DataItem { get; set; }
}
