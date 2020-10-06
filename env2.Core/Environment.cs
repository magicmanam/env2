using System.Collections.Generic;

namespace env2.Core
{
    /// <summary>
    /// Represents environment's object.
    /// </summary>
    public class Environment
    {
        public const string Marker = "env";

        /// <summary>
        /// Initializes a new instance of the <see cref="Environment"/> class.
        /// </summary>
        /// <param name="alias">Environment's alias.</param>
        public Environment(string alias)
        {
            this.Alias = alias;
        }

        /// <summary>
        /// Gets environment's alias.
        /// </summary>
        public string Alias { get; private set; }

        /// <summary>
        /// Gets full environment name.
        /// </summary>
        public string Name { get; private set; }

        #region Part of other modules

        /// <summary>
        /// Gets list of boxes associated with the current environment.
        /// </summary>
        public IEnumerable<string> Boxes { get; private set; }

        /// <summary>
        /// Gets SQL server name associated with the current environment.
        /// </summary>
        public string SqlServer { get; private set; }

        #endregion
    }
}
