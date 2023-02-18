using System;

namespace KorzUtils.Data.Hooks;

internal class LanguageGetHook : MatchHookData
{
    #region Properties

    public Func<string,string,string,string> Function { get; set; }

    #endregion
}
