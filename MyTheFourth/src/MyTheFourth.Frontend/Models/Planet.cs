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

    public static Planet? FromPlanetDataModel(PlanetDataModel? planetDataModel)
    {
        if (planetDataModel == null) return null;

        var planet = new Planet
        {
            RotationPeriod = planetDataModel.RotationPeriod,
            OrbitalPeriod = planetDataModel.OrbitalPeriod,
            Diameter = planetDataModel.Diameter,
            Climate = planetDataModel.Climate,
            Gravity = planetDataModel.Gravity,
            Terrain = planetDataModel.Terrain,
            SurfaceWater = planetDataModel.SurfaceWater,
            Population = planetDataModel.Population,
            Characters = planetDataModel.Characters?.Select(c => new CharacterResume
            {
                Name = c.Name 
            }).ToList() ?? new List<CharacterResume>(),
            Movies = planetDataModel.Movies?.Select(m => new MovieResume
            {
                Title = m.Title 
            }).ToList() ?? new List<MovieResume>()
        };

        return planet;
    }
}