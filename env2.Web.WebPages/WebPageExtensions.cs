using env2.Core;
using System.Web.WebPages;

namespace env2.Web.WebPages
{
    public static class WebPageExtensions
    { 
        public static Env2HtmlHelper Env2Html(this WebPage page)
        {
            return new Env2HtmlHelper();
        }
    }
}
