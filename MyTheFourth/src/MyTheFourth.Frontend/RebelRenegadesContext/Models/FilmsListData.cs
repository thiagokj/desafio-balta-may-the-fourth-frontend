using System.Text.Json.Serialization;

namespace MyTheFourth.Frontend.RebelRenegadesContext.Models;

public class FilmsListData : ResponseData<PagedData<FilmSummary>>
{
    [JsonPropertyName("pagedSummaryFilms")]
    public override PagedData<FilmSummary>? DataItem { get; set; }
}
