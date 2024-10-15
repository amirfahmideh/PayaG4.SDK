using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using PersianUtilCore.Extension;

namespace PayaG4.SDK.DTO.CashAndBank
{
    public class ReceiptReceiveTransactionItemDTO
    {
        [Display(Name = "کلید ردیف")]
        public long Id { get; set; }

        [Display(Name = "نوع برگه")]
        public TransactionTypeEnum TrsTransactionHeaderType { get; set; }
        public string TrsTransactionHeaderTypeTitle => TrsTransactionHeaderType.GetDisplayName();

        [Display(Name = "شماره برگه")]
        public int TrsTransactionHeaderNo { get; set; }

        [Display(Name = "نوع سند")]
        public string BankDocumentDescription { get; set; }

        [Display(Name = "شماره سند")]
        public string DocNo { get; set; }

        [Display(Name = "مبلغ")]
        public decimal Price { get; set; }

        [Display(Name = "عنوان ارز")]
        public string CurrencyTitle { get; set; }

        [Display(Name = "مبلغ ارز")]
        public decimal? CurrencyPrice { get; set; }

        [Display(Name = "کد پرداخت کننده")]
        public long PayerBusinessEntityCode { get; set; }

        [Display(Name = "نام پرداخت کننده")]
        public string PayerBusinessEntityTitle { get; set; }

        [Display(Name = "شرح ردیف")]
        public string Description { get; set; }
        public List<ReceiptReceiveTransactionItemDetailDTO> TransactionItemDetails { get; set; }
    }
}
