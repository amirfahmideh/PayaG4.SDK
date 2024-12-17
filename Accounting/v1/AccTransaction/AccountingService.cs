using System.Diagnostics;
using System.Net;
using System.Net.Http.Json;
using PayaG4.SDK.Base;
using PayaG4.SDK.DTO.AccTransaction;
using PayaG4.SDK.DTO.General.MethodResults;
using PayaG4.SDK.Exceptions;

namespace PayaG4.SDK.Accounting.V1.AccTransaction;
public class AccountingService : BaseService
{
    private HttpClient httpClient;
    private readonly string apiPrefix = "/api/v1/accTransaction/";
    private readonly string apiReportPrefix = "/api/v1/accounting/report";

    public AccountingService(ServiceConfiguration _serviceConfiguration) : base(_serviceConfiguration)
    {
        httpClient = new HttpClient();
    }
    public async Task<MethodResult<int>> AddAccTransactionAsync(AddAccTransactionBatchDTO parameter)
    {
        try
        {
            httpClient = new HttpClient();
            await AddAuthorizationBearerAsync(httpClient);
            var clientUrl = GenerateApiCallUrl(apiPrefix, "addAccTransactionBatch");
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
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }
        catch (Exception ex)
        {
            return MethodResult<int>.CloneSimpleErrorMethodResult("خطا", ex.Message);
        }
    }

    public async Task<MethodResult<TfCardDetailBasedOnTfCodeReportDTO>> GetAllTfCardDetailBasedOnTfByParams(ListTfCardDetailBasedOnTfCodeByReportFilterDTO parameter)
    {
        try
        {
            httpClient = new HttpClient();
            var clientUrl = GenerateApiCallUrl(apiReportPrefix, "getAllTfCardDetailBasedOnTfByParams");
            var response = await httpClient.PostAsJsonAsync(clientUrl, parameter);
            if (response.IsSuccessStatusCode)
            {
                var responseResult = await response.Content.ReadFromJsonAsync<MethodResult<TfCardDetailBasedOnTfCodeReportDTO>>();
                if (responseResult != null)
                    return responseResult;
                else { return MethodResult<TfCardDetailBasedOnTfCodeReportDTO>.CloneSimpleErrorMethodResult("خطا", "خطا در دسترسی به وب سرویس"); }
            }
            else if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new UnauthorizedException();
            }
            else if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                throw new BadRequestException();
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }
        catch (Exception ex)
        {
            return MethodResult<TfCardDetailBasedOnTfCodeReportDTO>.CloneSimpleErrorMethodResult("خطا", ex.Message);
        }
    }
}
