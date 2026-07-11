using System.ComponentModel.DataAnnotations;

namespace PayaG4.SDK.DTO.Common;
public class PrintFileByParamsDTO
{
    [Display(Name = "صفحه")]
    [Required(ErrorMessage = "صفحه را وارد کنید")]
    public int PageId { get; set; }

    [Display(Name = "کد طبقه اسنادی")]
    public int? DocumentCategoryId { get; set; }

    [Display(Name = "نوع فایل پرینت")]
    [Required(ErrorMessage = "نوع فایل پرینت را وارد کنید")]
    public int Type { get; set; }
}
