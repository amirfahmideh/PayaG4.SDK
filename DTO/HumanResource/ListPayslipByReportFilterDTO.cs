
namespace PayaG4.SDK.DTO.HumanResource;

public class ListPayslipByReportFilterDTO
{
    public long PayslipDesignId { get; set; }

    public DateTime PayslipDate { get; set; }
    public string PersonnelCodeFrom { get; set; }
    public string PersonnelCodeTo { get; set; }
    public bool HasPersonnelBusinessEntityDiscreteFilter { get; set; }
    public long? PersonnelBusinessEntityCodeFrom { get; set; }
    public long? PersonnelBusinessEntityCodeTo { get; set; }
    public bool HasWorkPlaceBusinessEntityDiscreteFilter { get; set; }
    public long? WorkPlaceBusinessEntityCodeFrom { get; set; }
    public long? WorkPlaceBusinessEntityCodeTo { get; set; }
    public int? OrganizationUnitCodeFrom { get; set; }
    public int? OrganizationUnitCodeTo { get; set; }
    public List<long> OrganizationUnitIdList { get; set; }
    public int? WorkOfficeCodeFrom { get; set; }
    public int? WorkOfficeCodeTo { get; set; }
    public long? EmploymentMethodCodeFrom { get; set; }
    public long? EmploymentMethodCodeTo { get; set; }
    public List<long> EmploymentMethodIdList { get; set; }
    public int CategoryId { get; set; }
    public int UserId { get; set; }
    public int PageId { get; set; }
}
