using System.Text.Json.Serialization;

namespace MyTheFourth.Frontend.RebelRenegadesContext.Models;

public class ApiDataResponse<TData>
{

    [JsonPropertyName("data")]
    public TData? Data { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("status")]
    public int Status { get; set; }

    [JsonPropertyName("isSuccess")]
    public bool IsSuccess { get; set; }

}
