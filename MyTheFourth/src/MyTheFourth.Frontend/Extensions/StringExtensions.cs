using System.Globalization;

namespace MyTheFourth.Frontend.Extensions;

public static class StringExtensions
{

    public static DateTime DateToPtBr(this string dateString)
    {
        var formattedDate = dateString.Replace("-", "/");
        var culture = CultureInfo.CreateSpecificCulture("pt-BR");
        return DateTime.Parse(formattedDate, culture);
    }
}