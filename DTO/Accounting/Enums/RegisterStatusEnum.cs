using System.ComponentModel.DataAnnotations;

namespace PayaG4.SDK.DTO.AccTransaction
{
    /// <summary>
    /// وضعیت ثبت
    /// </summary>
    public enum RegisterStatusEnum : byte
    {
        [Display(Name = "ویرایش")]
        Edit = 1,
        [Display(Name = "صدور")]
        Issuance = 2,
        [Display(Name = "تایید")]
        Confirm = 3,
        [Display(Name = "ثبت نهایی")]
        RegisterDefinitive = 4
    }
}
