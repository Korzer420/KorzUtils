using KorzUtils.Data;
using KorzUtils.Data.Hooks;
using KorzUtils.Enums;
using Modding;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KorzUtils.Helper;

/// <summary>
/// Provides useful functions regarding common modhooks and on hooks.
/// </summary>
public static class HookHelper
{
    #region Members

    private static Dictionary<Hook, List<MatchHookData>> _hooks = new();

    #endregion

    #region Constructors

    static HookHelper()
    {
        ModHooks.GetPlayerBoolHook += ModHooks_GetPlayerBoolHook;
        ModHooks.GetPlayerIntHook += ModHooks_GetPlayerIntHook;
        ModHooks.GetPlayerStringHook += ModHooks_GetPlayerStringHook;
        ModHooks.SetPlayerBoolHook += ModHooks_SetPlayerBoolHook;
        ModHooks.SetPlayerIntHook += ModHooks_SetPlayerIntHook;
        ModHooks.SetPlayerStringHook += ModHooks_SetPlayerStringHook;
        ModHooks.LanguageGetHook += ModHooks_LanguageGetHook;
        On.PlayMakerFSM.OnEnable += PlayMakerFSM_OnEnable;
    }

    #endregion

    #region Event handler

    private static string ModHooks_SetPlayerStringHook(string name, string orig)
    {
        if (_hooks.ContainsKey(Hook.PlayerGetString) && _hooks[Hook.PlayerGetString].Any())
            foreach (PlayerStringHook item in _hooks[Hook.PlayerGetString].Cast<PlayerStringHook>())
                try
                {
                    if (item.MatchString.Match(name, item.CaseSensitive))
                        orig = item.Function.Invoke(name, orig);
                }
                catch (Exception exception)
                {
                    LogHelper.Write<KorzUtils>("An error occured while trying to execute hook " + item.Name + " (SetString hook): " + exception.ToString());
                }
        return orig;
    }

    private static int ModHooks_SetPlayerIntHook(string name, int orig)
    {
        if (_hooks.ContainsKey(Hook.PlayerSetInt) && _hooks[Hook.PlayerSetInt].Any())
            foreach (PlayerIntHook item in _hooks[Hook.PlayerSetInt].Cast<PlayerIntHook>())
                try
                {
                    if (item.MatchString.Match(name, item.CaseSensitive))
                        orig = item.Function.Invoke(name, orig);
                }
                catch (Exception exception)
                {
                    LogHelper.Write<KorzUtils>("An error occured while trying to execute hook " + item.Name + " (SetInt hook): " + exception.ToString());
                }
        return orig;
    }

    private static bool ModHooks_SetPlayerBoolHook(string name, bool orig)
    {
        if (_hooks.ContainsKey(Hook.PlayerGetBool) && _hooks[Hook.PlayerGetBool].Any())
            foreach (PlayerBoolHook item in _hooks[Hook.PlayerGetBool].Cast<PlayerBoolHook>())
                try
                {
                    if (item.MatchString.Match(name, item.CaseSensitive))
                        orig = item.Function.Invoke(name, orig);
                }
                catch (Exception exception)
                {
                    LogHelper.Write<KorzUtils>("An error occured while trying to execute hook " + item.Name + " (SetBool hook): " + exception.ToString());
                }
        return orig;
    }

    private static string ModHooks_GetPlayerStringHook(string name, string orig)
    {
        if (_hooks.ContainsKey(Hook.PlayerGetString) && _hooks[Hook.PlayerGetString].Any())
            foreach (PlayerStringHook item in _hooks[Hook.PlayerGetString].Cast<PlayerStringHook>())
                try
                {
                    if (item.MatchString.Match(name, item.CaseSensitive))
                        orig = item.Function.Invoke(name, orig);
                }
                catch (Exception exception)
                {
                    LogHelper.Write<KorzUtils>("An error occured while trying to execute hook " + item.Name + " (GetString hook): " + exception.ToString());
                }
        return orig;
    }

