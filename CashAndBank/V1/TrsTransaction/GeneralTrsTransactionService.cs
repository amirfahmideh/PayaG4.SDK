using System.Net;
using System.Net.Http.Json;
using PayaG4.SDK.Base;
using PayaG4.SDK.DTO.CashAndBank;
using PayaG4.SDK.DTO.General.MethodResults;
using PayaG4.SDK.Exceptions;

namespace PayaG4.SDK.CashAndBank.V1.TrsTransaction;
public class GeneralTrsTransactionService : BaseService
{
    private HttpClient httpClient;
    private readonly string apiPrefix = "/api/v1/trsTransaction/";
    public GeneralTrsTransactionService(ServiceConfiguration _serviceConfiguration) : base(_serviceConfiguration)
    {
        httpClient = new HttpClient();
        httpClient.Timeout = Timeout.InfiniteTimeSpan;
    }
    public async Task<MethodResult<ReceiptReceiveTransactionItemDTO>> GetReceiptReceiveItemByParamsAsync(ListReceiptReceiveTransactionItemByParamsDTO parameter)
    {
        try
        {
            var clientUrl = GenerateApiCallUrl(apiPrefix, "getReceiptReceiveItemByParams");
            var response = await httpClient.PostAsJsonAsync(clientUrl, parameter);
            if (response.IsSuccessStatusCode)
            {
                var responseResult = await response.Content.ReadFromJsonAsync<MethodResult<ReceiptReceiveTransactionItemDTO>>();
                if (responseResult != null)
                    return responseResult;
                else { return MethodResult<ReceiptReceiveTransactionItemDTO>.CloneSimpleErrorMethodResult("خطا", "خطا در دسترسی به وب سرویس"); }
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
            return MethodResult<ReceiptReceiveTransactionItemDTO>.CloneSimpleErrorMethodResult("خطا", ex.Message);
        }
    }

    public async Task<MethodResult<ReceiptReceiveTransactionItemDTO>> GetLatestReceiptReceiveItemByParamsAsync(ListLatestReceiptReceiveTransactionItemByParamsDTO parameter)
    {
        try
        {
            var clientUrl = GenerateApiCallUrl(apiPrefix, "getLatestReceiptReceiveItemByParams");
            var response = await httpClient.PostAsJsonAsync(clientUrl, parameter);
            if (response.IsSuccessStatusCode)
            {
                var responseResult = await response.Content.ReadFromJsonAsync<MethodResult<ReceiptReceiveTransactionItemDTO>>();
                if (responseResult != null)
                    return responseResult;
                else { return MethodResult<ReceiptReceiveTransactionItemDTO>.CloneSimpleErrorMethodResult("خطا", "خطا در دسترسی به وب سرویس"); }
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
            return MethodResult<ReceiptReceiveTransactionItemDTO>.CloneSimpleErrorMethodResult("خطا", ex.Message);
        }
    }
}
