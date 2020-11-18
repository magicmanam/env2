namespace env2.Core.Web
{
    public static class EnvironmentExtensions
    {
        public static string Link(this Environment environment, string linkWithoutQueryStrings, params string[] queryParameters)
        {
            return Core.Link(environment?.Alias, linkWithoutQueryStrings, queryParameters);
        }
    }
}
