using HutongGames.PlayMaker;
using KorzUtils.Helper;
using System;

namespace KorzUtils.Data;

/// <summary>
/// Represents a simple state action for a fsm that executes a method
/// </summary>
public class GenericFsmStateAction : FsmStateAction
{
	#region Properties

    /// <summary>
    /// Gets or sets the action that should be executed upon entering the state action.
    /// </summary>
	public Action ToExecute { get; set; }

    #endregion

    #region Methods

    public override void OnEnter()
    {
        try
        {
            ToExecute?.Invoke();
        }
        catch (Exception exception)
        {
            LogHelper.Write<KorzUtils>("Failed to execute action: " + exception.ToString(), Enums.LogType.Error);
        }
        Finish();
    }
    
    #endregion
}
