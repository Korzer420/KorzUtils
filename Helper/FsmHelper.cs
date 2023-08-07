using HutongGames.PlayMaker;
using HutongGames.PlayMaker.Actions;
using KorzUtils.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace KorzUtils.Helper;

/// <summary>
/// Provides function and extensions for fsm.
/// </summary>
public static class FsmHelper
{
    #region FsmAction

    /// <summary>
    /// Check if the passed action is in the correct context for modifications. Leave unneeded values null.
    /// </summary>
    /// <param name="fsmName">The fsm in which the action should be.</param>
    /// <param name="gameObjectName">The name of the gameobject on which the fsm of this action is attached.</param>
    /// <param name="stateName">The name of the state in which this action should be.</param>
    /// <param name="action">The action for the comparison.</param>
    public static bool IsCorrectContext(this FsmStateAction action, string fsmName, string gameObjectName, string stateName)
    {
        if (!string.IsNullOrEmpty(fsmName) && !action.Fsm.Name.Match(fsmName))
            return false;
        if (!string.IsNullOrEmpty(gameObjectName) && !action.Fsm.GameObjectName.Match(gameObjectName))
            return false;
        if (!string.IsNullOrEmpty(stateName) && !action.State.Name.Match(stateName))
            return false;
        return true;
    }

    /// <summary>
    /// Wraps an action so it can be used as a fsm state action.
    /// </summary>
    public static FsmStateAction WrapAction(Action action)
        => new GenericFsmStateAction() { ToExecute = action };

    #endregion

    #region FsmState

    #region GetActions

    public static FsmStateAction GetFirstAction(this FsmState state) => state.Actions?.FirstOrDefault();

    public static T GetFirstAction<T>(this FsmState state) where T : FsmStateAction
        => state.Actions.FirstOrDefault(x => x is T) as T;

    public static FsmStateAction GetLastAction(this FsmState state) => state.Actions?.LastOrDefault();

    public static T GetLastAction<T>(this FsmState state) where T : FsmStateAction
        => state.Actions?.LastOrDefault(x => x is T) as T;

    public static FsmStateAction[] GetActions(this FsmState state) => state.Actions;

    public static T[] GetActions<T>(this FsmState state) where T : FsmStateAction => state.Actions?.Where(x => x is T)?
        .Select(x => x as T)?
        .ToArray();

    #endregion

    #region AddActions

    /// <summary>
    /// Adds actions to a fsm state.
    /// </summary>
    public static void AddActions(this FsmState state, params FsmStateAction[] actions)
    {
        if (!actions.Any())
            return;
        FsmStateAction[] newActions = state.Actions.Concat(actions).ToArray();
        state.Actions = newActions;
    }

    /// <summary>
    /// Adds actions to a fsm state.
    /// </summary>
    public static void AddActions(this FsmState state, IEnumerable<FsmStateAction> actions)
    {
        if (!actions.Any())
            return;
        FsmStateAction[] newActions = state.Actions.Concat(actions).ToArray();
        state.Actions = newActions;
    }

    /// <summary>
    /// Adds actions to a fsm state.
    /// </summary>
    public static void AddActions(this FsmState state, params Action[] actions)
    {
        if (!actions.Any())
            return;
        FsmStateAction[] newActions = state.Actions.Concat(actions.Select(x => new GenericFsmStateAction() { ToExecute = x })).ToArray();
        state.Actions = newActions;
    }

    /// <summary>
    /// Adds actions to a fsm state.
    /// </summary>
    public static void AddActions(this FsmState state, IEnumerable<Action> actions)
    {
        if (!actions.Any())
            return;
        FsmStateAction[] newActions = state.Actions.Concat(actions.Select(x => new GenericFsmStateAction() { ToExecute = x })).ToArray();
        state.Actions = newActions;
    }

    #endregion

    #region RemoveActions

    /// <summary>
    /// Removes all actions from a state.
    /// </summary>
    public static void RemoveAllActions(this FsmState state)
        => state.Actions = Array.Empty<FsmStateAction>();

