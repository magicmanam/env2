using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace env2.Core.Web
{
    /// <summary>
    /// Represents env2 module with youseful functionality.
    /// </summary>
    public class EnvModule
    {
        /// <summary>
        /// Gets or sets whether specified module is opened in Env2 portal.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets landing page as entry point to the module.
        /// </summary>
        public string LandingPage { get; set; }

        /// <summary>
        /// Gets or sets module name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets module tip.
        /// </summary>
        public string Tip { get; set; }
    }
}
