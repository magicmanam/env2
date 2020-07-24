using env2.Core;
using System.Web.WebPages;

namespace env2.Web.WebPages
{
    /// <summary>
    /// Contains extensions for WebPageBase class.
    /// </summary>
    public static class WebPageBaseExtensions
    {
        /// <summary>
        /// Sets page title and optional module name (can be used to highlight menu item or for other features).
        /// </summary>
        /// <param name="page"><see cref="WebPageBase"/> instance.</param>
        /// <param name="title">Page title to be specified.</param>
        /// <param name="module">Optional module name to associate with the page.</param>
        public static void SetTitle(this WebPageBase page, string title, string module = null)
        {
            page.Page.Title = title;
            page.Page.Module = module;// Maybe in abstract way? page.Page - abstract
        }

        /// <summary>
        /// Gets current environment instance.
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public static Environment GetEnvironment(this WebPageBase page)
        {
            return page.Page.Env;
        }

        /// <summary>
        /// Writes 
        /// </summary>
        /// <param name="page"></param>
        /// <param name="response"></param>
        public static void WriteCustomResponse(this WebPageBase page, object response)
        {
            page.Response.Clear();
            page.Response.Write(response);
            page.Layout = null;
        }
    }
}
