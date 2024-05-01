using AutoMapper;
using MyTheFourth.Frontend.Models;
using MyTheFourth.Frontend.RebelRenegadesContext.Models;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<FilmSummary, MovieResume>();

        CreateMap<PersonSummary, CharacterResume>();

        CreateMap<PlanetSummary, PlanetResume>();

        CreateMap<VehicleSummary, VehicleResume>();

        CreateMap<StarshipSummary, StarshipResume>();

        CreateMap<FilmSummary, Movie>()
        .IncludeBase<FilmSummary, MovieResume>();

        CreateMap<FilmDetails, Movie>()
        .IncludeBase<FilmSummary, Movie>();

        CreateMap<PersonSummary, Character>()
        .IncludeBase<PersonSummary, CharacterResume>();

        CreateMap<PersonDetails, Character>()
        .IncludeBase<PersonSummary, Character>();

    }
}