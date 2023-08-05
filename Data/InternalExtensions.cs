namespace KorzUtils.Data;

/// <summary>
/// Provides extensions for objects of this library.
/// </summary>
public static class InternalExtensions
{
    internal static bool Match(this string callValue, string comparision, bool caseSensitive = false)
    {
        if (!caseSensitive)
        {
            callValue = callValue.ToUpper();
            comparision = comparision.ToUpper();
        }

        if (comparision == "*" || comparision == "**")
            return true;
        else if (comparision.StartsWith("*") && comparision.EndsWith("*"))
            return callValue.Contains(comparision.Substring(1, comparision.Length - 2));
        else if (comparision.StartsWith("*"))
            return callValue.EndsWith(comparision.Substring(1));
        else if (comparision.EndsWith("*"))
            return callValue.StartsWith(comparision.Substring(0, comparision.Length - 1));
        else
            return string.Equals(callValue, comparision);
    }

    #region FsmTransitionData

    /// <summary>
    /// Extends the <see cref="FsmTransitionData"/> with a target state.
    /// </summary>
    public static FsmTransitionData WithTargetState(this FsmTransitionData transitionData, string targetState)
    {
        transitionData.TargetState = targetState;
        return transitionData;
    }

    /// <summary>
    /// Extends the <see cref="FsmTransitionData"/> with an event name.
    /// </summary>
    public static FsmTransitionData WithEventName(this FsmTransitionData transitionData, string eventName)
    {
        transitionData.EventName = eventName;
        return transitionData;
    }

    #endregion
}
