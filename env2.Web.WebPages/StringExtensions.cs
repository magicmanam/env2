using System.Web.WebPages;

namespace env2.Web.WebPages
{
    public static class StringExtensions
    {
        public static bool IsNotEmpty(this string value)
        {
            return !(value ?? string.Empty).IsEmpty();
        }
    }
}
