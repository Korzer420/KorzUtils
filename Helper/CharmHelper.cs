using KorzUtils.Enums;
using KorzUtils.Helper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BomberKnight.Helper;

/// <summary>
/// Offers various functions regarding charms.
/// </summary>
public static class CharmHelper
{
    #region Members

    private static Dictionary<string, int> _customCharmList = new();

    #endregion

    #region Custom Charm Control

    /// <summary>
    /// Adds a custom charm to the internal charm list so the charm helper can process it.
    /// </summary>
    /// <param name="charmName"></param>
    /// <param name="id"></param>
    /// <param name="overwrite">If <see langword="true"/> the id will be overwritten if the charm name already exists.</param>
    public static void AddCustomCharm(string charmName, int id, bool overwrite = true)
    {
        if (!_customCharmList.ContainsKey(charmName))
            _customCharmList.Add(charmName, id);
        else if (overwrite)
            _customCharmList[charmName] = id;
    }

    /// <summary>
    /// Adds a custom charm to the internal charm list so the charm helper can process it.
    /// </summary>
    /// <param name="charmName">The name of the custom charm to remove.</param>
    public static void RemoveCustomCharm(string charmName)
    {
        if (_customCharmList.ContainsKey(charmName))
            _customCharmList.Remove(charmName);
    }

    /// <summary>
    /// Gets the name of a custom charm from an id.
    /// </summary>
    /// <param name="id">The id of the charm which should be searched for</param>
    /// <returns></returns>
    public static string GetCustomCharmName(int id) => _customCharmList.Keys.FirstOrDefault(x => _customCharmList[x] == id);

    /// <summary>
    /// Gets the id of a custom charm name.
    /// </summary>
    /// <param name="charmName">The name of the charm which should be searched for.</param>
    public static int GetCustomCharmId(string charmName)
    {
        if (_customCharmList.ContainsKey(charmName))
            return _customCharmList.FirstOrDefault(x => x.Key == charmName).Value;
        return -1;
    }

    #endregion

    #region Checking

    /// <summary>
    /// Checks if the player has acquired the charm.
    /// </summary>
    /// <param name="charm">The charm which should be checked.</param>
    /// <param name="forceLevel">If <see langword="true"/> multiple stage charms (like Grimmchild) are only considered if the player has the exact level. Otherwise higher stages are also return true.
    /// <para>Only works on vanilla charms</para></param>
    /// <returns></returns>
    public static bool HasCharm(CharmRef charm, bool forceLevel = false)
    => charm switch
    {
        CharmRef.FragileHeart when forceLevel => PlayerData.instance.GetBool($"gotCharm_{(int)charm}")
                            && !PlayerData.instance.GetBool(nameof(PlayerData.instance.fragileHealth_unbreakable)),
        CharmRef.FragileGreed when forceLevel => PlayerData.instance.GetBool($"gotCharm_{(int)charm}")
                            && !PlayerData.instance.GetBool(nameof(PlayerData.instance.fragileGreed_unbreakable)),
        CharmRef.FragileStrength when forceLevel => PlayerData.instance.GetBool($"gotCharm_{(int)charm}")
                            && !PlayerData.instance.GetBool(nameof(PlayerData.instance.fragileStrength_unbreakable)),
        CharmRef.Kingssoul when forceLevel => PlayerData.instance.GetBool($"gotCharm_{(int)charm}")
                            && !PlayerData.instance.GetBool(nameof(PlayerData.instance.gotShadeCharm)),
        CharmRef.Grimmchild1 when forceLevel => PlayerData.instance.GetBool($"gotCharm_{(int)charm}")
                            && PlayerData.instance.GetInt(nameof(PlayerData.instance.grimmChildLevel)) == 1,
        CharmRef.VoidHeart => PlayerData.instance.GetBool("gotCharm_36")
                            && PlayerData.instance.GetBool(nameof(PlayerData.instance.gotShadeCharm)),
        CharmRef.UnbreakableHeart => PlayerData.instance.GetBool("gotCharm_23")
                            && PlayerData.instance.GetBool(nameof(PlayerData.instance.fragileHealth_unbreakable)),
        CharmRef.UnbreakableGreed => PlayerData.instance.GetBool("gotCharm_24")
                            && PlayerData.instance.GetBool(nameof(PlayerData.instance.fragileGreed_unbreakable)),
        CharmRef.UnbreakableStrength => PlayerData.instance.GetBool("gotCharm_25")
                            && PlayerData.instance.GetBool(nameof(PlayerData.instance.fragileStrength_unbreakable)),
        CharmRef.Grimmchild2 => PlayerData.instance.GetBool("gotCharm_40")
                            && ((PlayerData.instance.GetInt(nameof(PlayerData.instance.grimmChildLevel)) == 2 && forceLevel)
                            || PlayerData.instance.GetInt(nameof(PlayerData.instance.grimmChildLevel)) >= 2 && !forceLevel),
        CharmRef.Grimmchild3 => PlayerData.instance.GetBool("gotCharm_40")
                            && ((PlayerData.instance.GetInt(nameof(PlayerData.instance.grimmChildLevel)) == 3 && forceLevel)
                            || PlayerData.instance.GetInt(nameof(PlayerData.instance.grimmChildLevel)) >= 3 && !forceLevel),
        CharmRef.Grimmchild4 => PlayerData.instance.GetBool("gotCharm_40")
                            && PlayerData.instance.GetInt(nameof(PlayerData.instance.grimmChildLevel)) == 4,
        CharmRef.CarefreeMelody => PlayerData.instance.GetBool("gotCharm_40")
                            && PlayerData.instance.GetInt(nameof(PlayerData.instance.grimmChildLevel)) == 5,
        _ => PlayerData.instance.GetBool($"gotCharm_{(int)charm}"),
    };

