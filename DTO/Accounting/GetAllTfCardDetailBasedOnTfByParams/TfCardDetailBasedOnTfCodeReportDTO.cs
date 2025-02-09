
using System.Collections.Generic;
namespace PayaG4.SDK.DTO.AccTransaction
{
    public class TfCardDetailBasedOnTfCodeReportDTO
    {
        public long TotalCount { get; set; }
        public decimal SumDebit { get; set; } = 0;
        public decimal SumCredit { get; set; } = 0;
        public decimal RemainingBefore { get; set; } = 0;
        public decimal Remaining => SumDebit - SumCredit + RemainingBefore;
        public IEnumerable<TfCardDetailReportItemDTO> Items { get; set; }
    }
}
