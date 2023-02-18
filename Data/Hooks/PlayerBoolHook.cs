using System;

namespace KorzUtils.Data.Hooks;

internal class PlayerBoolHook : MatchHookData
{
    #region Properties

    public Func<string, bool, bool> Function { get; set; }

    #endregion
}