    private static int ModHooks_GetPlayerIntHook(string name, int orig)
    {
        if (_hooks.ContainsKey(Hook.PlayerGetInt) && _hooks[Hook.PlayerGetInt].Any())
            foreach (PlayerIntHook item in _hooks[Hook.PlayerGetInt].Cast<PlayerIntHook>())
                try
                {
                    if (item.MatchString.Match(name, item.CaseSensitive))
                        orig = item.Function.Invoke(name, orig);
                }
                catch (Exception exception)
                {
                    LogHelper.Write<KorzUtils>("An error occured while trying to execute hook " + item.Name + " (GetInt hook): " + exception.ToString());
                }
        return orig;
    }

    private static bool ModHooks_GetPlayerBoolHook(string name, bool orig)
    {
        if (_hooks.ContainsKey(Hook.PlayerGetBool) && _hooks[Hook.PlayerGetBool].Any())
            foreach (PlayerBoolHook item in _hooks[Hook.PlayerGetBool].Cast<PlayerBoolHook>())
                try
                {
                    if (item.MatchString.Match(name, item.CaseSensitive))
                        orig = item.Function.Invoke(name, orig);
                }
                catch (Exception exception)
                {
                    LogHelper.Write<KorzUtils>("An error occured while trying to execute hook " + item.Name + " (GetBool hook): " + exception.ToString());
                }
        return orig;
    }

    private static string ModHooks_LanguageGetHook(string key, string sheetTitle, string orig)
    {
        if (_hooks.ContainsKey(Hook.LanguageGet) && _hooks[Hook.LanguageGet].Any())
            foreach (LanguageGetHook item in _hooks[Hook.LanguageGet].Cast<LanguageGetHook>())
                try
                {
                    if (item.MatchString.Match(key, item.CaseSensitive) &&
                        string.IsNullOrEmpty(item.SecondMatchString) || item.SecondMatchString.Match(sheetTitle, item.CaseSensitive))
                        orig = item.Function.Invoke(key, sheetTitle, orig);
                }
                catch (Exception exception)
                {
                    LogHelper.Write<KorzUtils>("An error occured while trying to execute hook " + item.Name + " (language get hook): " + exception.ToString());
                }
        return orig;
    }

    private static void PlayMakerFSM_OnEnable(On.PlayMakerFSM.orig_OnEnable orig, PlayMakerFSM self)
    {
        if (_hooks.ContainsKey(Hook.BeforeEnableFsm) && _hooks[Hook.BeforeEnableFsm].Any())
            foreach (FsmEnableHook item in _hooks[Hook.BeforeEnableFsm].Cast<FsmEnableHook>())
                try
                {
                    if (item.MatchString.Match(self.FsmName, item.CaseSensitive) &&
                        string.IsNullOrEmpty(item.SecondMatchString) || item.SecondMatchString.Match(self.gameObject.name, item.CaseSensitive))
                        item.Function.Invoke(self);
                }
                catch (Exception exception)
                {
                    LogHelper.Write<KorzUtils>("An error occured while trying to execute hook " + item.Name + " (Fsm before enable hook): " + exception.ToString());
                }
        orig(self);
        if (_hooks.ContainsKey(Hook.AfterEnableFsm) && _hooks[Hook.AfterEnableFsm].Any())
            foreach (FsmEnableHook item in _hooks[Hook.AfterEnableFsm].Cast<FsmEnableHook>())
                try
                {
                    if (item.MatchString.Match(self.FsmName, item.CaseSensitive) &&
                        string.IsNullOrEmpty(item.SecondMatchString) || item.SecondMatchString.Match(self.gameObject.name, item.CaseSensitive))
                        item.Function.Invoke(self);
                }
                catch (Exception exception)
                {
                    LogHelper.Write<KorzUtils>("An error occured while trying to execute hook " + item.Name + " (Fsm after enable hook): "+exception.ToString());
                }
    }

    #endregion

    #region Add Methods

