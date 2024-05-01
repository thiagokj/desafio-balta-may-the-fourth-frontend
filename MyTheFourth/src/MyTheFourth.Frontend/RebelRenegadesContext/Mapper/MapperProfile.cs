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
        .IncludeBase<PersonSummary, Character>()
        .ForMember(dest => dest.Movies, opt => opt.MapFrom(src => src.Films))
        .ForMember(dest => dest.Planet, opt => opt.MapFrom(src => src.Homeworld));

        CreateMap<PlanetSummary, Planet>()
        .IncludeBase<PlanetSummary, PlanetResume>();

        CreateMap<PlanetDetails, Planet>()
        .IncludeBase<PlanetSummary, Planet>()
        .ForMember(dest => dest.Characters, opt => opt.MapFrom(src => src.Residents))
        .ForMember(dest => dest.Movies, opt => opt.MapFrom(src => src.Films));

        CreateMap<VehicleSummary, Vehicle>()
        .IncludeBase<VehicleSummary, VehicleResume>();

        CreateMap<VehicleDetails, Vehicle>()
        .IncludeBase<VehicleSummary, Vehicle>()
        .ForMember(dest => dest.Movies, opt => opt.MapFrom(src => src.Films))
        .ForMember(dest => dest.Class, opt => opt.MapFrom(src => src.VehicleClass));

        CreateMap<StarshipSummary, Starship>()
        .IncludeBase<StarshipSummary, StarshipResume>();

        CreateMap<StarshipDetails, Starship>()
        .IncludeBase<StarshipSummary, Starship>()
        .ForMember(dest => dest.Movies, opt => opt.MapFrom(src => src.Films))
        .ForMember(dest => dest.Class, opt => opt.MapFrom(src => src.StarshipClass));

    }
}