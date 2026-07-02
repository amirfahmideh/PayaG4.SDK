namespace PayaG4.SDK.DTO.General;

public class GridData<T> where T : class
{
    public int TotalCount { get; set; }
    public List<T> Items { get; set; } = [];
}
