using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace PayaG4.SDK.DTO.CashAndBank
{
    public class ListReceiptReceiveTransactionItemByParamsDTO
    {

        [Display(Name = "تاریخ و زمان وصول از")]
        [Required(ErrorMessage = "تاریخ و زمان وصول از را وارد کنید")]
        public DateTime ReceiptDateTimeFrom { get; set; }

        [Display(Name = "تاریخ و زمان وصول تا")]
        [Required(ErrorMessage = "تاریخ و زمان وصول تا را وارد کنید")]
        public DateTime ReceiptDateTimeTo { get; set; }

        [Display(Name = "مبلغ")]
        [Required(ErrorMessage = "مبلغ را وارد کنید")]
        public decimal Price { get; set; }

        [Display(Name = "کد پرداخت کننده")]
        public long? PayerBusinessEntityCode { get; set; }

        [Display(Name = "شماره سند")]
        [Required(ErrorMessage = "َشماره سند را وارد کنید")]
        public string DocNo { get; set; }

        [Display(Name = "سال مالی")]
        public int? FYearId { get; set; }

    }
}
