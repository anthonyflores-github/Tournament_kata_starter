namespace Tournaments.Tests.Utils
{
    using System.Net;

    public class Response<T>
    {

        public Response(HttpStatusCode statusCode, T content)
        {
            StatusCode = statusCode;
            Content = content;
        }
        public T Content { get; }
        public HttpStatusCode StatusCode { get; }
    }
}