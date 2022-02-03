using NetDaemon.HassModel.Entities;

namespace daemonapp.apps.ScottHome.Helpers;

public static class SafeMethodExecuteWithLogging
{
    public delegate void SimpleMethod();

    public delegate void MethodWithWithStateChange(StateChange arg);

    public static void Execute(SimpleMethod method, ILogger logger)
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
    
    public static void Execute(MethodWithWithStateChange method, ILogger logger, StateChange arg)
    {
        try
        {
            method(arg);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, ex.Message);
        }
    }
}