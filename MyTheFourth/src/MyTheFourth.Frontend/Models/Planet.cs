using MyTheFourth.Frontend.DevsResistenceContext.Models;

namespace MyTheFourth.Frontend.Models;

public class Planet : PlanetResume
{

    public string RotationPeriod { get; set; } = null!;

    public string OrbitalPeriod { get; set; } = null!;

    public string Diameter { get; set; } = null!;

    public string Climate { get; set; } = null!;

    public string Gravity { get; set; } = null!;

    public string Terrain { get; set; } = null!;

    public string SurfaceWater { get; set; } = null!;

    public string Population { get; set; } = null!;

    public List<CharacterResume> Characters { get; set; }

    public List<MovieResume> Movies { get; set; }

    public Planet()
    {
        Characters = new List<CharacterResume>();
        Movies = new List<MovieResume>();
    }

    public static Planet? ConvertPlanet(PlanetDataModel? result)
    {
        Planet planet = new Planet
        {
            Id = result.Id.ToString(),
            RotationPeriod = result.RotationPeriod,
            OrbitalPeriod = result.OrbitalPeriod,
            Diameter = result.Diameter,
            Climate = result.Climate,
            Gravity = result.Gravity,
            Terrain = result.Terrain,
            SurfaceWater = result.SurfaceWater,
            Population = result.Population,
            Characters = result.Characters?.Select(c => new CharacterResume
            {
                Id = c.Id.ToString(),
                Name = c.Name
            }).ToList() ?? new List<CharacterResume>(),
            Movies = result.Movies?.Select(m => new MovieResume
            {
                Id = m.Id.ToString(),
                Title = m.Title
            }).ToList() ?? new List<MovieResume>()
        };
        return planet;
    }
    
    //Mapeando como Response.
    public static PlanetListResponse ConvertListResponseCharacter(PlanetListResponse result)
    {
        if (result.Results != null)
        {
            var planet = result.Results.Select(item => new PlanetDataModel()
            {

                Id = item.Id,
                Name = item.Name,
                RotationPeriod = item.RotationPeriod,
                OrbitalPeriod = item.OrbitalPeriod,
                Diameter = item.Diameter,
                Climate = item.Climate,
                Gravity = item.Gravity,
                Terrain = item.Terrain,
                SurfaceWater = item.SurfaceWater,
                Population = item.Population,
                Characters = item
                    .Characters
                    .Select(c => new CharacterDataModel
                    {
                        Id = c.Id,
                        Name = c.Name
                    }).ToList(),
                Movies = item
                    .Movies
                    .Select(m => new MovieDataModel
                    {
                        Id = m.Id, 
                        Title = m.Title, 
                    }).ToList()
            }).ToList();
            
            var res = new PlanetListResponse();
            res.Count = result.Count;
            res.PageNumber = result.PageNumber;
            res.PageSize = result.PageSize;
            res.Results = planet;

            return res;
        }
        return new PlanetListResponse();
    }

    public static List<Planet> ConvertListPlanet(PlanetListResponse result)
    {
        if (result.Results != null)
        {
            var planet = result.Results.Select(item => new Planet
                {
                    Id = item.Id.ToString(),
                    Name = item.Name,
                    RotationPeriod = item.RotationPeriod,
                    OrbitalPeriod = item.OrbitalPeriod,
                    Diameter = item.Diameter,
                    Climate = item.Climate,
                    Gravity = item.Gravity,
                    Terrain = item.Terrain,
                    SurfaceWater = item.SurfaceWater,
                    Population = item.Population,
                    Characters = item.Characters.Select(c => new CharacterResume
                    {
                        Id = c.Id.ToString(),
                        Name = c.Name
                    }).ToList(),
                    Movies = item.Movies.Select(m => new MovieResume
                    {
                        Id = m.Id.ToString(),
                        Title = m.Title
                    }).ToList(),
                }).ToList();

            return planet;
        }
        return new List<Planet>();
    }
}