using System;
using System.Web;

namespace env2.Core.Web
{
    public static class HttpOnlyCookie
    {
        public static HttpCookie Create(string name, string value, DateTime? expires = null)
        {
            return new HttpCookie(name, value)
            {
                HttpOnly = true,
                Expires = expires ?? DateTime.MaxValue
            };
        }
    }
}
