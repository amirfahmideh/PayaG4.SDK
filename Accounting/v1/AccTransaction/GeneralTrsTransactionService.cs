using System.Net;
using System.Net.Http.Json;
using PayaG4.SDK.Base;
using PayaG4.SDK.DTO.AccTransaction;
using PayaG4.SDK.DTO.General.MethodResults;
using PayaG4.SDK.Exceptions;

namespace PayaG4.SDK.Accounting.V1.AccTransaction;
public class GeneralAccountingService : BaseService
{
    private HttpClient httpClient;
    private readonly string apiPrefix = "/api/v1/accTransaction/";
    public GeneralAccountingService(ServiceConfiguration _serviceConfiguration) : base(_serviceConfiguration)
    {
        httpClient = new HttpClient();
    }
    public async Task<MethodResult<int>> AddAccTransactionAsync(AddAccTransactionDTO parameter)
    {
        try
        {
            httpClient = new HttpClient();
            var clientUrl = GenerateApiCallUrl(apiPrefix, "addAccTransaction");
            var response = await httpClient.PostAsJsonAsync(clientUrl, parameter);
            if (response.IsSuccessStatusCode)
            {
                var responseResult = await response.Content.ReadFromJsonAsync<MethodResult<int>>();
                if (responseResult != null)
                    return responseResult;
                else { return MethodResult<int>.CloneSimpleErrorMethodResult("خطا", "خطا در دسترسی به وب سرویس"); }
            }
            else if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new UnauthorizedException();
            }
            else if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                throw new BadRequestException();
            }
            else throw new Exception("UnHandle Exception");
        }
        catch (Exception ex)
        {
            return MethodResult<int>.CloneSimpleErrorMethodResult("خطا", ex.Message);
        }
    }
}
