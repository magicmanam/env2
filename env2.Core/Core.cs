using System.Text;
using WebMatrix.Data;

namespace env2.Core
{
    public static class Core
    {
        /// <summary>
        /// Gets env2-service database.
        /// </summary>
        /// <returns></returns>
        public static Database GetDB()
        {
            return Core.GetDB($"Server=localhost; Database=env2; Integrated Security=SSPI");
        }

        /// <summary>
        /// Opens database with provided connection string.
        /// </summary>
        /// <param name="connectionString">Connection string.</param>
        /// <returns></returns>
        public static Database GetDB(string connectionString)
        {
            return Database.OpenConnectionString(connectionString, "System.Data.SqlClient");
        }

        /// <summary>
        /// Opens database on the provided server.
        /// </summary>
        /// <param name="server">Server name.</param>
        /// <param name="database">Database name.</param>
        /// <returns></returns>
        public static Database GetDB(string server, string database)
        {
            return Core.GetDB($"Server={server}; Database={database}; Integrated Security=SSPI");
        }

        public static string Link(string environmentAlias, string linkWithoutQueryParameters, params string[] queryParameters)
        {
            var builder = new StringBuilder($"{linkWithoutQueryParameters}?");

            foreach (var parameter in queryParameters)
            {
                builder.Append(parameter);
                builder.Append("&");
            }

            builder.Append($"env={environmentAlias}");
            return builder.ToString();
        }
    }
}
