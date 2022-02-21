namespace daemonapp.apps.ScottHome;

public class StateEnums
{
    public enum PersonPresence
    {
        home,
        not_home
    }

    public enum HomePresence
    {
        occupied,
        not_occupied
    }

    public enum LockState
    {
        locked,
        unlocked
    }
    
    public static LockState ConvertToLockState(string? status)
    {
        LockState currentState;
        if (Enum.TryParse(status, out currentState))
            return currentState;

        return LockState.unlocked;
    }

    public static HomePresence ConvertToHomePresence(string? status)
    {
        HomePresence currentState;
        if (Enum.TryParse(status, out currentState))
            return currentState;

        return HomePresence.not_occupied;
    }
}