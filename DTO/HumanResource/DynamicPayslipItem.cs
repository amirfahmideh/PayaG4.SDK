using System;
using System.Collections.Generic;
using System.Text;

namespace PayaG4.SDK.DTO.HumanResource;

public class DynamicPayslipItem
{
    public string Title { get; set; }
    public string Date { get; set; }
    public decimal? PriceNumber { get; set; }
    public string Price { get; set; }
    public byte FirstSort { get; set; }
    public byte SecondSort { get; set; }
    public bool IsCash { get; set; } = true;
    public DynamicPayslipItem()
    {

    }
    public DynamicPayslipItem(string title, string date, string price, decimal priceNumber, byte firstSort, byte secondSort, bool isCash = true)
    {
        Title = title;
        Date = date;
        Price = price;
        PriceNumber = priceNumber;
        FirstSort = firstSort;
        SecondSort = secondSort;
        IsCash = isCash;
    }
}
