using HutongGames.PlayMaker;
using KorzUtils.Helper;
using System;
using System.Collections.Generic;

namespace KorzUtils.Data;

/// <summary>
/// Represents a simple state action for a fsm that executes a method
/// </summary>
public class GenericFsmStateAction : FsmStateAction
{
    public GenericFsmStateAction() { }

    public GenericFsmStateAction(Action action) => ToExecute = action;

    #region Properties

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

    #region Operators

    public static implicit operator GenericFsmStateAction(Action action) => new() { ToExecute = action };

    #endregion
}
