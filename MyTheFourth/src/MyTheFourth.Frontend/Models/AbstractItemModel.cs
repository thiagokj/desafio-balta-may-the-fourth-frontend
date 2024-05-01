namespace MyTheFourth.Frontend.Models;

public abstract class AbstractItemModel
{

    public string Id { get; set; } = null!;
    public string? ImgUrl { get; set; }
    public string? Slug { get; set; }
}
