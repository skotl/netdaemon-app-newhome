namespace daemonapp.apps.ScottHome.Helpers;

public class EnvironmentHelper
{
    public static bool IsDevelopment =>
        string.Compare(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT"), "Development",
            StringComparison.InvariantCultureIgnoreCase) == 0;

}