    /// <summary>
    /// Checks if the player has acquired the charm.
    /// </summary>
    /// <param name="charmName">The name of the charm which should be checked.</param>
    /// <param name="forceLevel">If <see langword="true"/> multiple stage charms (like Grimmchild) are only considered if the player has the exact level. Otherwise higher stages are also return true.
    /// <para>Only works on vanilla charms</para></param>
    public static bool HasCharm(string charmName, bool forceLevel = false)
    {
        if (!Enum.TryParse(charmName, out CharmRef result))
            return _customCharmList.ContainsKey(charmName) && PlayerData.instance.GetBool("gotCharm_" + _customCharmList[charmName]);
        return HasCharm(result, forceLevel);
    }

    /// <summary>
    /// Checks if the player has equipped the charm.
    /// </summary>
    /// <param name="charm">The charm which should be checked.</param>
    /// <param name="forceLevel">If <see langword="true"/> multiple stage charms (like Grimmchild) are only considered if the player has the exact level. Otherwise higher stages are also return true.
    /// <para>Only works on vanilla charms</para></param>
    public static bool EquippedCharm(CharmRef charm, bool forceLevel = false)
    {
        if (!HasCharm(charm, forceLevel))
            return false;
        charm = Normalize(charm);
        return PlayerData.instance.GetBool($"equippedCharm_{(int)charm}");
    }

    /// <summary>
    /// Checks if the player has equipped the charm.
    /// </summary>
    /// <param name="charmName">The name of the charm which should be checked.</param>
    /// <param name="forceLevel">If <see langword="true"/> multiple stage charms (like Grimmchild) are only considered if the player has the exact level. Otherwise higher stages are also return true.
    /// <para>Only works on vanilla charms</para></param>
    public static bool EquippedCharm(string charmName, bool forceLevel = false)
    {
        if (!Enum.TryParse(charmName, out CharmRef charm))
            return _customCharmList.ContainsKey(charmName) && PlayerData.instance.GetBool("equippedCharm_" + _customCharmList[charmName]);
        return EquippedCharm(charm, forceLevel);
    } 

    #endregion

    #region Equipping

    /// <summary>
    /// Equips the given charm and forces a charm update. (May not update the UI if overcharmed in the process)
    /// </summary>
    /// <param name="charm">The charm to equip.</param>
    /// <param name="toggle">If the charm is already equipped, setting this to true will unequip the charm instead.</param>
    public static void EquipCharm(CharmRef charm, bool toggle = false)
    {
        charm = Normalize(charm);

        if (!HasCharm(charm, false))
            return;
        if (EquippedCharm(charm, false))
        {
            if (!toggle)
                return;
            PlayerData.instance.GetVariable<List<int>>(nameof(PlayerData.instance.equippedCharms)).Remove((int)charm);
            PlayerData.instance.SetBool($"equippedCharm_{(int)charm}", false);
        }
        else
        {
            PlayerData.instance.GetVariable<List<int>>(nameof(PlayerData.instance.equippedCharms)).Add((int)charm);
            PlayerData.instance.SetBool($"equippedCharm_{(int)charm}", true);
        }

        HeroController.instance.CharmUpdate();
    }

    /// <summary>
    /// Equips the given charm and forces a charm update. (May not update the UI if overcharmed in the process)
    /// </summary>
    /// <param name="charmName">The name of the charm to equip.</param>
    /// <param name="toggle">If the charm is already equipped, setting this to true will unequip the charm instead.</param>
    public static void EquipCharm(string charmName, bool toggle = false)
    {
        if (!Enum.TryParse(charmName, out CharmRef charm))
        {
            if (!_customCharmList.ContainsKey(charmName))
                LogHelper.Write("Tried equipping unknown charm " + charmName, LogType.Error);
            else
            {
                if (PlayerData.instance.GetBool($"equippedCharm_{_customCharmList[charmName]}"))
                {
                    if (!toggle)
                        return;
                    PlayerData.instance.GetVariable<List<int>>(nameof(PlayerData.instance.equippedCharms)).Remove(_customCharmList[charmName]);
                    PlayerData.instance.SetBool($"equippedCharm_{_customCharmList[charmName]}", false);
                }
                else
                {
                    PlayerData.instance.GetVariable<List<int>>(nameof(PlayerData.instance.equippedCharms)).Add(_customCharmList[charmName]);
                    PlayerData.instance.SetBool($"equippedCharm_{_customCharmList[charmName]}", true);
                }
                HeroController.instance.CharmUpdate();
            }
        }
        else
            EquipCharm(charm, toggle);
    }

