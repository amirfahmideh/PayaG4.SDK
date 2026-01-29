using PayaG4.SDK.Base;
using PayaG4.SDK.DTO.CashAndBank;
using PayaG4.SDK.DTO.General.MethodResults;
using PayaG4.SDK.Exceptions;
using System.Net;
using System.Net.Http.Json;

namespace PayaG4.SDK.CashAndBank.V1.TrsTransaction;
public class GeneralTrsTransactionService : BaseService
{
    private HttpClient httpClient;
    private readonly string apiPrefix = "/api/v1/trsTransaction/";
    private readonly string apiCashPrefix = "/api/v1/Cash/";
    private readonly string apiDocumentsPrefix = "/api/v1/Documents/";
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

    /******************************************* C A S H         S E R V I C E S ********************************************************************************************************************/

    public async Task<MethodResult<bool>> UpdateExternalReferenceIdGetCashItem(UpdateExternalReferenceIdTransactionItemDTO parameter)
    {
        try
        {
            await AddAuthorizationBearerAsync(httpClient);
            var clientUrl = GenerateApiCallUrl(apiCashPrefix, "updateExternalReferenceIdGetCashItem");
            var response = await httpClient.PostAsJsonAsync(clientUrl, parameter);
            if (response.IsSuccessStatusCode)
            {
                var responseResult = await response.Content.ReadFromJsonAsync<MethodResult<bool>>();
                if (responseResult != null)
                    return responseResult;
                else { return MethodResult<bool>.CloneSimpleErrorMethodResult("خطا", "خطا در دسترسی به وب سرویس"); }
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
            return MethodResult<bool>.CloneSimpleErrorMethodResult("خطا", ex.Message);
        }
    }

    public async Task<MethodResult<bool>> UpdateExternalReferenceIdPayCashItem(UpdateExternalReferenceIdTransactionItemDTO parameter)
    {
        try
        {
            await AddAuthorizationBearerAsync(httpClient);
            var clientUrl = GenerateApiCallUrl(apiCashPrefix, "updateExternalReferenceIdPayCashItem");
            var response = await httpClient.PostAsJsonAsync(clientUrl, parameter);
            if (response.IsSuccessStatusCode)
            {
                var responseResult = await response.Content.ReadFromJsonAsync<MethodResult<bool>>();
                if (responseResult != null)
                    return responseResult;
                else { return MethodResult<bool>.CloneSimpleErrorMethodResult("خطا", "خطا در دسترسی به وب سرویس"); }
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
            return MethodResult<bool>.CloneSimpleErrorMethodResult("خطا", ex.Message);
        }
    }

    /******************************************* D O C U M E N T S         S E R V I C E S ********************************************************************************************************************/

    public async Task<MethodResult<bool>> UpdateExternalReferenceIdReceiveDocumentsItem(UpdateExternalReferenceIdTransactionItemDTO parameter)
    {
        try
        {
            await AddAuthorizationBearerAsync(httpClient);
            var clientUrl = GenerateApiCallUrl(apiDocumentsPrefix, "updateExternalReferenceIdReceiveDocumentsItem");
            var response = await httpClient.PostAsJsonAsync(clientUrl, parameter);
            if (response.IsSuccessStatusCode)
            {
                var responseResult = await response.Content.ReadFromJsonAsync<MethodResult<bool>>();
                if (responseResult != null)
                    return responseResult;
                else { return MethodResult<bool>.CloneSimpleErrorMethodResult("خطا", "خطا در دسترسی به وب سرویس"); }
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
            return MethodResult<bool>.CloneSimpleErrorMethodResult("خطا", ex.Message);
        }
    }

    public async Task<MethodResult<bool>> UpdateExternalReferenceIdPayDocumentsItem(UpdateExternalReferenceIdTransactionItemDTO parameter)
    {
        try
        {
            await AddAuthorizationBearerAsync(httpClient);
            var clientUrl = GenerateApiCallUrl(apiDocumentsPrefix, "updateExternalReferenceIdPayDocumentsItem");
            var response = await httpClient.PostAsJsonAsync(clientUrl, parameter);
            if (response.IsSuccessStatusCode)
            {
                var responseResult = await response.Content.ReadFromJsonAsync<MethodResult<bool>>();
                if (responseResult != null)
                    return responseResult;
                else { return MethodResult<bool>.CloneSimpleErrorMethodResult("خطا", "خطا در دسترسی به وب سرویس"); }
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
            return MethodResult<bool>.CloneSimpleErrorMethodResult("خطا", ex.Message);
        }
    }
}
