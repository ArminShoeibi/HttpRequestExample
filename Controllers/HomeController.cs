using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HttpRequestExample.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace HttpRequestExample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string firstName, string lastName)
        {
            HttpRequestDto httpRequestDto = new()
            {
                QueryStringsCollection = Request.Query,
                RouteValues = Request.RouteValues,
                QueryStrings = Request.QueryString,
                Path = Request.Path,
                PathBase = Request.PathBase,
                Host = Request.Host,
                ContentLength = Request.ContentLength,
                ContentType = Request.ContentType,
                IsHttps = Request.IsHttps,
                Method = Request.Method,
                Scheme = Request.Scheme,
                Cookies = Request.Cookies, // Set some cookies to see it.
                Headers = Request.Headers
            };
            return Json(httpRequestDto);
        }
    }
}