    private static T AddHook<T>(string name, bool caseSensitive, string searchTerm, string searchTerm2, Hook type, int priority = 0) where T : MatchHookData, new()
    {
        if (!_hooks.ContainsKey(type))
            _hooks.Add(type, new());
        MatchHookData matchHookData = new T()
        {
            MatchString = searchTerm,
            Priority = priority,
            CaseSensitive = caseSensitive,
            Name = name,
            SecondMatchString = searchTerm2
        };
        _hooks[type].Add(matchHookData);
        _hooks[type].SortByPriority();
        return (T)matchHookData;
    }

    /// <summary>
    /// Adds a hook that listens for "PlayerData.instance.GetBool()"
    /// </summary>
    /// <param name="name">The name of the hook (it is recommended that this should be unique)</param>
    /// <param name="function">The function that should be executed when a match appears</param>
    /// <param name="boolName">The bool which should be looked for (You can use "*" at the start and the end to allow more names).</param>
    /// <param name="priority">Determines the order in which the hook should be executed (only affects hooks added to this).</param>
    /// <param name="caseSensitive">If true, the <paramref name="boolName"/> should be evaluated respecting case.</param>
    public static void AddPlayerGetBoolHook(string name, Func<string, bool, bool> function, string boolName, int priority = 0, bool caseSensitive = false)
        => AddHook<PlayerBoolHook>(name, caseSensitive, boolName, null, Hook.PlayerGetBool, priority).Function = function;

    /// <summary>
    /// Adds a hook that listens for "PlayerData.instance.SetBool()"
    /// </summary>
    /// <param name="name">The name of the hook (it is recommended that this should be unique)</param>
    /// <param name="function">The function that should be executed when a match appears</param>
    /// <param name="boolName">The bool which should be looked for (You can use "*" at the start and the end to allow more names).</param>
    /// <param name="priority">Determines the order in which the hook should be executed (only affects hooks added to this).</param>
    /// <param name="caseSensitive">If true, the <paramref name="boolName"/> should be evaluated respecting case.</param>
    public static void AddPlayerSetBoolHook(string name, Func<string, bool, bool> function, string boolName, int priority = 0, bool caseSensitive = false)
        => AddHook<PlayerBoolHook>(name, caseSensitive, boolName, null, Hook.PlayerSetBool, priority).Function = function;

    /// <summary>
    /// Adds a hook that listens for "PlayerData.instance.GetInt()"
    /// </summary>
    /// <param name="name">The name of the hook (it is recommended that this should be unique)</param>
    /// <param name="function">The function that should be executed when a match appears</param>
    /// <param name="intName">The int which should be looked for (You can use "*" at the start and the end to allow more names).</param>
    /// <param name="priority">Determines the order in which the hook should be executed (only affects hooks added to this).</param>
    /// <param name="caseSensitive">If true, the <paramref name="intName"/> should be evaluated respecting case.</param>
    public static void AddPlayerGetIntHook(string name, Func<string, int, int> function, string intName, int priority = 0, bool caseSensitive = false)
        => AddHook<PlayerIntHook>(name, caseSensitive, intName, null, Hook.PlayerGetInt, priority).Function = function;

    /// <summary>
    /// Adds a hook that listens for "PlayerData.instance.SetInt()"
    /// </summary>
    /// <param name="name">The name of the hook (it is recommended that this should be unique)</param>
    /// <param name="function">The function that should be executed when a match appears</param>
    /// <param name="intName">The int which should be looked for (You can use "*" at the start and the end to allow more names).</param>
    /// <param name="priority">Determines the order in which the hook should be executed (only affects hooks added to this).</param>
    /// <param name="caseSensitive">If true, the <paramref name="intName"/> should be evaluated respecting case.</param>
    public static void AddPlayerSetIntHook(string name, Func<string, int, int> function, string intName, int priority = 0, bool caseSensitive = false)
        => AddHook<PlayerIntHook>(name, caseSensitive, intName, null, Hook.PlayerSetInt, priority).Function = function;

