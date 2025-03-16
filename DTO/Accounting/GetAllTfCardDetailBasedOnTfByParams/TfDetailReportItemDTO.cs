
using PayaG4.SDK.DTO.AccTransaction;
using PersianUtilCore.Extension;
using PersianUtilCore.Extension.Datetime;
using System;
using System.Collections.Generic;

namespace PayaG4.SDK.DTO.AccTransaction
{
    public class TfCardDetailReportItemDTO
    {
        // public long? TfId { get; set; }
        // public string TfCode { get; set; }
        // public string TfName { get; set; }
        //public int IsDebit { get; set; }

        public bool IsDebit { get; set; }
        public int? AccNo { get; set; }
        // public DateTime? AccDate { get; set; }
        // public string AccDateFa => this.AccDate.HasValue ? this.AccDate.Value.ToStringPersian(PersianStringType.SimpleFullDigit) : "";

        public DateTime DocumentDate { get; set; }
        public string DocumentDateFa => this.DocumentDate.ToStringPersian(PersianStringType.SimpleFullDigit);

        public int DocumentNo { get; set; }
        public string Description { get; set; }

        public long Id { get; set; }
        public int? CurrencyId { get; set; }
        // public int Type { get; set; }

        public TfCardDocumentTypeEnum DocumentType { get; set; }

        public string DocumentTypeTitle => DocumentType.GetDisplayName();


        public string DescriptionString
        {
            get
            {
                return DocumentType == TfCardDocumentTypeEnum.Acc ? Description :
                       DocumentType == TfCardDocumentTypeEnum.ReceiveDocuments ? $"سیستم نقد و بانک - دریافت سند با شماره {DocumentNo} - {Description}" :
                       DocumentType == TfCardDocumentTypeEnum.PettyCash ? $"سیستم نقد و بانک - صورت هزینه تنخواه با شماره {DocumentNo} - {Description}" :
                       DocumentType == TfCardDocumentTypeEnum.PayDocuments ? $"سیستم نقد و بانک - پرداخت سند با شماره {DocumentNo} - {Description}" :
                       DocumentType == TfCardDocumentTypeEnum.GetCash ? $"سیستم نقد و بانک - دریافت صندوق با شماره {DocumentNo} - {Description}" :
                       DocumentType == TfCardDocumentTypeEnum.PayCash ? $"سیستم نقد و بانک - پرداخت صندوق با شماره {DocumentNo} - {Description}" :
                       DocumentType == TfCardDocumentTypeEnum.ReceivableDocumentsCirculation ? $"سیستم نقد و بانک - گردش اسناد دریافتنی با شماره {DocumentNo} - {Description}" :
                       DocumentType == TfCardDocumentTypeEnum.PayableDocumentsCirculation ? $"سیستم نقد و بانک - گردش اسناد پرداختنی با شماره {DocumentNo} - {Description}" :
                       DocumentType == TfCardDocumentTypeEnum.Receipt ? $"سیستم انبار- رسید با شماره {DocumentNo}- {Description}" :
                       DocumentType == TfCardDocumentTypeEnum.ReturnFromReceipt ? $"سیستم انبار- برگشت از رسید با شماره {DocumentNo}- {Description}" :
                       DocumentType == TfCardDocumentTypeEnum.Issue ? $"سیستم انبار- حواله با شماره {DocumentNo}- {Description}" :
                       DocumentType == TfCardDocumentTypeEnum.ReturnFromIssue ? $"سیستم انبار- برگشت از حواله با شماره {DocumentNo}- {Description}" :
                       DocumentType == TfCardDocumentTypeEnum.InventoryOverPlus ? $"سیستم انبار- اضافی موجودی با شماره {DocumentNo}- {Description}" :
                       DocumentType == TfCardDocumentTypeEnum.InventoryDeficit ? $"سیستم انبار- کسری موجودی با شماره {DocumentNo}- {Description}" :
                       DocumentType == TfCardDocumentTypeEnum.DebitSupplement ? $"سیستم انبار- متمم بدهکار با شماره {DocumentNo}- {Description}" :
                       DocumentType == TfCardDocumentTypeEnum.CreditSupplement ? $"سیستم انبار- متمم بستانکار با شماره {DocumentNo}- {Description}" :
                       DocumentType == TfCardDocumentTypeEnum.TransferBetweenWarehouse ? $"سیستم انبار- انتقال بین انبار با شماره {DocumentNo}- {Description}" :
                       DocumentType == TfCardDocumentTypeEnum.DirectConsumption ? $"سیستم انبار- مصرف مستقیم با شماره {DocumentNo}- {Description}" :
                       DocumentType == TfCardDocumentTypeEnum.SaleInvoice ? $"سیستم فروش- صورتحساب فروش با شماره {DocumentNo} - {Description}" :
                       DocumentType == TfCardDocumentTypeEnum.ReturnFromSaleInvoice ? $"سیستم فروش- برگشت از صورتحساب فروش با شماره {DocumentNo} - {Description}" : string.Empty;
            }
        }

        //Accounts
        public long? KlId { get; set; }
        public long? MnId { get; set; }
        public long? TfLevel1Id { get; set; }
        public long? TfLevel2Id { get; set; }
        public long? TfLevel3Id { get; set; }
        public long? TfLevel4Id { get; set; }
        public long? TfLevel5Id { get; set; }
        public int? KlCode { get; set; }
        public int? MnCode { get; set; }
        public string TfLevel1Code { get; set; }
        public string TfLevel2Code { get; set; }
        public string TfLevel3Code { get; set; }
        public string TfLevel4Code { get; set; }
        public string TfLevel5Code { get; set; }
        public string KlName { get; set; }
        public string MnName { get; set; }
        public string TfLevel1Name { get; set; }
        public string TfLevel2Name { get; set; }
        public string TfLevel3Name { get; set; }
        public string TfLevel4Name { get; set; }
        public string TfLevel5Name { get; set; }

        //Debit/Credit
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public decimal? DebitCurrency { get; set; }
        public decimal? CreditCurrency { get; set; }
        public decimal Remained { get; set; }
        public decimal? RemainedCurrency { get; set; }

    }
}
