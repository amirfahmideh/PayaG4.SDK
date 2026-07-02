using System.Diagnostics;
using System.Net;
using System.Net.Http.Json;
using PayaG4.SDK.Base;
using PayaG4.SDK.DTO.AccTransaction;
using PayaG4.SDK.DTO.General;
using PayaG4.SDK.DTO.General.MethodResults;
using PayaG4.SDK.Exceptions;

namespace PayaG4.SDK.Accounting.V1.AccTransaction;

public class DocumentCategoryService : BaseService
{
    private HttpClient httpClient;
    private readonly string apiPrefix = "/api/v1/documentCategory/";

    public DocumentCategoryService(ServiceConfiguration _serviceConfiguration) : base(_serviceConfiguration)
    {
        httpClient = new HttpClient();
        httpClient.Timeout = Timeout.InfiniteTimeSpan;
    }
    public async Task<MethodResult<List<TextValueCodeDTO>>> GetAllDocumentCategoryRoleListByUserId()
    {
        try
        {
            // await AddAuthorizationBearerAsync(httpClient);
            var clientUrl = GenerateApiCallUrl(apiPrefix, "getAllDocumentCategoryRoleListByUserId");
            var response = await httpClient.PostAsync(clientUrl, null);
            if (response.IsSuccessStatusCode)
            {
                var responseResult = await response.Content.ReadFromJsonAsync<MethodResult<List<TextValueCodeDTO>>>();
                if (responseResult != null)
                    return responseResult;
                else { return MethodResult<List<TextValueCodeDTO>>.CloneSimpleErrorMethodResult("خطا", "خطا در دسترسی به وب سرویس"); }
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
            return MethodResult<List<TextValueCodeDTO>>.CloneSimpleErrorMethodResult("خطا", ex.Message);
        }
    }
}
