using System.Diagnostics;
using System.Net;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using PayaG4.SDK.Base;
using PayaG4.SDK.DTO.General;
using PayaG4.SDK.DTO.General.MethodResults;
using PayaG4.SDK.DTO.HumanResource;
using PayaG4.SDK.Exceptions;

namespace PayaG4.SDK.HumanResource.V1;

public class PayslipService : BaseService
{
    private HttpClient httpClient;
    private readonly string apiPrefix = "/api/v1/humanResource/report/";
    public PayslipService(ServiceConfiguration _serviceConfiguration) : base(_serviceConfiguration)
    {
        httpClient = new HttpClient();
        httpClient.Timeout = Timeout.InfiniteTimeSpan;
    }
    public async Task<MethodResult<PayslipReportDTO>> GetAllPayslipExportByParams(ListPayslipByReportFilterDTO parameter)
    {
        try
        {
            await AddAuthorizationBearerAsync(httpClient);
            var clientUrl = GenerateApiCallUrl(apiPrefix, "getAllPayslipExportByParams");
            var response = await httpClient.PostAsJsonAsync(clientUrl, parameter);
            Console.WriteLine(response.StatusCode);
            Console.WriteLine(response.Content.Headers.ContentType);

            var body = await response.Content.ReadAsStringAsync();
            Console.WriteLine(body);
            Console.WriteLine(response.Content);

            Console.WriteLine(parameter);
            Console.WriteLine(JsonSerializer.Serialize(parameter));
            Console.WriteLine("parameter.PersonnelBusinessEntityCodeFrom", parameter.PersonnelBusinessEntityCodeFrom);
            Console.WriteLine("parameter.PersonnelBusinessEntityCodeTo", parameter.PersonnelBusinessEntityCodeTo);



            if (response.IsSuccessStatusCode)
            {
                var responseResult = await response.Content.ReadFromJsonAsync<MethodResult<PayslipReportDTO>>();
                if (responseResult != null)
                    return responseResult;
                else { return MethodResult<PayslipReportDTO>.CloneSimpleErrorMethodResult("خطا", "خطا در دسترسی به وب سرویس"); }
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
            return MethodResult<PayslipReportDTO>.CloneSimpleErrorMethodResult("خطا", ex.Message);
        }
    }
}
