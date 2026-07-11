using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PayaG4.SDK.DTO.Common;

public class PrintFileTemplateDTO
{
    [Display(Name = "کلید")]
    public int Id { get; set; }

    [Display(Name = "صفحه")]
    public int PageId { get; set; }

    [Display(Name = "عنوان")]
    public string Name { get; set; }

    [Display(Name = "نوع فایل پرینت")]
    public int Type { get; set; }

    [Display(Name = "فایل اصلی")]
    public string DesignFileString { get; set; }

    [Display(Name = "نوع فایل")]
    public string FileType { get; set; }

    [Display(Name = "تعداد چاپ شده")]
    public int? PrintCount { get; set; }

    [Display(Name = "کد کاربر")]
    public int UserId { get; set; }

    [Display(Name = "تاریخ ویرایش")]
    public DateTime ModifiedDate { get; set; }

    [Display(Name = "گروه مالی")]
    public int FGYearId { get; set; }
}
