using System.ComponentModel.DataAnnotations;

namespace PayaG4.SDK.DTO.TrsTransaction
{
    public enum TransactionTypeEnum
    {
        [Display(Name = "دریافت صندوق")]
        GetCash = 1,

        [Display(Name = "دریافت اسناد")]
        ReceiveDocuments = 2,

        [Display(Name = "گردش اسناد دریافتنی")]
        ReceivableDocumentsCirculation = 3,

        [Display(Name = "تنخواه")]
        PettyCash = 4,

        [Display(Name = "پرداخت صندوق")]
        PayCash = 5,

        [Display(Name = "پرداخت سند")]
        PayDocuments = 6,

        [Display(Name = "گردش اسناد پرداختنی")]
        PayableDocumentsCirculation = 7,
    }
}
