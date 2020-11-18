using env2.Core;

public static class EnvironmentExtensions
{
    public static int GetMenuGroup(this Environment environment)
    {
        return 1;
    }

    public static string GetMenuGroupName(this Environment environment)
    {
        return $"Group #{environment.GetMenuGroup()}";
    }
}