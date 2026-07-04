public class ServiceConfiguration
{
    public required string ApiServerUrl { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }

    public bool IsValidApiServerUrl => !string.IsNullOrEmpty(ApiServerUrl);
    public bool IsValidLoginInfo => !string.IsNullOrEmpty(ApiServerUrl) && !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password);
}