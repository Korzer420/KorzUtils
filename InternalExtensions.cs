using KorzUtils.Data;
using System.Collections.Generic;
using System.Linq;

namespace KorzUtils;

internal static class InternalExtensions
{
    internal static void SortByPriority(this List<MatchHookData> list) => list = list.OrderBy(x => x.Priority).ToList();

    internal static bool Match(this string callValue, string comparision, bool caseSensitive = false)
    {
        if (!caseSensitive)
        {
            callValue = callValue.ToUpper();
            comparision = comparision.ToUpper();
        }

        if (comparision == "*" || comparision == "**")
            return true;
        else if (comparision.StartsWith("*") && comparision.EndsWith("*"))
            return callValue.Contains(comparision.Substring(1, comparision.Length - 2));
        else if (comparision.StartsWith("*"))
            return callValue.EndsWith(comparision.Substring(1));
        else if (comparision.EndsWith("*"))
            return callValue.StartsWith(comparision.Substring(0, comparision.Length - 1));
        else
            return string.Equals(callValue, comparision);
    }
}
