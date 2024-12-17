using System.ComponentModel.DataAnnotations;

namespace PayaG4.SDK.DTO.AccTransaction;
public enum TfCardDocumentTypeEnum
{

    [Display(Name = "سند حسابداری")]
    Acc = 1,

    [Display(Name = "دریافت سند")]
    ReceiveDocuments = 2,

    [Display(Name = "پرداخت سند")]
    PayDocuments = 3,


    [Display(Name = "دریافت صندوق")]
    GetCash = 4,

    [Display(Name = "پرداخت صندوق")]
    PayCash = 5,

    [Display(Name = "گردش اسناد دریافتنی")]
    ReceivableDocumentsCirculation = 6,


    [Display(Name = "گردش اسناد پرداختنی")]

    PayableDocumentsCirculation = 7,

    [Display(Name = "تنخواه")]
    PettyCash = 8,

    [Display(Name = "رسید")]
    Receipt = 9,

    [Display(Name = "برگشت از رسید")]
    ReturnFromReceipt = 10,

    [Display(Name = "اضافه موجودی")]
    InventoryOverPlus = 11,

    [Display(Name = "متمم بدهکار")]
    DebitSupplement = 12,

    [Display(Name = "حواله")]
    Issue = 13,

    [Display(Name = "برگشت از حواله")]
    ReturnFromIssue = 14,

    [Display(Name = "انتقال بین انبار")]
    TransferBetweenWarehouse = 15,

    [Display(Name = "کسری موجودی")]
    InventoryDeficit = 16,

    [Display(Name = "متمم بستانکار")]
    CreditSupplement = 17,

    [Display(Name = "مصرف مستقیم")]
    DirectConsumption = 18,

    [Display(Name = "صورتحساب فروش")]
    SaleInvoice = 19,

    [Display(Name = "برگشت از صورتحساب فروش")]
    ReturnFromSaleInvoice = 20,


    [Display(Name = "نقل از قبل")]
    Remained = 21,

    [Display(Name = "اعلامیه")]
    AccStatement = 22
}
