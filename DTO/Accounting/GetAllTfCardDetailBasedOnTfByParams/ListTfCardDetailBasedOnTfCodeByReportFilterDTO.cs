using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PayaG4.SDK.DTO.General;



namespace PayaG4.SDK.DTO.AccTransaction
{
    public class ListTfCardDetailBasedOnTfCodeByReportFilterDTO
    {
        [Required]
        public AgGridParameter GridParameter { get; set; }

        [Required]
        public TfLevelNumberEnum TfLevel { get; set; } = TfLevelNumberEnum.One;

        [Required]
        public string TfCode { get; set; }
        public long? CurrencyCode { get; set; }
        public List<int> FYearIdList { get; set; }
        public List<int> CategoryIdList { get; set; }
        public List<RegisterStatusEnum> RegisterStatusList { get; set; }
        public List<int> ReferenceList { get; set; }
        public List<TfCardReportSubSystemTypeEnum> SourceDocumentList { get; set; }
        public List<AccDocumentTypeEnum> DocumentTypeList { get; set; }

        [Required]
        public DateTime DocumentDateFrom { get; set; }

        [Required]
        public DateTime DocumentDateTo { get; set; }
        public long? KlCodeFrom { get; set; }
        public long? KlCodeTo { get; set; }
        public long? MnCodeFrom { get; set; }
        public long? MnCodeTo { get; set; }
        public string TfLevel1CodeFrom { get; set; }
        public string TfLevel1CodeTo { get; set; }
        public string TfLevel2CodeFrom { get; set; }
        public string TfLevel2CodeTo { get; set; }
        public string TfLevel3CodeFrom { get; set; }
        public string TfLevel3CodeTo { get; set; }
        public string TfLevel4CodeFrom { get; set; }
        public string TfLevel4CodeTo { get; set; }
        public string TfLevel5CodeFrom { get; set; }
        public string TfLevel5CodeTo { get; set; }
        public string TfLevel6CodeFrom { get; set; }
        public string TfLevel6CodeTo { get; set; }
        public List<long> TfLevel1CategoryIdList { get; set; }
        public List<long> TfLevel2CategoryIdList { get; set; }
        public List<long> TfLevel3CategoryIdList { get; set; }
        public List<long> TfLevel4CategoryIdList { get; set; }
        public List<long> TfLevel5CategoryIdList { get; set; }
        public List<long> TfLevel6CategoryIdList { get; set; }

    }
}
