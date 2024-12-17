using System.ComponentModel.DataAnnotations;

namespace PayaG4.SDK.DTO.AccTransaction;
/// <summary>
/// نوع هدر سند حسابداری
/// </summary>
public enum AccDocumentTypeEnum
{
    [Display(Name = "افتتاحیه")]
    Opening = 1,
    [Display(Name = "اختتامیه")]
    Closing = 2,
    [Display(Name = "موقت")]
    Temporary = 3,
    [Display(Name = "عادی")]
    Normal = 4

}