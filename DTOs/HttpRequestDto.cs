using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace HttpRequestExample.DTOs
{
    public record HttpRequestDto
    {
        public string Scheme { get; init; }
        public string Method { get; init; }
        public string ContentType { get; init; }
        public long? ContentLength { get; init; }
        public bool IsHttps { get; init; }

        public IRequestCookieCollection Cookies { get; init; }
        public IHeaderDictionary Headers { get; init; }
        public IQueryCollection QueryStringsCollection { get; init; }

        public QueryString QueryStrings { get; init; }
        public PathString Path { get; init; }
        public PathString PathBase { get; init; }
        public HostString Host { get; init; }

        public RouteValueDictionary RouteValues { get; init; }
    }
}
