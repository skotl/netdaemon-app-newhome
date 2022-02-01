namespace daemonapp.apps.ScottHome.Helpers;

public static class SafeMethodExecuteWithLogging
{
    public delegate void MethodSignature();

    public static void Execute(MethodSignature method, ILogger logger)
    {
        try
        {
            method();
        }
        catch (Exception ex)
        {
            logger.LogError(ex, ex.Message);
        }
    }
}