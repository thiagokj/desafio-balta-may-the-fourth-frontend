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


    public static Character ConvertCharacter(CharacterDataModel result)
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
            Name = result.Name,
            //ImgUrl = result.imgUrl,
            //Slug = result.Slug,
            Id = result.Id.ToString(),
            Planet = new PlanetResume
            {
                Name = result.Planet.Name,
                Id = result.Planet.Id.ToString(),
                //Slug = result.Planet.Slug,
                //ImgUrl = result.Planet.ImgUrl,
                
            },
            Movies = result.Movies.Select(movie => new MovieResume
            {
                Title = movie.Title,
                Id = movie.Id.ToString(),
                //Slug = movie.Slug,
                //ImgUrl = movie.ImgUrl,

            }).ToList()
        };
        return character;
    }


    public static CharacterListResponse ConvertListResponseCharacter(CharacterListResponse result)
    {
        if (result.Results != null)
        {
            var character = result.Results.Select(item => new CharacterDataModel
                {
                    Id = item.Id,
                    Name = item.Name,
                    Height = item.Height,
                    Weight = item.Weight,
                    HairColor = item.HairColor,
                    SkinColor = item.SkinColor,
                    EyeColor = item.EyeColor,
                    BirthYear = item.BirthYear,
                    Gender = item.Gender,
                    PlanetId = item.PlanetId,
                    Planet = new PlanetDataModel { Id = item.Planet.Id, Name = item.Planet.Name, },
                    Movies = item.Movies.Select(movie => new MovieDataModel { Id = movie.Id, Title = movie.Title, }).ToList()
                })
                .ToList();

            var res = new CharacterListResponse();
            res.Count = result.Count;
            res.PageNumber = result.PageNumber;
            res.PageSize = result.PageSize;
            res.Results = character;

            return res;
        }
        return new CharacterListResponse();
    }


    public static List<Character> ConvertListCharacter(CharacterListResponse result)
    {
        if (result.Results != null)
        {
            var character = result.Results.Select(item => new Character
                {
                    Height = item.Height,
                    Weight = item.Weight,
                    HairColor = item.HairColor,
                    SkinColor = item.SkinColor,
                    EyeColor = item.EyeColor,
                    BirthYear = item.BirthYear,
                    Gender = item.Gender,
                    Name = item.Name,
                    //Slug = item.Slug,
                    //ImgUrl = item.ImgUrl,
                    Id = item.Id.ToString(),
                    Planet = new PlanetResume
                    {
                        Id = item.Planet.Name,
                        //Slug = item.Planet.Slug,
                        //ImgUrl = item.Planet.ImgUrl,
                    },
                    Movies = item.Movies.Select(movie => new MovieResume
                    {
                        Title = movie.Title,
                        Id = movie.Id.ToString(),
                        //Slug = item.Planet.Slug,
                        //ImgUrl = item.Planet.ImgUrl,
                    }).ToList()
                })
                .ToList();

            return character;
        }
        return new List<Character>();
    }


}