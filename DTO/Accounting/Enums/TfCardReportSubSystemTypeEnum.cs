using System.ComponentModel.DataAnnotations;

namespace PayaG4.SDK.DTO.AccTransaction;
public enum TfCardReportSubSystemTypeEnum
{
    [Display(Name = "نقد و بانک")]
    Transaction = 1,

    [Display(Name = "فروش")]
    Sale = 2,

    [Display(Name = "انبار")]
    Warehouse = 3,
    [Display(Name = "اعلامیه")]
    AccStatement = 4
}
