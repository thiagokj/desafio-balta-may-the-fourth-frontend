using System.Text.Json.Serialization;

namespace MyTheFourth.Frontend.RebelRenegadesContext.Models;

public class FilmDetailsData : ResponseData<FilmDetails>
{
    [JsonPropertyName("filmDetails")]
    public override FilmDetails? DataItem { get; set; }
}
