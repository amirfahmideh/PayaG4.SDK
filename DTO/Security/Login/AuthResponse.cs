namespace PayaG4.SDK.DTO.Security;

public class AuthResponse
{
    public bool IsValid { get; set; }
    /// <summary>
    /// پیام معتبر بودن سرور
    /// </summary>
    public string Message { get; set; }
    /// <summary>
    /// توکن احراز هویت
    /// </summary>
    public string Token { get; set; }
    /// <summary>
    /// توکن بازیابی
    /// </summary>
    public string RefreshToken { get; set; }
    /// <summary>
    /// سال مالی پیش فرضی که کاربر انتخاب کرده است
    /// </summary>
    public int? FinanceYearId { get; set; }
    /// <summary>
    /// ارزی می باشد یا خیر
    /// </summary>
    public bool IsCurrency { get; set; }
    /// <summary>
    /// سال و گروه مالی که کاربر به آن دسترسی دارد
    /// </summary>
    public UserFinanceYearsInfoDTO UserFinanceYearsInfo { get; set; } = null;
    /// <summary>
    /// نام و نام خانوادگی کاربر
    /// </summary>
    public string UserFullName { get; set; }
    /// <summary>
    /// چارت سازمانی پیش فرض کاربر
    /// </summary>
    public long? DefaultOrganizationPostId { get; set; }
}

