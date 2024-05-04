using AutoMapper;
using MyTheFourth.Frontend.Constants;
using MyTheFourth.Frontend.DevsResistenceContext.Constants;
using MyTheFourth.Frontend.DevsResistenceContext.Models;
using MyTheFourth.Frontend.Extensions;
using MyTheFourth.Frontend.Models;
using MyTheFourth.Frontend.Services.Interfaces;

namespace MyTheFourth.Frontend.DevsResistenceContext.Services;

public class DevResistenceMyTheFourthHttpService :
IMyTheFourthService
{
    private readonly HttpClient _client;
    private readonly IMapper _mapper;

    public DevResistenceMyTheFourthHttpService(HttpClient client, IMapper mapper)
    {
        _client = client;
        _mapper = mapper;
    }

    public string ServiceId => BackendServicesIdentifiers.DevResistence;

    public async Task<Character?> GetCharacterAsync(string characterId)
    {
        var response = await _client.GetAsync($"{MyTheFourthHttpServiceEndpoints.CharacterEndpoint}/{characterId}");

        var result = await response.GetContentData<CharacterDataModel>();

        return result is not null ? _mapper.Map<Character>(result) : default!;
    }

    public async Task<Movie?> GetMovieAsync(string movieId)
    {
        var response = await _client.GetAsync($"{MyTheFourthHttpServiceEndpoints.MoviesEndpoint}/{movieId}");

        var result = await response.GetContentData<MovieDataModel>();

        return result is not null ? _mapper.Map<Movie>(result) : default!;
    }

    public async Task<Planet?> GetPlanetAsync(string planetId)
    {
        var response = await _client.GetAsync($"{MyTheFourthHttpServiceEndpoints.PlanetsEndpoint}/{planetId}");

        var result = await response.GetContentData<PlanetDataModel>();

        return result is not null ? _mapper.Map<Planet>(result) : default!;

    }

    public async Task<Starship?> GetStarshipAsync(string starshipId)
    {
        var response = await _client.GetAsync($"{MyTheFourthHttpServiceEndpoints.StarshipsEndpoint}/{starshipId}");

        var result = await response.GetContentData<StarshipDataModel>();

        return result is not null ? _mapper.Map<Starship>(result) : default!;
    }

    public async Task<Vehicle?> GetVehicleAsync(string vehicleId)
    {

        var response = await _client.GetAsync($"{MyTheFourthHttpServiceEndpoints.VehiclesEndpoint}/{vehicleId}");

        var result = await response.GetContentData<VehicleDataModel>();

        return result is not null ? _mapper.Map<Vehicle>(result) : default!;
    }

    public async Task<IEnumerable<Character>> ListCharactersAsync(int? page, int? pageSize)
    {
        try
        {
            var response = await _client.GetAsync($"{MyTheFourthHttpServiceEndpoints.CharacterEndpoint}?pageNumber={page ?? 1}&pageSize={pageSize ?? 10}");

            var result = await response.GetContentData<CharacterListResponse>();

            return result?.Results?.Any() is true ? _mapper.Map<IEnumerable<Character>>(result.Results) : Enumerable.Empty<Character>();

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);

        }
        return Enumerable.Empty<Character>();
    }

    public async Task<IEnumerable<Movie>> ListMoviesAsync(int? page, int? pageSize)
    {
        try
        {
            var response = await _client.GetAsync($"{MyTheFourthHttpServiceEndpoints.MoviesEndpoint}?pageNumber={page ?? 1}&pageSize={pageSize ?? 10}");

            var result = await response.GetContentData<MovieListResponse>();

            return result?.Results?.Any() is true ? _mapper.Map<IEnumerable<Movie>>(result.Results) : Enumerable.Empty<Movie>();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);

        }
        return Enumerable.Empty<Movie>();
    }

    public async Task<IEnumerable<Planet>> ListPlanetsAsync(int? page, int? pageSize)
    {
        try
        {
            var response = await _client.GetAsync($"{MyTheFourthHttpServiceEndpoints.PlanetsEndpoint}?pageNumber={page ?? 1}&pageSize={pageSize ?? 10}");

            var result = await response.GetContentData<PlanetListResponse>();

            return result?.Results?.Any() is true ? _mapper.Map<IEnumerable<Planet>>(result.Results) : Enumerable.Empty<Planet>();

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);

        }
        return Enumerable.Empty<Planet>();
    }

    public async Task<IEnumerable<Starship>> ListStarshipsAsync(int? page, int? pageSize)
    {
        try
        {
            var response = await _client.GetAsync($"{MyTheFourthHttpServiceEndpoints.StarshipsEndpoint}?pageNumber={page ?? 1}&pageSize={pageSize ?? 10}");

            var result = await response.GetContentData<StarshipListResponse>();

            return result?.Results?.Any() is true ? _mapper.Map<IEnumerable<Starship>>(result.Results) : Enumerable.Empty<Starship>();

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);

        }
        return Enumerable.Empty<Starship>();
    }

    public async Task<IEnumerable<Vehicle>> ListVehiclesAsync(int? page, int? pageSize)
    {
        try
        {
            var response = await _client.GetAsync($"{MyTheFourthHttpServiceEndpoints.VehiclesEndpoint}?pageNumber={page ?? 1}&pageSize={pageSize ?? 10}");

            var result = await response.GetContentData<VehicleListResponse>();

            return result?.Results?.Any() is true ? _mapper.Map<IEnumerable<Vehicle>>(result.Results) : Enumerable.Empty<Vehicle>();

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);

        }
        return Enumerable.Empty<Vehicle>();
    }
}