    /// <summary>
    /// Adds a hook that listens for "PlayerData.instance.GetString()"
    /// </summary>
    /// <param name="name">The name of the hook (it is recommended that this should be unique)</param>
    /// <param name="function">The function that should be executed when a match appears</param>
    /// <param name="stringName">The string which should be looked for (You can use "*" at the start and the end to allow more names).</param>
    /// <param name="priority">Determines the order in which the hook should be executed (only affects hooks added to this).</param>
    /// <param name="caseSensitive">If true, the <paramref name="stringName"/> should be evaluated respecting case.</param>
    public static void AddPlayerGetStringHook(string name, Func<string, string, string> function, string stringName, int priority = 0, bool caseSensitive = false)
        => AddHook<PlayerStringHook>(name, caseSensitive, stringName, null, Hook.PlayerGetString, priority).Function = function;

    /// <summary>
    /// Adds a hook that listens for "PlayerData.instance.SetString()"
    /// </summary>
    /// <param name="name">The name of the hook (it is recommended that this should be unique)</param>
    /// <param name="function">The function that should be executed when a match appears</param>
    /// <param name="stringName">The string which should be looked for (You can use "*" at the start and the end to allow more names).</param>
    /// <param name="priority">Determines the order in which the hook should be executed (only affects hooks added to this).</param>
    /// <param name="caseSensitive">If true, the <paramref name="stringName"/> should be evaluated respecting case.</param>
    public static void AddPlayerSetStringHook(string name, Func<string, string, string> function, string stringName, int priority = 0, bool caseSensitive = false)
        => AddHook<PlayerStringHook>(name, caseSensitive, stringName, null, Hook.PlayerSetString, priority).Function = function;

    /// <summary>
    /// Adds a hook that listens when the game requests a text.
    /// </summary>
    /// <param name="name">The name of the hook (it is recommended that this should be unique)</param>
    /// <param name="function">The function that should be executed when a match appears</param>
    /// <param name="key">The key which should be looked for (You can use "*" at the start and the end to allow more names).</param>
    /// <param name="sheet">The sheet which should be looked for (You can use "*" at the start and the end to allow more names).</param>
    /// <param name="priority">Determines the order in which the hook should be executed (only affects hooks added to this).</param>
    /// <param name="caseSensitive">If true, the <paramref name="key"/> and <paramref name="sheet"/> should be evaluated respecting case.</param>
    public static void AddLanguageGetHook(string name, Func<string, string, string, string> function, string key, string sheet = null, int priority = 0, bool caseSensitive = false)
        => AddHook<LanguageGetHook>(name, caseSensitive, key, sheet, Hook.LanguageGet, priority).Function = function;

    /// <summary>
    /// Adds a hook that listens when a fsm gets enabled.
    /// </summary>
    /// <param name="name">The name of the hook (it is recommended that this should be unique)</param>
    /// <param name="action">The action that should be executed when a match appears</param>
    /// <param name="fsmName">The fsm name which should be looked for (You can use "*" at the start and the end to allow more names).</param>
    /// <param name="gameObjectName">The game object name which should be looked for (You can use "*" at the start and the end to allow more names).</param>
    /// <param name="beforeOrig">If true, the <paramref name="action"/> is executed before orig(self).</param>
    /// <param name="priority">Determines the order in which the hook should be executed (only affects hooks added to this).</param>
    /// <param name="caseSensitive">If true, the <paramref name="fsmName"/> and <paramref name="gameObjectName"/> should be evaluated respecting case.</param>
    public static void AddFsmEnableHook(string name, Action<PlayMakerFSM> action, string fsmName, string gameObjectName = null, bool beforeOrig = true, int priority = 0, bool caseSensitive = false)
        => AddHook<FsmEnableHook>(name, caseSensitive, fsmName, gameObjectName, beforeOrig ? Hook.BeforeEnableFsm : Hook.AfterEnableFsm, priority).Function = action;

    #endregion

    #region Remove

    /// <summary>
    /// Removes ALL hooks that have the passed name.
    /// </summary>
    /// <param name="name">The name which should be looked for.</param>
    public static void RemoveHook(string name)
    {
        foreach (Hook hook in _hooks.Keys)
            _hooks[hook].RemoveAll(x => string.Equals(x.Name, name, StringComparison.CurrentCultureIgnoreCase));
    }

    #endregion
}