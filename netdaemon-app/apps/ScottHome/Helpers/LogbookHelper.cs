namespace daemonapp.apps.ScottHome.Helpers;

public static class LogbookHelper
{
    public static void WriteLogbook(this IHaContext ha, string entityId, string message)
    {
        ha.CallService("logbook", "log",
            data: new
            {
                domain = "automation", entity_id = entityId, name = entityId, message = message
            });
    }
}