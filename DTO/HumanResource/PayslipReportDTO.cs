using System.Collections.Generic;
using System.Xml.Linq;

namespace PayaG4.SDK.DTO.HumanResource;

public class PayslipReportDTO
{
    public long? TotalCount { get; set; }
    public string FinanceGroup { get; set; }
    public string Month { get; set; }
    public string Year { get; set; }
    public IEnumerable<PayslipReportItemDTO> Items { get; set; }
}
