using MyTheFourth.Frontend.Configuration;
using MyTheFourth.Frontend.Constants;
using MyTheFourth.Frontend.Services.Interfaces;

namespace MyTheFourth.Frontend.DependencyInjections;

public class ApiHttpServiceProvider : IBackendServiceProvider
{
    private readonly IServiceProvider _serviceProvider;
    private string _currentServiceId = null!;

    public ApiHttpServiceProvider(IServiceProvider serviceProvider, string?  currentServiceId = BackendServicesIdentifiers.DevResistence)
    {
        _serviceProvider = serviceProvider;
        _currentServiceId = currentServiceId!;
    }

    public IMyTheFourthService? Current => GetCurrentService();

    private IMyTheFourthService? GetCurrentService()
    {
        var apiServices = _serviceProvider.GetServices<IMyTheFourthService>();

        if (string.IsNullOrEmpty(_currentServiceId)) return apiServices.FirstOrDefault();

        return apiServices.FirstOrDefault(c => c.ServiceId.ToString().Equals(_currentServiceId));

    }

    public void SetDefault()
    {
        var apiServices = _serviceProvider.GetServices<IMyTheFourthService>();

        if (apiServices.Any()) _currentServiceId = apiServices.First().ServiceId.ToString();
    }

    public void SetServiceId(string serviceId)
    {
        if (string.IsNullOrEmpty(serviceId)) return;
        _currentServiceId = serviceId;

    }
}
