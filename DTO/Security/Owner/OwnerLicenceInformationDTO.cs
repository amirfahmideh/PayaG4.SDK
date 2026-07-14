namespace PayaG4.SDK.DTO.Security;

public class OwnerLicenceInformationDTO
{
    public string Title { get; set; } = default!;
    public long Id { get; set; }
    public long LicenceOwnerId { get; set; }
}
