using System;
using System.ComponentModel.DataAnnotations;

namespace PayaG4.SDK.DTO.CashAndBank
{
    public class ReceiptReceiveTransactionItemDetailDTO
    {
        [Display(Name = "کد پرداخت کننده")]
        public long PayerBusinessEntityCode { get; set; }

        [Display(Name = "نام پرداخت کننده")]
        public string PayerBusinessEntityTitle { get; set; }

        [Display(Name = "مبلغ")]
        public decimal Price { get; set; }

        [Display(Name = "عنوان ارز")]
        public string CurrencyTitle { get; set; }

        [Display(Name = "مبلغ ارز")]
        public decimal? CurrencyPrice { get; set; }

        [Display(Name = "توضیحات")]
        public string Description { get; set; }

    }
}
