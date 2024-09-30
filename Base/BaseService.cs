namespace PayaG4.SDK.Base;
public class BaseService
{
    private readonly ServiceConfiguration serviceConfiguration;

    public BaseService(ServiceConfiguration _serviceConfiguration)
    {
        serviceConfiguration = _serviceConfiguration;
    }

    public string GenerateApiCallUrl(string apiPrefix, string apiMethodName)
    {
        return $"{serviceConfiguration.ApiServerUrl}{apiPrefix}{apiMethodName}";
    }
}