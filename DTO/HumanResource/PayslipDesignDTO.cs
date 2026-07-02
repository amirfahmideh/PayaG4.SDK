using PayaG4.SDK.DTO.AccTransaction;
using PersianUtilCore.Extension;
using PersianUtilCore.Extension.Datetime;
namespace PayaG4.SDK.DTO.HumanResource;

public class PayslipDesignDTO
{
    public long Id { get; set; }
    public int Code { get; set; }
    public string Name { get; set; }
    public string LatinName { get; set; }
    public string Description { get; set; }
    public RegisterStatusEnum Status { get; set; }
    public string StatusTitle => Status.GetDisplayName();
    public int UserId { get; set; }
    public DateTime ModifiedDate { get; set; }
    public string ModifiedDateFa => ModifiedDate.ToStringPersian(PersianStringType.FullDigitWithTime);

}