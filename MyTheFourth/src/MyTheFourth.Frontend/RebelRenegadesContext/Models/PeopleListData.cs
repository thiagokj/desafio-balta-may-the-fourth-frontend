using System.Text.Json.Serialization;

namespace MyTheFourth.Frontend.RebelRenegadesContext.Models;

public class PeopleListData : ResponseData<PagedData<PersonSummary>>
{
    [JsonPropertyName("pagedSummaryPeople")]
    public override PagedData<PersonSummary>? DataItem { get; set; }
}
