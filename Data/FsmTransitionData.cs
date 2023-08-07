using HutongGames.PlayMaker;

namespace KorzUtils.Data;

/// <summary>
/// Represents data for creating transitions between fsm states.
/// </summary>
public class FsmTransitionData
{
	#region Constructors

	internal FsmTransitionData() { }

	#endregion

	#region Properties

	/// <summary>
	/// Gets or sets the event that should be used
	/// </summary>
	public string EventName { get; set; }

	/// <summary>
	/// Gets or sets the target state to which the fsm should transition to, when the event <see cref="EventName"/> is fired.
	/// </summary>
	public string TargetState { get; set; }

	#endregion

	#region Methods

	/// <summary>
	/// Creates new transition data from the target state.
	/// </summary>
	public static FsmTransitionData FromTargetState(string targetState) => new() { TargetState= targetState };

	#endregion

	#region Operators

	public static bool operator ==(FsmTransitionData transitionData, FsmTransition transition)
	{
		if (transitionData is null && transition is not null)
			return false;
        if (transitionData is not null && transition is null)
            return false;
		if (transitionData is null && transition is null)
			return true;
		return transitionData.EventName == transition.EventName && transitionData.TargetState == transition.ToState;
    }

	public static bool operator !=(FsmTransitionData transitionData, FsmTransition transition)
		=> !(transitionData == transition);

    #endregion
}