    /// <summary>
    /// Removes all actions of the passed type.
    /// </summary>
    /// <typeparam name="T">The type of actions that should be removed.</typeparam>
    public static void RemoveActions<T>(this FsmState state) where T : FsmStateAction
    {
        FsmStateAction[] remainingActions = state.Actions.Where(x => x is not T).ToArray();
        state.Actions = remainingActions;
    }

    /// <summary>
    /// Removes the first appearance of an action
    /// </summary>
    /// <typeparam name="T">The type of actions that should be removed.</typeparam>
    public static void RemoveFirstAction<T>(this FsmState state) where T : FsmStateAction
        => state.RemoveActions<T>(0);

    /// <summary>
    /// Removes the last appearance of an action
    /// </summary>
    /// <typeparam name="T">The type of actions that should be removed.</typeparam>
    public static void RemoveLastAction<T>(this FsmState state) where T : FsmStateAction
        => state.RemoveActions<T>(state.GetActions<T>().Length - 1);

    /// <summary>
    /// Removes all actions at the passed indexes.
    /// </summary>
    /// <param name="indexToRemove">The indexes of the actions that should be removed.</param>
    public static void RemoveActions(this FsmState state, params int[] indexToRemove)
    {
        if (indexToRemove?.Any() != true)
            return;
        List<FsmStateAction> remainingActions = new();

        for (int actionIndex = 0; actionIndex < state.Actions.Length; actionIndex++)
            if (!indexToRemove.Contains(actionIndex))
                remainingActions.Add(state.Actions[actionIndex]);

        state.Actions = remainingActions.ToArray();
    }

    /// <summary>
    /// Removes all appearances of an action that appear in the passed list.
    /// </summary>
    /// <typeparam name="T">The type of actions that should be removed.</typeparam>
    /// <param name="indexToRemove">The indexes of the ACTION TYPE that should be removed. 
    /// This does not have to match the actual index of the actions in the state!</param>
    public static void RemoveActions<T>(this FsmState state, params int[] indexToRemove) where T : FsmStateAction
    {
        if (indexToRemove?.Any() != true || state.GetActions<T>().Length == 0)
            return;
        List<FsmStateAction> remainingActions = new();

        int currentActionTypeIndex = 0;
        foreach (FsmStateAction currentAction in state.Actions)
        {
            if (currentAction is T)
            {
                currentActionTypeIndex++;
                if (indexToRemove.Contains(currentActionTypeIndex))
                    continue;
            }
            remainingActions.Add(currentAction);
        }
        state.Actions = remainingActions.ToArray();
    }

    #endregion

    #region InsertActions

    /// <summary>
    /// Inserts the actions after the given index.
    /// <para>It is recommended to either create your own state that copies the needed actions 
    /// or just hook the actions via On.HutongGames.PlayMaker.Actions.*YourActionType*.OnEnter instead!</para>
    /// </summary>
    public static void InsertActions(this FsmState state, int startIndex, params Action[] actions)
    {
        if (!actions.Any())
            return;
        startIndex = Math.Max(0, startIndex);

        FsmStateAction[] currentActions = state.Actions;
        IEnumerable<FsmStateAction> wrappedActions = actions.Select(x => new GenericFsmStateAction() { ToExecute = x });
        if (startIndex >= currentActions.Length)
        {
            state.AddActions(wrappedActions);
            return;
        }
        FsmStateAction[] newActions = state.Actions.Take(startIndex)
            .Concat(wrappedActions)
            .Concat(state.Actions.Skip(startIndex))
            .ToArray();
        state.Actions = newActions;
    }

    /// <summary>
    /// Inserts the actions after the given index.
    /// <para>It is recommended to either create your own state that copies the needed actions 
    /// or just hook the actions via On.HutongGames.PlayMaker.Actions.*YourActionType*.OnEnter instead!</para>
    /// </summary>
    public static void InsertActions(this FsmState state, int startIndex, IEnumerable<Action> actions)
        => state.InsertActions(startIndex, actions?.ToArray());

