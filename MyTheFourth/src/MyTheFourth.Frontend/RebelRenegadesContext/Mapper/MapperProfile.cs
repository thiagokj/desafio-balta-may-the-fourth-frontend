using AutoMapper;
using MyTheFourth.Frontend.Models;
using MyTheFourth.Frontend.RebelRenegadesContext.Models;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<FilmSummary, MovieResume>();

        CreateMap<CharacterSummary, CharacterResume>();

        CreateMap<PlanetSummary, PlanetResume>();

        CreateMap<VehicleSummary, VehicleResume>();

        CreateMap<StarshipSummary, StarshipResume>();

        CreateMap<FilmSummary, Movie>()
        .IncludeBase<FilmSummary, MovieResume>();

        CreateMap<FilmDetails, Movie>()
        .IncludeBase<FilmSummary, Movie>();

    }
}