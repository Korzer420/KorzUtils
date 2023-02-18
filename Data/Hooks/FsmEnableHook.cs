using System;

namespace KorzUtils.Data.Hooks;

internal class FsmEnableHook : MatchHookData
{
    #region Properties

    /// <summary>
    /// "Function" is a lie here.
    /// </summary>
    public Action<PlayMakerFSM> Function { get; set; }

    #endregion
}
