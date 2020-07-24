using System.Web;

namespace env2.Web
{
    public class Env2HtmlHelper
    {
        public IHtmlString Env2Label
        {
            get
            {
                return new HtmlString("E=nv<sup>2</sup>");
            }
        }
    }
}