    /// <summary>
    /// Inserts the actions after the given index.
    /// <para>It is recommended to either create your own state that copies the needed actions 
    /// or just hook the actions via On.HutongGames.PlayMaker.Actions.*YourActionType*.OnEnter instead!</para>
    /// </summary>
    public static void InsertActions(this FsmState state, int startIndex, params FsmStateAction[] actions)
    {
        if (!actions.Any())
            return;
        if (startIndex < 0)
            return;

        FsmStateAction[] currentActions = state.Actions;
        if (startIndex >= currentActions.Length)
        {
            state.AddActions(actions);
            return;
        }
        FsmStateAction[] newActions = state.Actions.Take(startIndex)
            .Concat(actions)
            .Concat(state.Actions.Skip(startIndex))
            .ToArray();
        state.Actions = newActions;
    }

    /// <summary>
    /// Inserts the actions after the given index.
    /// <para>It is recommended to either create your own state that copies the needed actions 
    /// or just hook the actions via On.HutongGames.PlayMaker.Actions.*YourActionType*.OnEnter instead!</para>
    /// </summary>
    public static void InsertActions(this FsmState state, int startIndex, IEnumerable<FsmStateAction> actions)
        => state.InsertActions(startIndex, actions?.ToArray());

    #endregion

    #region ReplaceActions

    /// <summary>
    /// Replaces the action at the index position with a wrapped action.
    /// </summary>
    /// <param name="index">The index at which the action should be inserted and the original deleted.</param>
    /// <param name="action">The action that should be wrapped for a state action.</param>
    public static void ReplaceAction(this FsmState state, int index, Action action)
        => state.ReplaceAction(index, new GenericFsmStateAction() { ToExecute = action });

    /// <summary>
    /// Replaces the action at the index position.
    /// </summary>
    /// <param name="index">The index at which the action should be inserted and the original deleted.</param>
    /// <param name="action">Thee action that should replace the original one.</param>
    public static void ReplaceAction(this FsmState state, int index, FsmStateAction action)
    {
        List<FsmStateAction> stateActions = state.Actions.ToList();
        if (index >= stateActions.Count)
        {
            state.AddActions(action);
            return;
        }
        stateActions.Insert(index, action);
        state.Actions = stateActions.ToArray();
    }

    #endregion

    #region Transition

    /// <summary>
    /// Adds a transition to a state. If the event doesn't exist already in the fsm, it will be added.
    /// If the state already has the transition, it will be adjusted.
    /// </summary>
    public static void AddTransition(this FsmState state, string eventName, string targetStateName)
    {
        if (string.IsNullOrEmpty(eventName))
            throw new ArgumentNullException(nameof(eventName));
        if (string.IsNullOrEmpty(targetStateName))
            throw new ArgumentNullException(nameof(targetStateName));
        FsmState targetState = state.Fsm.States.FirstOrDefault(x => x.Name == targetStateName);
        if (targetState == null)
            throw new ArgumentNullException($"Couldn't find state '{targetStateName}' in fsm");
        if (state.Transitions.Any(x => x.EventName == eventName))
        {
            state.AdjustTransition(eventName, targetStateName);
            return;
        }
        
        FsmTransition fsmTransition = new()
        {
            // This will automatically create the event if it does not already exist
            FsmEvent = FsmEvent.GetFsmEvent(eventName),
            ToState = targetStateName,
            ToFsmState = targetState
        };
        FsmTransition[] transitions = new FsmTransition[state.Transitions.Length + 1];
        state.Transitions.CopyTo(transitions, 0);
        transitions[transitions.Length - 1] = fsmTransition;
        state.Transitions = transitions;
    }

    /// <summary>
    /// Removes all transitions corresponding to the passed events.
    /// </summary>
    /// <param name="eventNames">The events/transitions to remove.</param>
    public static void RemoveTransitions(this FsmState state, params string[] eventNames)
        => state.Transitions = state.Transitions.Where(x => eventNames.Contains(x.EventName)).ToArray();

    /// <summary>
    /// Removes all matching transition by their name and event.
    /// </summary>
    /// <param name="state"></param>
    /// <param name="transitionData"></param>
    public static void RemoveTransitions(this FsmState state, params FsmTransitionData[] transitionData)
    {
        List<FsmTransition> fsmTransitions = new();
        foreach (FsmTransition transition in state.Transitions)
            if (!transitionData.Any(x => x == transition))
                fsmTransitions.Add(transition);
        state.Transitions = fsmTransitions.ToArray();
    }

