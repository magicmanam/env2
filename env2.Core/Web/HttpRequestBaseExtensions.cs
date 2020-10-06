using System.Web;

namespace env2.Core.Web
{
    public static class HttpRequestBaseExtensions
    {
        public static string GetEnvironmentAlias(this HttpRequestBase request)
        {
            return request[Environment.Marker];
        }
    }
}
