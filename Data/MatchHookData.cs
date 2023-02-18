namespace KorzUtils.Data;

/// <summary>
/// Contains data for a hook which executes if the text matches (like in the player data functions or language get)
/// </summary>
public class MatchHookData
{
    #region Properties

    /// <summary>
    /// Gets the name of the hook.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets the priority in which the hook should be executed. If multiple have the same priority, the order of creation determines which moves first.
    /// </summary>
    public int Priority { get; set; }

    /// <summary>
    /// Gets the text that should be checked for 
    /// </summary>
    public string MatchString { get; set; }

    /// <summary>
    /// Gets the second text that should be checked for 
    /// </summary>
    public string SecondMatchString { get; set; }

    /// <summary>
    /// Gets if the <see cref="MatchString"/> should be checked respecting case.
    /// </summary>
    public bool CaseSensitive { get; set; }

    #endregion
}