    public static void RemoveTransitionsTo(this FsmState state, params string[] targetStates)
        => state.Transitions = state.Transitions.Where(x => targetStates.Contains(x.ToState)).ToArray();

    /// <summary>
    /// Move a transition from one state to another.
    /// </summary>
    public static void AdjustTransition(this FsmState state, string transitionName, string newState)
    {
        FsmTransition transition = state.Transitions.FirstOrDefault(x => string.Equals(x.FsmEvent.Name, transitionName));
        if (transition == null)
            throw new Exception($"Couldn't find transition {transitionName} in state {state.Name}");
        FsmState destination = state.Fsm.States.FirstOrDefault(x => string.Equals(x.Name, newState));
        transition.ToFsmState = destination ?? throw new Exception("Couldn't find destination state.");
        transition.ToState = destination?.Name;
    }

    /// <summary>
    /// Move transitions from one state to another.
    /// </summary>
    public static void AdjustTransition(this FsmState state, IEnumerable<FsmTransitionData> transitionData)
    {
        if (transitionData == null)
            throw new ArgumentNullException(nameof(transitionData));
        foreach (FsmTransitionData transitionRequest in transitionData)
            state.AdjustTransition(transitionRequest.EventName, transitionRequest.TargetState);
    }

    /// <summary>
    /// Move transitions from one state to another.
    /// </summary>
    public static void AdjustTransition(this FsmState state, params FsmTransitionData[] transitionData)
    {
        if (transitionData == null)
            throw new ArgumentNullException(nameof(transitionData));
        foreach (FsmTransitionData transitionRequest in transitionData)
            state.AdjustTransition(transitionRequest.EventName, transitionRequest.TargetState);
    }

    /// <summary>
    /// Adjust every transition from the current state to the target state.
    /// </summary>
    public static void AdjustTransitions(this FsmState state, string targetStateName)
    {
        foreach (FsmTransition transition in state.Transitions)
            state.AdjustTransition(transition.EventName, targetStateName);
    }

    /// <summary>
    /// Remove all transitions from a state.
    /// </summary>
    public static void ClearTransitions(this FsmState state) => state.Transitions = Array.Empty<FsmTransition>();

    /// <summary>
    /// Gets all transitions that START at this state.
    /// </summary>
    public static List<FsmTransitionData> GetTransitions(this FsmState state)
        => state.Transitions.Select(x => new FsmTransitionData() { EventName = x.EventName, TargetState = x.ToState }).ToList();

    #endregion

    #endregion

    #region PlayMakerFSM

    /// <summary>
    /// Gets a state present in a fsm or <see langword="null"/> if it doesn't exist.
    /// </summary>
    public static FsmState GetState(this PlayMakerFSM fsm, string stateName) => GetState(fsm.Fsm, stateName);

    #region AddState

    /// <summary>
    /// Tries to add a state to the fsm with a single custom action.
    /// </summary>
    public static void AddState(this PlayMakerFSM fsm, string stateName, Action action, params FsmTransitionData[] transitionData)
        => fsm.Fsm.AddState(stateName, action, transitionData);

    /// <summary>
    /// Tries to add a state to the fsm.
    /// </summary>
    public static void AddState(this PlayMakerFSM fsm, string stateName, IEnumerable<Action> actions, params FsmTransitionData[] transitionData)
        => fsm.Fsm.AddState(stateName, actions, transitionData);

    /// <summary>
    /// Tries to add a state to the fsm with a set of state actions.
    /// </summary>
    public static void AddState(this PlayMakerFSM fsm, string stateName, IEnumerable<FsmStateAction> actions, params FsmTransitionData[] transitionData)
        => fsm.Fsm.AddState(stateName, actions, transitionData);

    /// <summary>
    /// Tries to add a state to the fsm.
    /// </summary>
    public static void AddState(this PlayMakerFSM fsm, FsmState state, params FsmTransitionData[] transitionData) => fsm.Fsm.AddState(state, transitionData);

