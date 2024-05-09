
using MyTheFourth.Frontend.DevsResistenceContext.Models;

namespace MyTheFourth.Frontend.Models;

public class Vehicle : VehicleResume
{
    public string? Model { get; set; }

    public string? Manufacturer { get; set; }

    public string? CostInCredits { get; set; }

    public string? Length { get; set; }

    public string? MaxSpeed { get; set; }

    public string? Crew { get; set; }

    public string? Passengers { get; set; }

    public string? CargoCapacity { get; set; }

    public string? Consumables { get; set; }

    public string? Class { get; set; }

    public IEnumerable<MovieResume>? Movies { get; set; }

    public Vehicle()
    {
        Movies = new List<MovieResume>();
    }

    public static Vehicle ConvertVehicle(VehicleDataModel? result)
    {
        if (result is null)
            return new Vehicle();

        Vehicle vehicle = new Vehicle
        {
            Id = result.Id.ToString(),
            Name = result.Name,
            Model = result.Model,
            Manufacturer = result.Manufacturer,
            CostInCredits = result.CostInCredits,
            Length = result.Length,
            MaxSpeed = result.MaxSpeed,
            Crew = result.Crew,
            Passengers = result.Passengers,
            CargoCapacity = result.CargoCapacity,
            Consumables = result.Consumables,
            Class = result.Class,
            Movies = result.Movies.Select(m => new MovieResume
            {
                Id = m.Id.ToString(),
                Title = m.Title
            }).ToList()
        };
        
        return vehicle;
    }

    //Mapeando como Response.
    public static VehicleListResponse ConvertListResponseVehicle(VehicleListResponse result)
    {
        if (result.Results != null)
        {
            var vehicle = result.Results.Select(item => new VehicleDataModel
            {
                Id = item.Id,
                Name = item.Name,
                Model = item.Model,
                Manufacturer = item.Manufacturer,
                CostInCredits = item.CostInCredits,
                Length = item.Length,
                MaxSpeed = item.MaxSpeed,
                Crew = item.Crew,
                Passengers = item.Passengers,
                CargoCapacity = item.CargoCapacity,
                Consumables = item.Consumables,
                Class = item.Class,
                Movies = item
                    .Movies
                    .Select(m => new MovieDataModel
                    {
                        Id = m.Id,
                        Title = m.Title,
                    }).ToList()
            }).ToList();

            var res = new VehicleListResponse();
            res.Count = result.Count;
            res.PageNumber = result.PageNumber;
            res.PageSize = result.PageSize;
            res.Results = vehicle;

            return res;
        }

        return new VehicleListResponse();
    }

    public static List<Vehicle> ConvertListVehicle(VehicleListResponse result)
    {
        if (result.Results != null)
        {
            var vehicle = result.Results.Select(item => new Vehicle
            {
                Id = item.Id.ToString(),
                Name = item.Name,
                Model = item.Model,
                Manufacturer = item.Manufacturer,
                CostInCredits = item.CostInCredits,
                Length = item.Length,
                MaxSpeed = item.MaxSpeed,
                Crew = item.Crew,
                Passengers = item.Passengers,
                CargoCapacity = item.CargoCapacity,
                Consumables = item.Consumables,
                Class = item.Class,
                Movies = item.Movies.Select(m => new MovieResume
                {
                    Id = m.Id.ToString(),
                    Title = m.Title
                }).ToList(),
            }).ToList();

            return vehicle;
        }

        return new List<Vehicle>();
    }

}