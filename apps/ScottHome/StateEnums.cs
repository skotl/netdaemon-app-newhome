using System.IO;

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

    public enum BinaryState
    {
        off, 
        on
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

    public static bool ConvertToBinaryState(string? status)
    {
        if (!string.IsNullOrWhiteSpace(status))
        {
            if (string.Compare(status, BinaryState.off.ToString(), StringComparison.InvariantCultureIgnoreCase) == 0)
                return false;
            if (string.Compare(status, BinaryState.on.ToString(), StringComparison.InvariantCultureIgnoreCase) == 0)
                return true;
        }

        throw new InvalidDataException($"Status='{status}' is not a valid {nameof(BinaryState)}");
    }
}