    /// <summary>
    /// Unequips the given charm and forces a charm update. (May not update the UI if overcharmed in the process)
    /// </summary>
    /// <param name="charm">The charm to unequip.</param>
    /// <param name="toggle">If the charm is not equipped already, setting this to true will equip the charm instead.</param>
    public static void UnequipCharm(CharmRef charm, bool toggle = false)
    {
        if (!HasCharm(charm, false))
            return;
        if (!EquippedCharm(charm, false) && !toggle)
            return;
        EquipCharm(charm, true);
    }

    /// <summary>
    /// Unequips the given charm and forces a charm update. (May not update the UI if overcharmed in the process)
    /// </summary>
    /// <param name="charmName">The name of the charm to unequip.</param>
    /// <param name="toggle">If the charm is not equipped already, setting this to true will equip the charm instead.</param>
    public static void UnequipCharm(string charmName, bool toggle = false)
    {
        if (!Enum.TryParse(charmName, out CharmRef charm))
        {
            if (!_customCharmList.ContainsKey(charmName))
                LogHelper.Write("Tried unequipping unknown charm " + charmName, LogType.Error);
            else
            {
                if (!PlayerData.instance.GetBool($"equippedCharm_{_customCharmList[charmName]}") && !toggle)
                    return;
                EquipCharm(charmName, true);
            }
        }
        else
            UnequipCharm(charm, toggle);
    }

    #endregion

    #region Cost

    /// <summary>
    /// Gets the current notch cost of a charm.
    /// </summary>
    /// <param name="charm">The charm which costs should be fetched.</param>
    public static int GetCharmCost(CharmRef charm) => PlayerData.instance.GetInt($"charmCost_{(int)Normalize(charm)}");

    /// <summary>
    /// Gets the current notch cost of a charm.
    /// </summary>
    /// <param name="charmName">The name of the charm which costs should be fetched.</param>
    public static int GetCharmCost(string charmName)
    {
        if (Enum.TryParse(charmName, out CharmRef charm))
            return GetCharmCost(charm);
        else if (_customCharmList.ContainsKey(charmName))
            return PlayerData.instance.GetInt($"charmCost_{_customCharmList[charmName]}");
        else
        {
            LogHelper.Write("Tried fetching the cost of unknown charm: " + charmName, LogType.Error);
            return -1;
        }    
    }

    /// <summary>
    /// Sets the cost of a charm and forces a charm updated. (May not update the overcharm UI)
    /// </summary>
    /// <param name="charm">The charm which cost should be set.</param>
    /// <param name="cost">The cost the charm should have.</param>
    public static void SetCharmCost(CharmRef charm, int cost) 
    { 
        PlayerData.instance.SetInt($"charmCost_{(int)Normalize(charm)}", cost);
        HeroController.instance.CharmUpdate();
    }

    /// <summary>
    /// Sets the cost of a charm and forces a charm updated. (May not update the overcharm UI)
    /// </summary>
    /// <param name="charmName">The name of the charm which cost should be set.</param>
    /// <param name="cost">The cost the charm should have.</param>
    public static void SetCharmCost(string charmName, int cost)
    {
        if (Enum.TryParse(charmName, out CharmRef charm))
            SetCharmCost(charm, cost);
        else if (_customCharmList.ContainsKey(charmName))
        {
            PlayerData.instance.SetInt($"charmCost_{_customCharmList[charmName]}", cost);
            HeroController.instance.CharmUpdate();
        }
        else
            LogHelper.Write("Tried setting the cost of unknown charm: " + charmName, LogType.Error);
    }

    #endregion

    #region Private Methods

    /// <summary>
    /// Normalizes a charm with stages to it's default level.
    /// </summary>
    /// <param name="charm"></param>
    /// <returns></returns>
    private static CharmRef Normalize(CharmRef charm) => charm switch
    {
        CharmRef.VoidHeart => CharmRef.Kingssoul,
        CharmRef.UnbreakableHeart => CharmRef.FragileHeart,
        CharmRef.UnbreakableGreed => CharmRef.FragileGreed,
        CharmRef.UnbreakableStrength => CharmRef.FragileStrength,
        CharmRef.Grimmchild2 or CharmRef.Grimmchild3 
        or CharmRef.Grimmchild4 or CharmRef.CarefreeMelody => CharmRef.Grimmchild1,
        _ => charm

    };

    #endregion
}
