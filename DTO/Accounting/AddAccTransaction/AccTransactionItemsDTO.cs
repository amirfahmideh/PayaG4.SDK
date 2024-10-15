using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace PayaG4.SDK.DTO.AccTransaction;
public class AccTransactionItemsDTO
{

    [Display(Name = "حساب کل")]
    [Required(ErrorMessage = "کد کل را مشخص کنید")]
    public int KlCode { get; set; }

    [Display(Name = "حساب معین")]
    [Required(ErrorMessage = "کد معین را مشخص کنید")]
    public int MnCode { get; set; }

    [Display(Name = "حساب تفصیلی1")]
    public string TfLevel1Code { get; set; }

    [Display(Name = "حساب تفصیلی2")]
    public string TfLevel2Code { get; set; }

    [Display(Name = "حساب تفصیلی3")]
    public string TfLevel3Code { get; set; }

    [Display(Name = "حساب تفصیلی4")]
    public string TfLevel4Code { get; set; }

    [Display(Name = "حساب تفصیلی5")]
    public string TfLevel5Code { get; set; }

    [Display(Name = "حساب تفصیلی6")]
    public string TfLevel6Code { get; set; }

    [Display(Name = "مبلغ بدهکار")]
    public decimal? Debit { get; set; }

    [Display(Name = "مبلغ بستانکار")]
    public decimal? Credit { get; set; }

    [Display(Name = "شرح ردیف")]
    [StringLength(500, ErrorMessage = "طول مجاز برای شرح ردیف {1} کارکتر می باشد")]
    public string Description { get; set; }

}
