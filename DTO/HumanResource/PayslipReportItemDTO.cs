

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using PersianUtilCore.Extension;


namespace PayaG4.SDK.DTO.HumanResource;

public class PayslipReportItemDTO
{
  [Display(Name = "کد طرف کسب و کار")]

  public long PersonnelBusinessEntityCode { get; set; }

  [Display(Name = "عنوان طرف کسب و کار")]

  public string PersonnelBusinessEntityName { get; set; }
  public long PersonnelId { get; set; }

  [Display(Name = "کد پرسنل")]

  public string PersonnelCode { get; set; }

  [Display(Name = "نام")]

  public string PersonnelFirstName { get; set; }

  [Display(Name = "نام خانوادگی")]

  public string PersonnelLastName { get; set; }

  [Display(Name = "دستمزد روزانه")]

  public decimal? DailyWagePrice { get; set; }

  [Display(Name = "دستمزد ماهانه")]

  public decimal? MonthlyWagePrice { get; set; }


  [Display(Name = "ساعت کاری روزانه")]

  public decimal? WorkingHourPerDay { get; set; }

  [Display(Name = "دقیقه در روز")]

  public decimal? WorkingMinutePerDay { get; set; }

  [Display(Name = "بانک")]

  public string PersonnelBankName { get; set; }

  [Display(Name = "شماره حساب")]

  public string PersonnelAccountNumber { get; set; }

  [Display(Name = "کد واحد سازمانی")]

  public int OrganizationUnitCode { get; set; }

  [Display(Name = "واحد سازمانی")]

  public string OrganizationUnitName { get; set; }


  public EmploymentMethodTypeEnum? EmploymentMethodType { get; set; }

  [Display(Name = "نوع استخدام")]

  public string EmploymentMethodTypeTitle => EmploymentMethodType?.GetDisplayName();

  [Display(Name = "محل خدمت")]

  public string PersonnelWorkPlaceName { get; set; }

  [Display(Name = "شرح شغل")]

  public string OccupationDescription { get; set; }

  [Display(Name = "کارگاه")]

  public string WorkOfficeName { get; set; }
  public List<DynamicPayslipItem> Benefits { get; set; } = new List<DynamicPayslipItem>();
  public decimal? SumBenefit => this.Benefits.Where(p => p.IsCash).Sum(s => s.PriceNumber);
  public List<DynamicPayslipItem> Deficits { get; set; } = new List<DynamicPayslipItem>();
  public decimal? SumDeficits => this.Deficits.Sum(s => s.PriceNumber);
  public List<DynamicPayslipDescriptionItem> Descriptions { get; set; } = new List<DynamicPayslipDescriptionItem>();
  public decimal? SumTotal => this.SumBenefit - this.SumDeficits;

}