    #endregion

    /// <summary>
    /// Adds a new event to the fsm. If the event already exist, this will do nothing.
    /// </summary>
    public static void AddEvent(this PlayMakerFSM fsm, string eventName) => fsm.Fsm.AddEvent(eventName);

    /// <summary>
    /// Adds a variable to the fsm.
    /// </summary>
    /// <param name="variableName">The name the variable should have.</param>
    /// <param name="value">The value the variable should have.</param>
    public static void AddVariable<T>(this PlayMakerFSM fsm, string variableName, T value)
    {
        if (value is string stringValue)
        {
            List<FsmString> fsmStrings = fsm.FsmVariables.StringVariables.ToList();
            if (fsmStrings.Any(x => x.Name == variableName))
                return;
            fsmStrings.Add(new() { Name = variableName, Value = stringValue });
            fsm.FsmVariables.StringVariables = fsmStrings.ToArray();
        }
        else if (value is int intValue)
        {
            List<FsmInt> fsmInts = fsm.FsmVariables.IntVariables.ToList();
            if (fsmInts.Any(x => x.Name == variableName))
                return;
            fsmInts.Add(new() { Name = variableName, Value = intValue });
            fsm.FsmVariables.IntVariables = fsmInts.ToArray();
        }
        else if (value is float floatValue)
        {
            List<FsmFloat> fsmFloats = fsm.FsmVariables.FloatVariables.ToList();
            if (fsmFloats.Any(x => x.Name == variableName))
                return;
            fsmFloats.Add(new() { Name = variableName, Value = floatValue });
            fsm.FsmVariables.FloatVariables = fsmFloats.ToArray();
        }
        else if (value is bool boolValue)
        {
            List<FsmBool> fsmBools = fsm.FsmVariables.BoolVariables.ToList();
            if (fsmBools.Any(x => x.Name == variableName))
                return;
            fsmBools.Add(new() { Name = variableName, Value = boolValue });
            fsm.FsmVariables.BoolVariables = fsmBools.ToArray();
        }
        else if (value is Vector2 vector2Value)
        {
            List<FsmVector2> fsmVector2 = fsm.FsmVariables.Vector2Variables.ToList();
            if (fsmVector2.Any(x => x.Name == variableName))
                return;
            fsmVector2.Add(new() { Name = variableName, Value = vector2Value });
            fsm.FsmVariables.Vector2Variables = fsmVector2.ToArray();
        }
        else if (value is Vector3 vector3Value)
        {
            List<FsmVector3> fsmVector3 = fsm.FsmVariables.Vector3Variables.ToList();
            if (fsmVector3.Any(x => x.Name == variableName))
                return;
            fsmVector3.Add(new() { Name = variableName, Value = vector3Value });
            fsm.FsmVariables.Vector3Variables = fsmVector3.ToArray();
        }
        else if (value is GameObject gameObjectValue)
        {
            List<FsmGameObject> fsmGameObjects = fsm.FsmVariables.GameObjectVariables.ToList();
            if (fsmGameObjects.Any(x => x.Name == variableName))
                return;
            fsmGameObjects.Add(new() { Name = variableName, Value = gameObjectValue });
            fsm.FsmVariables.GameObjectVariables = fsmGameObjects.ToArray();
        }
        else
            LogHelper.Write($"Unable to add fsm variable from type '{value.GetType().Name}'. If fsm do support this value, report this to the mod developer.", Enums.LogType.Error);
    }

    #endregion

    #region Fsm

    /// <summary>
    /// Gets a state present in a fsm or <see langword="null"/> if it doesn't exist.
    /// </summary>
    public static FsmState GetState(this Fsm fsm, string stateName)
    {
        if (string.IsNullOrEmpty(stateName))
            throw new ArgumentNullException(nameof(stateName));
        return fsm.States.FirstOrDefault(x => x.Name == stateName);
    }

    #region AddState

