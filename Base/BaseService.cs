using PayaG4.SDK.Security.V1.Security;

namespace PayaG4.SDK.Base;
public class BaseService
{
    private readonly ServiceConfiguration serviceConfiguration;

    public BaseService(ServiceConfiguration _serviceConfiguration)
    {
        serviceConfiguration = _serviceConfiguration;
    }

    public async Task AddAuthorizationBearerAsync(HttpClient httpClient)
    {
        UserService userService = new UserService(serviceConfiguration);
        await userService.LoginAsync(new DTO.Security.LoginUserDTO
        {
            IsPersist = false,
            Password = serviceConfiguration?.Password ?? "",
            Username = serviceConfiguration?.Username ?? "",
        });
    }

    public string GenerateApiCallUrl(string apiPrefix, string apiMethodName)
    {
        return $"{serviceConfiguration.ApiServerUrl}{apiPrefix}{apiMethodName}";
    }
}