namespace PayaG4.SDK.Exceptions;
public class BadRequestException : Exception
{
    public BadRequestException()
    {

    }
    public BadRequestException(string implementTypeTitle)
    : base(implementTypeTitle)
    {

    }
    public BadRequestException(string implementTypeTitle, Exception innerException)
    : base(implementTypeTitle, innerException)
    {

    }
}