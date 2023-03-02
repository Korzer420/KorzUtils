using HutongGames.PlayMaker;
using Modding;
using Modding.Delegates;

namespace KorzUtils.Helper;

/// <summary>
/// Provides functions for some more generic ingame behaviour
/// </summary>
public static class GameHelper
{
    #region Methods

    /// <summary>
    /// Displays a message in the dream nail dialogue box used for enemy hits.
    /// </summary>
    /// <param name="message"></param>
    public static void DisplayMessage(string message)
    {
        PlayMakerFSM playMakerFSM = PlayMakerFSM.FindFsmOnGameObject(FsmVariables.GlobalVariables.GetFsmGameObject("Enemy Dream Msg").Value, "Display");
        playMakerFSM.FsmVariables.GetFsmInt("Convo Amount").Value = 1;
        playMakerFSM.FsmVariables.GetFsmString("Convo Title").Value = "Korz_Util";

        LanguageGetProxy languageGetProxy = null;
        languageGetProxy = new((x, y, z) =>
        {
            if (x == "Korz_Util_1")
            {
                ModHooks.LanguageGetHook -= languageGetProxy;
                return message;
            }
            return z;
        });

        ModHooks.LanguageGetHook += languageGetProxy;
        playMakerFSM.SendEvent("DISPLAY ENEMY DREAM");
    }

    #endregion
}
