using System;
using System.ComponentModel.DataAnnotations;
using PersianUtilCore.Extension.Datetime;

namespace PayaG4.SDK.DTO.HumanResource;

public class PersonnelDTO
{
    [Display(Name = "کلید")]
    public long Id { get; set; }

    [Display(Name = "کلید ماهیت طرف کسب و کار")]
    public long BusinessEntityDetailId { get; set; }
    [Display(Name = "کلید طرف کسب و کار")]
    public long BusinessEntityId { get; set; }

    [Display(Name = "عنوان طرف کسب و کار")]
    public string BusinessEntityTitle { get; set; }

    [Display(Name = "کد طرف کسب و کار")]
    public long BusinessEntityCode { get; set; }

    [Display(Name = "نام طرف کسب و کار")]
    public string FirstName { get; set; }

    [Display(Name = "نام خانوادگی طرف کسب و کار")]
    public string LastName { get; set; }

    [Display(Name = "نام لاتین طرف کسب و کار")]
    public string LatinName { get; set; }

    [Display(Name = "شماره ثبت شرکت طرف کسب و کار")]
    public string CompanyRegistrationNo { get; set; }
    public int? CardexCode { get; set; }
    [Display(Name = "کد کاربر")]
    public int UserId { get; set; }

    [Display(Name = "تاریخ ویرایش")]
    public DateTime ModifiedDate { get; set; }

    [Display(Name = "تاریخ ویرایش")]
    public string ModifiedDateFa => this.ModifiedDate.ToStringPersian(PersianStringType.SimpleFullDigit);

}
