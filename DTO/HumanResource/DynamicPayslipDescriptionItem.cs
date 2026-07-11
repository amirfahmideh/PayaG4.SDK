namespace PayaG4.SDK.DTO.HumanResource;

public class DynamicPayslipDescriptionItem
{
    public string Title { get; set; }
    public string Description { get; set; }
    public byte FirstSort { get; set; }
    public byte SecondSort { get; set; }

    public DynamicPayslipDescriptionItem()
    {

    }
    public DynamicPayslipDescriptionItem(string title, string description, byte firstSort, byte secondSort)
    {
        Title = title;
        Description = description;
        FirstSort = firstSort;
        SecondSort = secondSort;
    }
}

