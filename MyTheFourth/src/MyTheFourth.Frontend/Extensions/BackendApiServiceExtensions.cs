using MyTheFourth.Frontend.Configuration;

namespace MyTheFourth.Frontend.Extensions;

public static class BackendApiServiceExtensions
{

    public static IBackendServiceConfigurationBuilder AddApi<TService>(
        this IBackendServiceConfigurationBuilder backendBuilder, string apiServiceId) where TService : class
    {

        return backendBuilder.AddHttpClient<TService>(apiServiceId);

    }
}

[Serializable]
internal class ApiConfigurationException : Exception
{
    public ApiConfigurationException()
    {
    }

    public ApiConfigurationException(string? message) : base(message)
    {
    }

    public ApiConfigurationException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}