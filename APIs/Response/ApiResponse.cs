using System.Net;

namespace APIs.Response;

public class ApiResponse<T>
{
    public required string Message { get; set; }
    public required int StatusCode { get; set; }
    public T? Data { get; set; }
}