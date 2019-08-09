using Microsoft.AspNetCore.Http;
using System;
using System.Linq;

namespace AdminAPI.Extensions
{
    public static class GenericExtensions
    {
        public static string GetUserId(this HttpContext httpContext)
        {
            if(httpContext.User == null)
            {
                return string.Empty;
            }

            return httpContext.User.Claims.Single(x => x.Type == "id").Value;
        }
    }
}
