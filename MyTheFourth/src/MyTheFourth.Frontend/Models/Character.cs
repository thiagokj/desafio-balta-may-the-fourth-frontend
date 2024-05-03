using MyTheFourth.Frontend.DevsResistenceContext.Models;

namespace MyTheFourth.Frontend.Models;

public class Character : CharacterResume
{

    public string Height { get; set; } = null!;

    public string Weight { get; set; } = null!;

    public string HairColor { get; set; } = null!;

    public string SkinColor { get; set; } = null!;

    public string EyeColor { get; set; } = null!;

    public string BirthYear { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public PlanetResume? Planet { get; set; } = null!;

    public List<MovieResume> Movies { get; set; }

    public Character()
    {
        Movies = new List<MovieResume>();
    }


    public static Character ConverterCharacter (CharacterDataModel result)
    {
        Character character = new Character
        {
            Height = result.Height, 
            Weight = result.Weight,
            HairColor = result.HairColor,
            SkinColor = result.SkinColor,
            EyeColor = result.EyeColor,
            BirthYear = result.BirthYear,
            Gender = result.Gender,
            Planet = new PlanetResume
            {
                Id = result.Planet.Name
            },
            Movies = result.Movies.Select(movie => new MovieResume
            {
                Title = movie.Title
            }).ToList()
        };
        return character;
    }
}