using System.Text.Json.Serialization;

namespace MyTheFourth.Frontend.RebelRenegadesContext.Models;

public class PersonDetailsData : ResponseData<PersonDetails>
{
    [JsonPropertyName("personDetails")]
    public override PersonDetails? DataItem { get; set; }
}
