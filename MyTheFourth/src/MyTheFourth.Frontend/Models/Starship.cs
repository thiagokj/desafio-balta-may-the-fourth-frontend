using MyTheFourth.Frontend.DevsResistenceContext.Models;

namespace MyTheFourth.Frontend.Models;
public class Starship : StarshipResume
{
    public string Model { get; set; } = null!;
    public string Manufacturer { get; set; } = null!;
    public string CostInCredits { get; set; } = null!;
    public string Length { get; set; } = null!;
    public string MaxSpeed { get; set; } = null!;
    public string Crew { get; set; } = null!;
    public string Passengers { get; set; } = null!;
    public string CargoCapacity { get; set; } = null!;
    public string HyperdriveRating { get; set; } = null!;
    public string Mglt { get; set; } = null!;
    public string Consumables { get; set; } = null!;
    public string Class { get; set; } = null!;
    public IEnumerable<MovieResume> Movies { get; set; }
    public Starship()
    {
        Movies = new List<MovieResume>();
    }
    public static Starship ConvertStarship(StarshipDataModel result)
    {
        Starship character = new Starship
        {
            Model = result.Model,
            Manufacturer = result.Manufacturer,
            CostInCredits = result.CostInCredits,
            Length = result.Length,
            MaxSpeed = result.MaxSpeed,
            Crew = result.Crew,
            Passengers = result.Passengers,
            HyperdriveRating = result.HyperdriveRating,
            CargoCapacity = result.CargoCapacity,
            Mglt = result.Mglt,
            Consumables = result.Consumables,
            Class = result.Class,
            ImgUrl = string.Empty,
            Slug = string.Empty,
            Id = result.Id.ToString(),
            Name = result.Name,
            Movies = result.Movies.Select(movie => new MovieResume
            {
                Title = movie.Title,
                Id = movie.Id.ToString(),
                ImgUrl = string.Empty,
                Slug = string.Empty,

            }).ToList()
        };
        return character;
    }
    public static List<Starship> ConvertListStarship(StarshipListResponse result)
    {
        if (result.Results != null)
        {
            var starship = result.Results.Select(item => new Starship
            {
                Model = item.Model,
                Manufacturer = item.Manufacturer,
                CostInCredits = item.CostInCredits,
                Length = item.Length,
                MaxSpeed = item.MaxSpeed,
                Crew = item.Crew,
                Passengers = item.Passengers,
                HyperdriveRating = item.HyperdriveRating,
                CargoCapacity = item.CargoCapacity,
                Mglt = item.Mglt,
                Consumables = item.Consumables,
                Class = item.Class,
                //ImgUrl = string.Empty,
                //Slug = string.Empty,
                Id = item.Id.ToString(),
                Name = item.Name,
                Movies = item.Movies.Select(movie => new MovieResume
                {
                    Title = movie.Title,
                    Id = movie.Id.ToString(),
                    //ImgUrl = string.Empty,
                    //Slug = string.Empty,

                }).ToList()
            }).ToList();
            return starship;
        }
        return new List<Starship>();
    }
}