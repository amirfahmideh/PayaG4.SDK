using System.ComponentModel.DataAnnotations;

namespace PayaG4.SDK.DTO.AccTransaction
{
    public enum TfLevelNumberEnum
    {
        [Display(Name = "سطح یک")]
        One = 1,
        [Display(Name = "سطح دوم")]
        Two = 2,
        [Display(Name = "سطح سوم")]
        Three = 3,
        [Display(Name = "سطح چهارم")]
        Four = 4,
        [Display(Name = "سطح پنجم")]
        Five = 5,
        [Display(Name = "سطح ششم")]
        Six = 6
    }
}
