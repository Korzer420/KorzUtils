using Modding;

namespace KorzUtils;

public class KorzUtils : Mod
{
    #region Constructors

    public KorzUtils() => Instance = this;
    
    #endregion

    #region Properies

    public static KorzUtils Instance { get; set; }

    public override string GetVersion() => "0.4.0.0";

    #endregion
}