    /// <summary>
    /// Tries to add a state to the fsm with a single custom action.
    /// </summary>
    public static void AddState(this Fsm fsm, string stateName, Action action, params FsmTransitionData[] transitionData)
    {
        // Validation
        if (string.IsNullOrEmpty(stateName))
            throw new ArgumentNullException(nameof(stateName));
        if (action == null)
            throw new ArgumentNullException(nameof(action));

        if (fsm.States.Any(x => x.Name == stateName))
            return;

        try
        {
            FsmState state = new(fsm)
            {
                Name = stateName,
                Actions = new FsmStateAction[]
                {
                    new GenericFsmStateAction() { ToExecute = action }
                }
            };
            fsm.AddState(state, transitionData);
        }
        catch (Exception exception)
        {
            LogHelper.Write<KorzUtils>("Failed to add state " + stateName + " to fsm " + fsm.Name + ". Exception: " + exception.ToString());
        }
    }

    /// <summary>
    /// Tries to add a state to the fsm.
    /// </summary>
    public static void AddState(this Fsm fsm, string stateName, IEnumerable<Action> actions, params FsmTransitionData[] transitionData)
    {
        // Validation
        if (string.IsNullOrEmpty(stateName))
            throw new ArgumentNullException(nameof(stateName));
        if (actions == null)
            throw new ArgumentNullException(nameof(actions));

        if (fsm.States.Any(x => x.Name == stateName))
            return;

        try
        {
            FsmState state = new(fsm)
            {
                Name = stateName,
                Actions = actions.Select(x => new GenericFsmStateAction() { ToExecute = x }).ToArray()
            };
            fsm.AddState(state, transitionData);
        }
        catch (Exception exception)
        {
            LogHelper.Write<KorzUtils>("Failed to add state " + stateName + " to fsm " + fsm.Name + ". Exception: " + exception.ToString());
        }
    }

    /// <summary>
    /// Tries to add a state to the fsm with a set of state actions.
    /// </summary>
    public static void AddState(this Fsm fsm, string stateName, IEnumerable<FsmStateAction> actions, params FsmTransitionData[] transitionData)
    {
        // Validation
        if (string.IsNullOrEmpty(stateName))
            throw new ArgumentNullException(nameof(stateName));
        if (actions == null)
            throw new ArgumentNullException(nameof(actions));
        if (fsm.States.Any(x => x.Name == stateName))
            return;

        try
        {
            FsmState state = new(fsm)
            {
                Name = stateName,
                Actions = actions.ToArray()
            };
            fsm.AddState(state, transitionData);
        }
        catch (Exception exception)
        {
            LogHelper.Write<KorzUtils>("Failed to add state " + stateName + " to fsm " + fsm.Name + ". Exception: " + exception.ToString());
        }
    }

    /// <summary>
    /// Tries to add a state to the fsm.
    /// </summary>
    public static void AddState(this Fsm fsm, FsmState state, params FsmTransitionData[] transitionData)
    {
        // Validation
        if (state == null)
            throw new ArgumentNullException(nameof(state));
        if (fsm.States.Any(x => x.Name == state.Name))
            return;

        transitionData ??= Array.Empty<FsmTransitionData>();
        try
        {
            FsmState[] newStates = new FsmState[fsm.States.Length + 1];
            fsm.States.CopyTo(newStates, 0);
            newStates[fsm.States.Length] = state;
            fsm.States = newStates;

            foreach (FsmTransitionData transition in transitionData)
            {
                // Since this will do nothing, if the event already exist. We can call it safely.
                fsm.AddEvent(transition.EventName);
                state.AddTransition(transition.EventName, transition.TargetState);
            }
        }
        catch (Exception exception)
        {
            LogHelper.Write<KorzUtils>("Failed to add state " + state.Name + " to fsm " + fsm.Name + ". Exception: " + exception.ToString());
        }
    }

    #endregion

    /// <summary>
    /// Adds a new event to the fsm. If the event already exist, this will do nothing.
    /// </summary>
    public static void AddEvent(this Fsm fsm, string eventName)
    {
        if (string.IsNullOrEmpty(eventName))
            throw new ArgumentNullException(nameof(eventName));
        if (eventName == "FINISHED")
            return;
        FsmEvent.GetFsmEvent(eventName);
    }

    #endregion
}