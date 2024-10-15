using System.ComponentModel.DataAnnotations;

namespace PayaG4.SDK.DTO.Security;

public class LoginUserDTO
{
    [Required(ErrorMessage = "نام کاربری را وارد کنید")]
    [Display(Name = "نام کاربری")]
    public string Username { get; set; }
    [Required(ErrorMessage = "رمز عبور را وارد کنید")]
    [Display(Name = "رمز عبور")]
    public string Password { get; set; }
    [Display(Name = "مرا به خاطر بسپار")]
    public bool IsPersist { get; set; }

    public LoginUserDTO()
    {

    }
}
