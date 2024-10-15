using Microsoft.CodeAnalysis.CSharp.Syntax;
using PayaG4.SDK.Exceptions;
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
        var result = await userService.LoginAsync(new DTO.Security.LoginUserDTO
        {
            IsPersist = false,
            Password = serviceConfiguration?.Password ?? "",
            Username = serviceConfiguration?.Username ?? "",
        });
        if (result.ResultModel.Type == DTO.General.MethodResults.CRUDResultEnum.Success)
        {
            if (result.Result.IsValid)
                httpClient.DefaultRequestHeaders.Add("Authorization", $"bearer {result.Result.Token}");
            else
            {
                throw new UnauthorizedException("نام کاربری و رمز عبور را بررسی کنید");
            }
        }
        else
        {
            throw new UnauthorizedException("نام کاربری و رمز عبور را بررسی کنید");
        }
    }

    public string GenerateApiCallUrl(string apiPrefix, string apiMethodName)
    {
        return $"{serviceConfiguration.ApiServerUrl}{apiPrefix}{apiMethodName}";
    }
}