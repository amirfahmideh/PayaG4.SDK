using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PayaG4.SDK.DTO.CashAndBank
{
    public class ListLatestReceiptReceiveTransactionItemByParamsDTO
    {
        [Display(Name = "شماره سند")]
        public string[] DocNo { get; set; }

        [Display(Name = "نوع سند")]
        public int? BankDocumentCode { get; set; }

        [Display(Name = "کنترل بخش انتهایی شماره سند")]
        public int? CompareSuffixDocNoNumber { get; set; }

        [Display(Name = "سال مالی")]
        public int? FYearId { get; set; }
    }
}
