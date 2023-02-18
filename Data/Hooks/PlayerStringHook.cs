using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorzUtils.Data.Hooks;

internal class PlayerStringHook : MatchHookData
{
    #region Properties

    public Func<string, string, string> Function { get; set; }

    #endregion
}
