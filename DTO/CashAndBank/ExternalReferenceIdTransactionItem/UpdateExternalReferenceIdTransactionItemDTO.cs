using System.ComponentModel.DataAnnotations;

namespace PayaG4.SDK.DTO.CashAndBank
{
    public class UpdateExternalReferenceIdTransactionItemDTO
    {
        [Display(Name = "کلید به جزییات تراکنش")]
        [Required(ErrorMessage = "کلید به جزییات تراکنش را مشخص کنید")]
        public long TrsTransactionItemId { get; set; }

        [Display(Name = "کلید مبدا ارجاع")]
        [Required(ErrorMessage = "کلید مبدا ارجاع را مشخص کنید")]
        public string ExternalReferenceId { get; set; }
    }
}
