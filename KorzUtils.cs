using Modding;

namespace KorzUtils;

public class KorzUtils : Mod
{
    #region Constructors

    public KorzUtils()
    {
        Instance = this;
    }
    
    #endregion

    #region Properies

    public static KorzUtils Instance { get; set; }

    #endregion

    public override string GetVersion()
    {
        return base.GetVersion();
    }
}