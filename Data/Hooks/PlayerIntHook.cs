using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorzUtils.Data.Hooks;

internal class PlayerIntHook : MatchHookData
{
    #region Properties

    public Func<string,int,int> Function { get; set; }

    #endregion
}
