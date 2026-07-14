using System.Net;
using System.Net.Http.Json;
using PayaG4.SDK.Base;
using PayaG4.SDK.DTO.General.MethodResults;
using PayaG4.SDK.DTO.CashAndBank;
using PayaG4.SDK.Exceptions;
using PayaG4.SDK.DTO.Security;

namespace PayaG4.SDK.Security.V1.Security;

public class OwnerService : BaseService
{
    private HttpClient httpClient;
    private readonly string apiPrefix = "/api/v1/owner/";
    public OwnerService(ServiceConfiguration _serviceConfiguration) : base(_serviceConfiguration)
    {
        httpClient = new HttpClient();
    }
    public async Task<MethodResult<OwnerLicenceInformationDTO>> GetOwnerLicenceInformation()
    {
        try
        {
            httpClient = new HttpClient();
            var clientUrl = GenerateApiCallUrl(apiPrefix, "login");
            var response = await httpClient.PostAsync(clientUrl, null);
            if (response.IsSuccessStatusCode)
            {
                var responseResult = await response.Content.ReadFromJsonAsync<MethodResult<OwnerLicenceInformationDTO>>();
                if (responseResult != null)
                    return responseResult;
                else { return MethodResult<OwnerLicenceInformationDTO>.CloneSimpleErrorMethodResult("خطا", "خطا در دسترسی به وب سرویس"); }
            }
            else if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new UnauthorizedException();
            }
            else if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                throw new BadRequestException();
            }
            else throw new Exception(response.ReasonPhrase);
        }
        catch (Exception ex)
        {
            return MethodResult<OwnerLicenceInformationDTO>.CloneSimpleErrorMethodResult("خطا", ex.Message);
        }
    }
}
