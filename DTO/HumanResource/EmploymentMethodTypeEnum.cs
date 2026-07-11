using System.ComponentModel.DataAnnotations;
namespace PayaG4.SDK.DTO.HumanResource;

public enum EmploymentMethodTypeEnum : byte
{
    [Display(Name = "قراردادی")]
    Formal = 1,
    [Display(Name = "شرکتی")]
    Corporative = 2,
    [Display(Name = "رسمی")]
    Official = 3,
    [Display(Name = "پیمانی")]
    Contractual = 4,
    [Display(Name = "مامور")]
    Agent = 5,
    [Display(Name = "کارمزدی")]
    fee = 6,
    [Display(Name = "خرید خدمت")]
    PurchaseService = 7,
    [Display(Name = "ساعتی")]
    Hourly = 8,
    [Display(Name = "روزمزد")]
    Daily = 9,
    [Display(Name = "رسمی-آزمایشی")]
    TrialOfficial = 10,
    [Display(Name = "رسمی فصلی")]
    SeasonalOfficial = 11,
    [Display(Name = "سایر")]
    Other = 12,
}

