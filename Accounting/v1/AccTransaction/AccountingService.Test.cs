
using NUnit.Framework;
namespace PayaG4.SDK.Accounting.V1.AccTransaction;
public class AccountingServiceTest
{
    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void GetAllTfCardDetailBasedOnTfByParams()
    {
        AccountingService accountingService = new AccountingService(new ServiceConfiguration()
        {
            ApiServerUrl = "http://217.219.81.100:9000",
        });
        var result = accountingService.GetAllTfCardDetailBasedOnTfByParams(new DTO.AccTransaction.ListTfCardDetailBasedOnTfCodeByReportFilterDTO()
        {
            TfCode = "1",
            DocumentDateTo = DateTime.Parse("2022-01-01"),
            DocumentDateFrom = DateTime.Now
        }).GetAwaiter().GetResult();

        Assert.IsTrue(result != null);
    }

}
