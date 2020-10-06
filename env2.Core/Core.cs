using System.Text;

namespace env2.Core
{
    public static class Core
    {
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
