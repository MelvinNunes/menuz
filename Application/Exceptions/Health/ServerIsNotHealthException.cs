namespace Application.Exceptions.Health;

public class ServerIsNotHealthException : HttpException
{
    public ServerIsNotHealthException() : base(503, "The server is not healthy")
    {
    }

    public ServerIsNotHealthException(string message) : base(503, message)
    {
    }

    public ServerIsNotHealthException(string message, Exception innerException) : base(503, message, innerException)
    {
    }
}