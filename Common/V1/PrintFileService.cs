using System.Diagnostics;
using System.Net;
using System.Net.Http.Json;
using PayaG4.SDK.Base;
using PayaG4.SDK.DTO.AccTransaction;
using PayaG4.SDK.DTO.Common;
using PayaG4.SDK.DTO.General;
using PayaG4.SDK.DTO.General.MethodResults;
using PayaG4.SDK.DTO.Security;
using PayaG4.SDK.Exceptions;

namespace PayaG4.SDK.Common.V1;

public class PrintFileService : BaseService
{
    private HttpClient httpClient;
    private readonly string apiPrefix = "/api/v1/printFile/";

    public PrintFileService(ServiceConfiguration _serviceConfiguration) : base(_serviceConfiguration)
    {
        httpClient = new HttpClient();
        httpClient.Timeout = Timeout.InfiniteTimeSpan;
    }
    public async Task<MethodResult<List<TextValueDTO>>> GetAllPrintFileListByParams(ListPrintFileByParamsDTO printFileListByParamsDTO)
    {
        try
        {
            await AddAuthorizationBearerAsync(httpClient);
            var clientUrl = GenerateApiCallUrl(apiPrefix, "getAllPrintFileListByParams");
            var response = await httpClient.PostAsJsonAsync(clientUrl, printFileListByParamsDTO);
            if (response.IsSuccessStatusCode)
            {
                var responseResult = await response.Content.ReadFromJsonAsync<MethodResult<List<TextValueDTO>>>();
                if (responseResult != null)
                    return responseResult;
                else { return MethodResult<List<TextValueDTO>>.CloneSimpleErrorMethodResult("خطا", "خطا در دسترسی به وب سرویس"); }
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
            return MethodResult<List<TextValueDTO>>.CloneSimpleErrorMethodResult("خطا", ex.Message);
        }
    }

    public async Task<MethodResult<PrintFileTemplateDTO>> GetPrintFileByParams(PrintFileByParamsDTO printFileByParamsDTO)
    {
        try
        {
            await AddAuthorizationBearerAsync(httpClient);
            var clientUrl = GenerateApiCallUrl(apiPrefix, "getPrintFileByParams");
            var response = await httpClient.PostAsJsonAsync(clientUrl, printFileByParamsDTO);
            if (response.IsSuccessStatusCode)
            {
                var responseResult = await response.Content.ReadFromJsonAsync<MethodResult<PrintFileTemplateDTO>>();
                if (responseResult != null)
                    return responseResult;
                else { return MethodResult<PrintFileTemplateDTO>.CloneSimpleErrorMethodResult("خطا", "خطا در دسترسی به وب سرویس"); }
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
            return MethodResult<PrintFileTemplateDTO>.CloneSimpleErrorMethodResult("خطا", ex.Message);
        }
    }

    public async Task<MethodResult<PrintFileTemplateDTO>> GetPrintFile(long id)
    {
        try
        {
            await AddAuthorizationBearerAsync(httpClient);
            var clientUrl = GenerateApiCallUrl(apiPrefix, "getPrintFile");
            var response = await httpClient.PostAsJsonAsync(clientUrl, id);
            if (response.IsSuccessStatusCode)
            {
                var responseResult = await response.Content.ReadFromJsonAsync<MethodResult<PrintFileTemplateDTO>>();
                if (responseResult != null)
                    return responseResult;
                else { return MethodResult<PrintFileTemplateDTO>.CloneSimpleErrorMethodResult("خطا", "خطا در دسترسی به وب سرویس"); }
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
            return MethodResult<PrintFileTemplateDTO>.CloneSimpleErrorMethodResult("خطا", ex.Message);
        }
    }


}
