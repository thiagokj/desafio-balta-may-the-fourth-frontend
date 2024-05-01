namespace MyTheFourth.Frontend.RebelRenegadesContext.Models;

public abstract class ResponseData<TData>()
{
    public abstract TData? DataItem { get; set; }
}
