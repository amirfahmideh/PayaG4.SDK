using System.Diagnostics;
using System.Net;
using System.Net.Http.Json;
using PayaG4.SDK.Base;
using PayaG4.SDK.DTO.AccTransaction;
using PayaG4.SDK.DTO.General;
using PayaG4.SDK.DTO.General.MethodResults;
using PayaG4.SDK.DTO.HumanResource;
using PayaG4.SDK.Exceptions;

namespace PayaG4.SDK.HumanResource.V1.Personnel;

public class PersonnelService : BaseService
{
    private HttpClient httpClient;
    private readonly string apiPrefix = "/api/v1/personnel/";
    public PersonnelService(ServiceConfiguration _serviceConfiguration) : base(_serviceConfiguration)
    {
        httpClient = new HttpClient();
        httpClient.Timeout = Timeout.InfiniteTimeSpan;
    }
    public async Task<MethodResult<GridData<PersonnelDTO>>> GetAllPersonnelList()
    {
        try
        {
            // await AddAuthorizationBearerAsync(httpClient);
            var clientUrl = GenerateApiCallUrl(apiPrefix, "getAllPersonnelList");
            AgGridParameter parameter = AgGridParameter.AllRows;
            var response = await httpClient.PostAsJsonAsync(clientUrl, parameter);
            if (response.IsSuccessStatusCode)
            {
                var responseResult = await response.Content.ReadFromJsonAsync<MethodResult<GridData<PersonnelDTO>>>();
                if (responseResult != null)
                    return responseResult;
                else { return MethodResult<GridData<PersonnelDTO>>.CloneSimpleErrorMethodResult("خطا", "خطا در دسترسی به وب سرویس"); }
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
            return MethodResult<GridData<PersonnelDTO>>.CloneSimpleErrorMethodResult("خطا", ex.Message);
        }
    }
}
