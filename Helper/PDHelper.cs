using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorzUtils.Helper;

/// <summary>
/// Provides easier access to player data fields while giving other mods still opportunities to modify the result.
/// </summary>
public static class PDHelper
{
    #region Properties

    public static string Version
    {
        get => PlayerData.instance?.GetString(nameof(PlayerData.version));
        set => PlayerData.instance?.SetString(nameof(PlayerData.version), value);
    }

    public static bool AwardAllAchievements
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.awardAllAchievements)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.awardAllAchievements), value);
    }

    public static int ProfileID
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.profileID)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.profileID), value);
    }

    public static float PlayTime
    {
        get => PlayerData.instance?.GetFloat(nameof(PlayerData.playTime)) ?? -1;
        set => PlayerData.instance?.SetFloat(nameof(PlayerData.playTime), value);
    }

    public static float CompletionPercent
    {
        get => PlayerData.instance?.GetFloat(nameof(PlayerData.completionPercent)) ?? -1;
        set => PlayerData.instance?.SetFloat(nameof(PlayerData.completionPercent), value);
    }

    public static bool OpeningCreditsPlayed
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.openingCreditsPlayed)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.openingCreditsPlayed), value);
    }

    public static int PermadeathMode
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.permadeathMode)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.permadeathMode), value);
    }

    public static int Health
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.health)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.health), value);
    }

    public static int MaxHealth
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.maxHealth)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.maxHealth), value);
    }

    public static int MaxHealthBase
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.maxHealthBase)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.maxHealthBase), value);
    }

    public static int HealthBlue
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.healthBlue)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.healthBlue), value);
    }

    public static int JoniHealthBlue
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.joniHealthBlue)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.joniHealthBlue), value);
    }

    public static bool DamagedBlue
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.damagedBlue)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.damagedBlue), value);
    }

    public static int HeartPieces
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.heartPieces)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.heartPieces), value);
    }

    public static bool HeartPieceCollected
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.heartPieceCollected)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.heartPieceCollected), value);
    }

    public static int MaxHealthCap
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.maxHealthCap)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.maxHealthCap), value);
    }

    public static bool HeartPieceMax
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.heartPieceMax)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.heartPieceMax), value);
    }

    public static int PrevHealth
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.prevHealth)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.prevHealth), value);
    }

    public static int BlockerHits
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.blockerHits)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.blockerHits), value);
    }

    public static bool FirstGeo
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.firstGeo)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.firstGeo), value);
    }

    public static int Geo
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.geo)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.geo), value);
    }

    public static int MaxMP
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.maxMP)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.maxMP), value);
    }

    public static int MPCharge
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.MPCharge)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.MPCharge), value);
    }

    public static int MPReserve
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.MPReserve)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.MPReserve), value);
    }

    public static int MPReserveMax
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.MPReserveMax)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.MPReserveMax), value);
    }

    public static bool SoulLimited
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.soulLimited)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.soulLimited), value);
    }

    public static int VesselFragments
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.vesselFragments)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.vesselFragments), value);
    }

    public static bool VesselFragmentCollected
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.vesselFragmentCollected)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.vesselFragmentCollected), value);
    }

    public static int MPReserveCap
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.MPReserveCap)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.MPReserveCap), value);
    }

    public static bool VesselFragmentMax
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.vesselFragmentMax)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.vesselFragmentMax), value);
    }

    public static int FocusMP_amount
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.focusMP_amount)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.focusMP_amount), value);
    }

    public static bool AtBench
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.atBench)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.atBench), value);
    }

    public static string RespawnScene
    {
        get => PlayerData.instance?.GetString(nameof(PlayerData.respawnScene));
        set => PlayerData.instance?.SetString(nameof(PlayerData.respawnScene), value);
    }

    public static string RespawnMarkerName
    {
        get => PlayerData.instance?.GetString(nameof(PlayerData.respawnMarkerName));
        set => PlayerData.instance?.SetString(nameof(PlayerData.respawnMarkerName), value);
    }

    public static int RespawnType
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.respawnType)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.respawnType), value);
    }

    public static bool RespawnFacingRight
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.respawnFacingRight)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.respawnFacingRight), value);
    }

    public static bool HazardRespawnFacingRight
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hazardRespawnFacingRight)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hazardRespawnFacingRight), value);
    }

    public static string ShadeScene
    {
        get => PlayerData.instance?.GetString(nameof(PlayerData.shadeScene));
        set => PlayerData.instance?.SetString(nameof(PlayerData.shadeScene), value);
    }

    public static string ShadeMapZone
    {
        get => PlayerData.instance?.GetString(nameof(PlayerData.shadeMapZone));
        set => PlayerData.instance?.SetString(nameof(PlayerData.shadeMapZone), value);
    }

    public static float ShadePositionX
    {
        get => PlayerData.instance?.GetFloat(nameof(PlayerData.shadePositionX)) ?? -1;
        set => PlayerData.instance?.SetFloat(nameof(PlayerData.shadePositionX), value);
    }

    public static float ShadePositionY
    {
        get => PlayerData.instance?.GetFloat(nameof(PlayerData.shadePositionY)) ?? -1;
        set => PlayerData.instance?.SetFloat(nameof(PlayerData.shadePositionY), value);
    }

    public static int ShadeHealth
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.shadeHealth)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.shadeHealth), value);
    }

    public static int ShadeMP
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.shadeMP)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.shadeMP), value);
    }

    public static int ShadeFireballLevel
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.shadeFireballLevel)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.shadeFireballLevel), value);
    }

    public static int ShadeQuakeLevel
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.shadeQuakeLevel)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.shadeQuakeLevel), value);
    }

    public static int ShadeScreamLevel
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.shadeScreamLevel)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.shadeScreamLevel), value);
    }

    public static int ShadeSpecialType
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.shadeSpecialType)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.shadeSpecialType), value);
    }

    public static int GeoPool
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.geoPool)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.geoPool), value);
    }

    public static int NailDamage
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.nailDamage)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.nailDamage), value);
    }

    public static int NailRange
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.nailRange)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.nailRange), value);
    }

    public static int BeamDamage
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.beamDamage)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.beamDamage), value);
    }

    public static bool CanDash
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.canDash)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.canDash), value);
    }

    public static bool CanBackDash
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.canBackDash)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.canBackDash), value);
    }

    public static bool CanWallJump
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.canWallJump)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.canWallJump), value);
    }

    public static bool CanSuperDash
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.canSuperDash)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.canSuperDash), value);
    }

    public static bool CanShadowDash
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.canShadowDash)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.canShadowDash), value);
    }

    public static bool HasSpell
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasSpell)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasSpell), value);
    }

    public static int FireballLevel
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.fireballLevel)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.fireballLevel), value);
    }

    public static int QuakeLevel
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.quakeLevel)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.quakeLevel), value);
    }

    public static int ScreamLevel
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.screamLevel)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.screamLevel), value);
    }

    public static bool HasNailArt
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasNailArt)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasNailArt), value);
    }

    public static bool HasCyclone
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasCyclone)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasCyclone), value);
    }

    public static bool HasDashSlash
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasDashSlash)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasDashSlash), value);
    }

    public static bool HasUpwardSlash
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasUpwardSlash)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasUpwardSlash), value);
    }

    public static bool HasAllNailArts
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasAllNailArts)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasAllNailArts), value);
    }

    public static bool HasDreamNail
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasDreamNail)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasDreamNail), value);
    }

    public static bool HasDreamGate
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasDreamGate)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasDreamGate), value);
    }

    public static bool DreamNailUpgraded
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.dreamNailUpgraded)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.dreamNailUpgraded), value);
    }

    public static int DreamOrbs
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.dreamOrbs)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.dreamOrbs), value);
    }

    public static int DreamOrbsSpent
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.dreamOrbsSpent)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.dreamOrbsSpent), value);
    }

    public static string DreamGateScene
    {
        get => PlayerData.instance?.GetString(nameof(PlayerData.dreamGateScene));
        set => PlayerData.instance?.SetString(nameof(PlayerData.dreamGateScene), value);
    }

    public static float DreamGateX
    {
        get => PlayerData.instance?.GetFloat(nameof(PlayerData.dreamGateX)) ?? -1;
        set => PlayerData.instance?.SetFloat(nameof(PlayerData.dreamGateX), value);
    }

    public static float DreamGateY
    {
        get => PlayerData.instance?.GetFloat(nameof(PlayerData.dreamGateY)) ?? -1;
        set => PlayerData.instance?.SetFloat(nameof(PlayerData.dreamGateY), value);
    }

    public static bool HasDash
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasDash)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasDash), value);
    }

    public static bool HasWalljump
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasWalljump)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasWalljump), value);
    }

    public static bool HasSuperDash
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasSuperDash)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasSuperDash), value);
    }

    public static bool HasShadowDash
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasShadowDash)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasShadowDash), value);
    }

    public static bool HasAcidArmour
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasAcidArmour)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasAcidArmour), value);
    }

    public static bool HasDoubleJump
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasDoubleJump)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasDoubleJump), value);
    }

    public static bool HasLantern
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasLantern)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasLantern), value);
    }

    public static bool HasTramPass
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasTramPass)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasTramPass), value);
    }

    public static bool HasQuill
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasQuill)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasQuill), value);
    }

    public static bool HasCityKey
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasCityKey)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasCityKey), value);
    }

    public static bool HasSlykey
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasSlykey)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasSlykey), value);
    }

    public static bool GaveSlykey
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gaveSlykey)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gaveSlykey), value);
    }

    public static bool HasWhiteKey
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasWhiteKey)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasWhiteKey), value);
    }

    public static bool UsedWhiteKey
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.usedWhiteKey)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.usedWhiteKey), value);
    }

    public static bool HasMenderKey
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasMenderKey)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasMenderKey), value);
    }

    public static bool HasWaterwaysKey
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasWaterwaysKey)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasWaterwaysKey), value);
    }

    public static bool HasSpaKey
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasSpaKey)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasSpaKey), value);
    }

    public static bool HasLoveKey
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasLoveKey)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasLoveKey), value);
    }

    public static bool HasKingsBrand
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasKingsBrand)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasKingsBrand), value);
    }

    public static bool HasXunFlower
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasXunFlower)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasXunFlower), value);
    }

    public static int GhostCoins
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.ghostCoins)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.ghostCoins), value);
    }

    public static int Ore
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.ore)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.ore), value);
    }

    public static bool FoundGhostCoin
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.foundGhostCoin)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.foundGhostCoin), value);
    }

    public static int Trinket1
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.trinket1)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.trinket1), value);
    }

    public static bool FoundTrinket1
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.foundTrinket1)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.foundTrinket1), value);
    }

    public static int Trinket2
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.trinket2)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.trinket2), value);
    }

    public static bool FoundTrinket2
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.foundTrinket2)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.foundTrinket2), value);
    }

    public static int Trinket3
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.trinket3)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.trinket3), value);
    }

    public static bool FoundTrinket3
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.foundTrinket3)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.foundTrinket3), value);
    }

    public static int Trinket4
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.trinket4)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.trinket4), value);
    }

    public static bool FoundTrinket4
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.foundTrinket4)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.foundTrinket4), value);
    }

    public static bool NoTrinket1
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.noTrinket1)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.noTrinket1), value);
    }

    public static bool NoTrinket2
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.noTrinket2)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.noTrinket2), value);
    }

    public static bool NoTrinket3
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.noTrinket3)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.noTrinket3), value);
    }

    public static bool NoTrinket4
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.noTrinket4)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.noTrinket4), value);
    }

    public static int SoldTrinket1
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.soldTrinket1)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.soldTrinket1), value);
    }

    public static int SoldTrinket2
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.soldTrinket2)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.soldTrinket2), value);
    }

    public static int SoldTrinket3
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.soldTrinket3)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.soldTrinket3), value);
    }

    public static int SoldTrinket4
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.soldTrinket4)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.soldTrinket4), value);
    }

    public static int SimpleKeys
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.simpleKeys)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.simpleKeys), value);
    }

    public static int RancidEggs
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.rancidEggs)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.rancidEggs), value);
    }

    public static bool NotchShroomOgres
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.notchShroomOgres)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.notchShroomOgres), value);
    }

    public static bool NotchFogCanyon
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.notchFogCanyon)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.notchFogCanyon), value);
    }

    public static bool GotLurkerKey
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotLurkerKey)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotLurkerKey), value);
    }

    public static float GMap_doorX
    {
        get => PlayerData.instance?.GetFloat(nameof(PlayerData.gMap_doorX)) ?? -1;
        set => PlayerData.instance?.SetFloat(nameof(PlayerData.gMap_doorX), value);
    }

    public static float GMap_doorY
    {
        get => PlayerData.instance?.GetFloat(nameof(PlayerData.gMap_doorY)) ?? -1;
        set => PlayerData.instance?.SetFloat(nameof(PlayerData.gMap_doorY), value);
    }

    public static string GMap_doorScene
    {
        get => PlayerData.instance?.GetString(nameof(PlayerData.gMap_doorScene));
        set => PlayerData.instance?.SetString(nameof(PlayerData.gMap_doorScene), value);
    }

    public static string GMap_doorMapZone
    {
        get => PlayerData.instance?.GetString(nameof(PlayerData.gMap_doorMapZone));
        set => PlayerData.instance?.SetString(nameof(PlayerData.gMap_doorMapZone), value);
    }

    public static float GMap_doorOriginOffsetX
    {
        get => PlayerData.instance?.GetFloat(nameof(PlayerData.gMap_doorOriginOffsetX)) ?? -1;
        set => PlayerData.instance?.SetFloat(nameof(PlayerData.gMap_doorOriginOffsetX), value);
    }

    public static string GMap_doorOriginOffsetY
    {
        get => PlayerData.instance?.GetString(nameof(PlayerData.gMap_doorOriginOffsetY));
        set => PlayerData.instance?.SetString(nameof(PlayerData.gMap_doorOriginOffsetY), value);
    }

    public static float GMap_doorSceneWidth
    {
        get => PlayerData.instance?.GetFloat(nameof(PlayerData.gMap_doorSceneWidth)) ?? -1;
        set => PlayerData.instance?.SetFloat(nameof(PlayerData.gMap_doorSceneWidth), value);
    }

    public static string GMap_doorSceneHeight
    {
        get => PlayerData.instance?.GetString(nameof(PlayerData.gMap_doorSceneHeight));
        set => PlayerData.instance?.SetString(nameof(PlayerData.gMap_doorSceneHeight), value);
    }

    public static int GuardiansDefeated
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.guardiansDefeated)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.guardiansDefeated), value);
    }

    public static bool LurienDefeated
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.lurienDefeated)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.lurienDefeated), value);
    }

    public static bool HegemolDefeated
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hegemolDefeated)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hegemolDefeated), value);
    }

    public static bool MonomonDefeated
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.monomonDefeated)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.monomonDefeated), value);
    }

    public static bool MaskBrokenLurien
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.maskBrokenLurien)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.maskBrokenLurien), value);
    }

    public static bool MaskBrokenHegemol
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.maskBrokenHegemol)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.maskBrokenHegemol), value);
    }

    public static bool MaskBrokenMonomon
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.maskBrokenMonomon)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.maskBrokenMonomon), value);
    }

    public static int MaskToBreak
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.maskToBreak)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.maskToBreak), value);
    }

    public static int Elderbug
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.elderbug)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.elderbug), value);
    }

    public static bool MetElderbug
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.metElderbug)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.metElderbug), value);
    }

    public static bool ElderbugReintro
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.elderbugReintro)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.elderbugReintro), value);
    }

    public static int ElderbugHistory
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.elderbugHistory)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.elderbugHistory), value);
    }

    public static bool ElderbugHistory1
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.elderbugHistory1)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.elderbugHistory1), value);
    }

    public static bool ElderbugHistory2
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.elderbugHistory2)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.elderbugHistory2), value);
    }

    public static bool ElderbugHistory3
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.elderbugHistory3)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.elderbugHistory3), value);
    }

    public static bool ElderbugSpeechSly
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.elderbugSpeechSly)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.elderbugSpeechSly), value);
    }

    public static bool ElderbugSpeechStation
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.elderbugSpeechStation)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.elderbugSpeechStation), value);
    }

    public static bool ElderbugSpeechEggTemple
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.elderbugSpeechEggTemple)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.elderbugSpeechEggTemple), value);
    }

    public static bool ElderbugSpeechMapShop
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.elderbugSpeechMapShop)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.elderbugSpeechMapShop), value);
    }

    public static bool ElderbugSpeechBretta
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.elderbugSpeechBretta)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.elderbugSpeechBretta), value);
    }

    public static bool ElderbugSpeechJiji
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.elderbugSpeechJiji)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.elderbugSpeechJiji), value);
    }

    public static bool ElderbugSpeechMinesLift
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.elderbugSpeechMinesLift)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.elderbugSpeechMinesLift), value);
    }

    public static bool ElderbugSpeechKingsPass
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.elderbugSpeechKingsPass)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.elderbugSpeechKingsPass), value);
    }

    public static bool ElderbugSpeechInfectedCrossroads
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.elderbugSpeechInfectedCrossroads)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.elderbugSpeechInfectedCrossroads), value);
    }

    public static bool ElderbugSpeechFinalBossDoor
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.elderbugSpeechFinalBossDoor)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.elderbugSpeechFinalBossDoor), value);
    }

    public static bool ElderbugRequestedFlower
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.elderbugRequestedFlower)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.elderbugRequestedFlower), value);
    }

    public static bool ElderbugGaveFlower
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.elderbugGaveFlower)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.elderbugGaveFlower), value);
    }

    public static bool ElderbugFirstCall
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.elderbugFirstCall)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.elderbugFirstCall), value);
    }

    public static bool MetQuirrel
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.metQuirrel)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.metQuirrel), value);
    }

    public static int QuirrelEggTemple
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.quirrelEggTemple)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.quirrelEggTemple), value);
    }

    public static int QuirrelSlugShrine
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.quirrelSlugShrine)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.quirrelSlugShrine), value);
    }

    public static int QuirrelRuins
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.quirrelRuins)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.quirrelRuins), value);
    }

    public static int QuirrelMines
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.quirrelMines)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.quirrelMines), value);
    }

    public static bool QuirrelLeftStation
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.quirrelLeftStation)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.quirrelLeftStation), value);
    }

    public static bool QuirrelLeftEggTemple
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.quirrelLeftEggTemple)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.quirrelLeftEggTemple), value);
    }

    public static bool QuirrelCityEncountered
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.quirrelCityEncountered)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.quirrelCityEncountered), value);
    }

    public static bool QuirrelCityLeft
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.quirrelCityLeft)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.quirrelCityLeft), value);
    }

    public static bool QuirrelMinesEncountered
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.quirrelMinesEncountered)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.quirrelMinesEncountered), value);
    }

    public static bool QuirrelMinesLeft
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.quirrelMinesLeft)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.quirrelMinesLeft), value);
    }

    public static bool QuirrelMantisEncountered
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.quirrelMantisEncountered)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.quirrelMantisEncountered), value);
    }

    public static bool EnteredMantisLordArea
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.enteredMantisLordArea)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.enteredMantisLordArea), value);
    }

    public static bool VisitedDeepnestSpa
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.visitedDeepnestSpa)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.visitedDeepnestSpa), value);
    }

    public static bool QuirrelSpaReady
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.quirrelSpaReady)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.quirrelSpaReady), value);
    }

    public static bool QuirrelSpaEncountered
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.quirrelSpaEncountered)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.quirrelSpaEncountered), value);
    }

    public static bool QuirrelArchiveEncountered
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.quirrelArchiveEncountered)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.quirrelArchiveEncountered), value);
    }

    public static bool QuirrelEpilogueCompleted
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.quirrelEpilogueCompleted)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.quirrelEpilogueCompleted), value);
    }

    public static bool MetRelicDealer
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.metRelicDealer)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.metRelicDealer), value);
    }

    public static bool MetRelicDealerShop
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.metRelicDealerShop)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.metRelicDealerShop), value);
    }

    public static bool MarmOutside
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.marmOutside)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.marmOutside), value);
    }

    public static bool MarmOutsideConvo
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.marmOutsideConvo)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.marmOutsideConvo), value);
    }

    public static bool MarmConvo1
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.marmConvo1)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.marmConvo1), value);
    }

    public static bool MarmConvo2
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.marmConvo2)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.marmConvo2), value);
    }

    public static bool MarmConvo3
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.marmConvo3)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.marmConvo3), value);
    }

    public static bool MarmConvoNailsmith
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.marmConvoNailsmith)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.marmConvoNailsmith), value);
    }

    public static int Cornifer
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.cornifer)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.cornifer), value);
    }

    public static bool MetCornifer
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.metCornifer)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.metCornifer), value);
    }

    public static bool CorniferIntroduced
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.corniferIntroduced)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.corniferIntroduced), value);
    }

    public static bool CorniferAtHome
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.corniferAtHome)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.corniferAtHome), value);
    }

    public static bool Corn_crossroadsEncountered
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.corn_crossroadsEncountered)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.corn_crossroadsEncountered), value);
    }

    public static bool Corn_crossroadsLeft
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.corn_crossroadsLeft)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.corn_crossroadsLeft), value);
    }

    public static bool Corn_greenpathEncountered
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.corn_greenpathEncountered)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.corn_greenpathEncountered), value);
    }

    public static bool Corn_greenpathLeft
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.corn_greenpathLeft)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.corn_greenpathLeft), value);
    }

    public static bool Corn_fogCanyonEncountered
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.corn_fogCanyonEncountered)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.corn_fogCanyonEncountered), value);
    }

    public static bool Corn_fogCanyonLeft
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.corn_fogCanyonLeft)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.corn_fogCanyonLeft), value);
    }

    public static bool Corn_fungalWastesEncountered
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.corn_fungalWastesEncountered)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.corn_fungalWastesEncountered), value);
    }

    public static bool Corn_fungalWastesLeft
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.corn_fungalWastesLeft)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.corn_fungalWastesLeft), value);
    }

    public static bool Corn_cityEncountered
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.corn_cityEncountered)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.corn_cityEncountered), value);
    }

    public static bool Corn_cityLeft
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.corn_cityLeft)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.corn_cityLeft), value);
    }

    public static bool Corn_waterwaysEncountered
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.corn_waterwaysEncountered)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.corn_waterwaysEncountered), value);
    }

    public static bool Corn_waterwaysLeft
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.corn_waterwaysLeft)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.corn_waterwaysLeft), value);
    }

    public static bool Corn_minesEncountered
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.corn_minesEncountered)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.corn_minesEncountered), value);
    }

    public static bool Corn_minesLeft
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.corn_minesLeft)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.corn_minesLeft), value);
    }

    public static bool Corn_cliffsEncountered
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.corn_cliffsEncountered)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.corn_cliffsEncountered), value);
    }

    public static bool Corn_cliffsLeft
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.corn_cliffsLeft)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.corn_cliffsLeft), value);
    }

    public static bool Corn_deepnestEncountered
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.corn_deepnestEncountered)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.corn_deepnestEncountered), value);
    }

    public static bool Corn_deepnestLeft
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.corn_deepnestLeft)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.corn_deepnestLeft), value);
    }

    public static bool Corn_deepnestMet1
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.corn_deepnestMet1)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.corn_deepnestMet1), value);
    }

    public static bool Corn_deepnestMet2
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.corn_deepnestMet2)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.corn_deepnestMet2), value);
    }

    public static bool Corn_outskirtsEncountered
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.corn_outskirtsEncountered)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.corn_outskirtsEncountered), value);
    }

    public static bool Corn_outskirtsLeft
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.corn_outskirtsLeft)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.corn_outskirtsLeft), value);
    }

    public static bool Corn_royalGardensEncountered
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.corn_royalGardensEncountered)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.corn_royalGardensEncountered), value);
    }

    public static bool Corn_royalGardensLeft
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.corn_royalGardensLeft)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.corn_royalGardensLeft), value);
    }

    public static bool Corn_abyssEncountered
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.corn_abyssEncountered)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.corn_abyssEncountered), value);
    }

    public static bool Corn_abyssLeft
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.corn_abyssLeft)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.corn_abyssLeft), value);
    }

    public static bool MetIselda
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.metIselda)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.metIselda), value);
    }

    public static bool IseldaCorniferHomeConvo
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.iseldaCorniferHomeConvo)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.iseldaCorniferHomeConvo), value);
    }

    public static bool IseldaConvo1
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.iseldaConvo1)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.iseldaConvo1), value);
    }

    public static bool BrettaRescued
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.brettaRescued)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.brettaRescued), value);
    }

    public static int BrettaPosition
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.brettaPosition)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.brettaPosition), value);
    }

    public static int BrettaState
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.brettaState)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.brettaState), value);
    }

    public static bool BrettaSeenBench
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.brettaSeenBench)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.brettaSeenBench), value);
    }

    public static bool BrettaSeenBed
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.brettaSeenBed)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.brettaSeenBed), value);
    }

    public static bool BrettaSeenBenchDiary
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.brettaSeenBenchDiary)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.brettaSeenBenchDiary), value);
    }

    public static bool BrettaSeenBedDiary
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.brettaSeenBedDiary)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.brettaSeenBedDiary), value);
    }

    public static bool BrettaLeftTown
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.brettaLeftTown)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.brettaLeftTown), value);
    }

    public static bool SlyRescued
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.slyRescued)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.slyRescued), value);
    }

    public static bool SlyBeta
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.slyBeta)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.slyBeta), value);
    }

    public static bool MetSlyShop
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.metSlyShop)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.metSlyShop), value);
    }

    public static bool GotSlyCharm
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotSlyCharm)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotSlyCharm), value);
    }

    public static bool SlyShellFrag1
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.slyShellFrag1)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.slyShellFrag1), value);
    }

    public static bool SlyShellFrag2
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.slyShellFrag2)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.slyShellFrag2), value);
    }

    public static bool SlyShellFrag3
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.slyShellFrag3)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.slyShellFrag3), value);
    }

    public static bool SlyShellFrag4
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.slyShellFrag4)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.slyShellFrag4), value);
    }

    public static bool SlyVesselFrag1
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.slyVesselFrag1)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.slyVesselFrag1), value);
    }

    public static bool SlyVesselFrag2
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.slyVesselFrag2)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.slyVesselFrag2), value);
    }

    public static bool SlyVesselFrag3
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.slyVesselFrag3)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.slyVesselFrag3), value);
    }

    public static bool SlyVesselFrag4
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.slyVesselFrag4)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.slyVesselFrag4), value);
    }

    public static bool SlyNotch1
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.slyNotch1)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.slyNotch1), value);
    }

    public static bool SlyNotch2
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.slyNotch2)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.slyNotch2), value);
    }

    public static bool SlySimpleKey
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.slySimpleKey)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.slySimpleKey), value);
    }

    public static bool SlyRancidEgg
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.slyRancidEgg)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.slyRancidEgg), value);
    }

    public static bool SlyConvoNailArt
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.slyConvoNailArt)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.slyConvoNailArt), value);
    }

    public static bool SlyConvoMapper
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.slyConvoMapper)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.slyConvoMapper), value);
    }

    public static bool SlyConvoNailHoned
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.slyConvoNailHoned)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.slyConvoNailHoned), value);
    }

    public static bool JijiDoorUnlocked
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.jijiDoorUnlocked)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.jijiDoorUnlocked), value);
    }

    public static bool JijiMet
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.jijiMet)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.jijiMet), value);
    }

    public static bool JijiShadeOffered
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.jijiShadeOffered)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.jijiShadeOffered), value);
    }

    public static bool JijiShadeCharmConvo
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.jijiShadeCharmConvo)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.jijiShadeCharmConvo), value);
    }

    public static bool MetJinn
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.metJinn)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.metJinn), value);
    }

    public static bool JinnConvo1
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.jinnConvo1)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.jinnConvo1), value);
    }

    public static bool JinnConvo2
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.jinnConvo2)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.jinnConvo2), value);
    }

    public static bool JinnConvo3
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.jinnConvo3)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.jinnConvo3), value);
    }

    public static bool JinnConvoKingBrand
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.jinnConvoKingBrand)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.jinnConvoKingBrand), value);
    }

    public static bool JinnConvoShadeCharm
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.jinnConvoShadeCharm)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.jinnConvoShadeCharm), value);
    }

    public static int JinnEggsSold
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.jinnEggsSold)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.jinnEggsSold), value);
    }

    public static int Zote
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.zote)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.zote), value);
    }

    public static bool ZoteRescuedBuzzer
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.zoteRescuedBuzzer)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.zoteRescuedBuzzer), value);
    }

    public static bool ZoteDead
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.zoteDead)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.zoteDead), value);
    }

    public static int ZoteDeathPos
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.zoteDeathPos)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.zoteDeathPos), value);
    }

    public static bool ZoteSpokenCity
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.zoteSpokenCity)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.zoteSpokenCity), value);
    }

    public static bool ZoteLeftCity
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.zoteLeftCity)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.zoteLeftCity), value);
    }

    public static bool ZoteTrappedDeepnest
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.zoteTrappedDeepnest)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.zoteTrappedDeepnest), value);
    }

    public static bool ZoteRescuedDeepnest
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.zoteRescuedDeepnest)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.zoteRescuedDeepnest), value);
    }

    public static bool ZoteDefeated
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.zoteDefeated)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.zoteDefeated), value);
    }

    public static bool ZoteSpokenColosseum
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.zoteSpokenColosseum)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.zoteSpokenColosseum), value);
    }

    public static int ZotePrecept
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.zotePrecept)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.zotePrecept), value);
    }

    public static int ZoteTownConvo
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.zoteTownConvo)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.zoteTownConvo), value);
    }

    public static int Shaman
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.shaman)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.shaman), value);
    }

    public static bool ShamanScreamConvo
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.shamanScreamConvo)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.shamanScreamConvo), value);
    }

    public static bool ShamanQuakeConvo
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.shamanQuakeConvo)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.shamanQuakeConvo), value);
    }

    public static bool ShamanFireball2Convo
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.shamanFireball2Convo)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.shamanFireball2Convo), value);
    }

    public static bool ShamanScream2Convo
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.shamanScream2Convo)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.shamanScream2Convo), value);
    }

    public static bool ShamanQuake2Convo
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.shamanQuake2Convo)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.shamanQuake2Convo), value);
    }

    public static bool MetMiner
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.metMiner)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.metMiner), value);
    }

    public static int Miner
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.miner)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.miner), value);
    }

    public static int MinerEarly
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.minerEarly)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.minerEarly), value);
    }

    public static int HornetGreenpath
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.hornetGreenpath)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.hornetGreenpath), value);
    }

    public static int HornetFung
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.hornetFung)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.hornetFung), value);
    }

    public static bool Hornet_f19
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hornet_f19)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hornet_f19), value);
    }

    public static bool HornetFountainEncounter
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hornetFountainEncounter)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hornetFountainEncounter), value);
    }

    public static bool HornetCityBridge_ready
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hornetCityBridge_ready)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hornetCityBridge_ready), value);
    }

    public static bool HornetCityBridge_completed
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hornetCityBridge_completed)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hornetCityBridge_completed), value);
    }

    public static bool HornetAbyssEncounter
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hornetAbyssEncounter)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hornetAbyssEncounter), value);
    }

    public static bool HornetDenEncounter
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hornetDenEncounter)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hornetDenEncounter), value);
    }

    public static bool MetMoth
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.metMoth)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.metMoth), value);
    }

    public static bool IgnoredMoth
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.ignoredMoth)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.ignoredMoth), value);
    }

    public static bool GladeDoorOpened
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gladeDoorOpened)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gladeDoorOpened), value);
    }

    public static bool MothDeparted
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.mothDeparted)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.mothDeparted), value);
    }

    public static bool CompletedRGDreamPlant
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.completedRGDreamPlant)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.completedRGDreamPlant), value);
    }

    public static bool DreamReward1
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.dreamReward1)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.dreamReward1), value);
    }

    public static bool DreamReward2
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.dreamReward2)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.dreamReward2), value);
    }

    public static bool DreamReward3
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.dreamReward3)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.dreamReward3), value);
    }

    public static bool DreamReward4
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.dreamReward4)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.dreamReward4), value);
    }

    public static bool DreamReward5
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.dreamReward5)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.dreamReward5), value);
    }

    public static bool DreamReward5b
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.dreamReward5b)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.dreamReward5b), value);
    }

    public static bool DreamReward6
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.dreamReward6)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.dreamReward6), value);
    }

    public static bool DreamReward7
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.dreamReward7)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.dreamReward7), value);
    }

    public static bool DreamReward8
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.dreamReward8)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.dreamReward8), value);
    }

    public static bool DreamReward9
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.dreamReward9)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.dreamReward9), value);
    }

    public static bool DreamMothConvo1
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.dreamMothConvo1)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.dreamMothConvo1), value);
    }

    public static bool BankerAccountPurchased
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.bankerAccountPurchased)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.bankerAccountPurchased), value);
    }

    public static bool MetBanker
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.metBanker)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.metBanker), value);
    }

    public static int BankerBalance
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.bankerBalance)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.bankerBalance), value);
    }

    public static bool BankerDeclined
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.bankerDeclined)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.bankerDeclined), value);
    }

    public static bool BankerTheftCheck
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.bankerTheftCheck)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.bankerTheftCheck), value);
    }

    public static int BankerTheft
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.bankerTheft)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.bankerTheft), value);
    }

    public static bool BankerSpaMet
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.bankerSpaMet)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.bankerSpaMet), value);
    }

    public static bool MetGiraffe
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.metGiraffe)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.metGiraffe), value);
    }

    public static bool MetCharmSlug
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.metCharmSlug)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.metCharmSlug), value);
    }

    public static bool SalubraNotch1
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.salubraNotch1)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.salubraNotch1), value);
    }

    public static bool SalubraNotch2
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.salubraNotch2)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.salubraNotch2), value);
    }

    public static bool SalubraNotch3
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.salubraNotch3)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.salubraNotch3), value);
    }

    public static bool SalubraNotch4
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.salubraNotch4)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.salubraNotch4), value);
    }

    public static bool SalubraBlessing
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.salubraBlessing)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.salubraBlessing), value);
    }

    public static bool SalubraConvoCombo
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.salubraConvoCombo)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.salubraConvoCombo), value);
    }

    public static bool SalubraConvoOvercharm
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.salubraConvoOvercharm)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.salubraConvoOvercharm), value);
    }

    public static bool SalubraConvoTruth
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.salubraConvoTruth)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.salubraConvoTruth), value);
    }

    public static bool CultistTransformed
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.cultistTransformed)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.cultistTransformed), value);
    }

    public static bool MetNailsmith
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.metNailsmith)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.metNailsmith), value);
    }

    public static int NailSmithUpgrades
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.nailSmithUpgrades)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.nailSmithUpgrades), value);
    }

    public static bool HonedNail
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.honedNail)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.honedNail), value);
    }

    public static bool NailsmithCliff
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.nailsmithCliff)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.nailsmithCliff), value);
    }

    public static bool NailsmithKilled
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.nailsmithKilled)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.nailsmithKilled), value);
    }

    public static bool NailsmithSpared
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.nailsmithSpared)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.nailsmithSpared), value);
    }

    public static bool NailsmithKillSpeech
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.nailsmithKillSpeech)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.nailsmithKillSpeech), value);
    }

    public static bool NailsmithSheo
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.nailsmithSheo)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.nailsmithSheo), value);
    }

    public static bool NailsmithConvoArt
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.nailsmithConvoArt)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.nailsmithConvoArt), value);
    }

    public static bool MetNailmasterMato
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.metNailmasterMato)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.metNailmasterMato), value);
    }

    public static bool MetNailmasterSheo
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.metNailmasterSheo)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.metNailmasterSheo), value);
    }

    public static bool MetNailmasterOro
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.metNailmasterOro)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.metNailmasterOro), value);
    }

    public static bool MatoConvoSheo
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.matoConvoSheo)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.matoConvoSheo), value);
    }

    public static bool MatoConvoOro
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.matoConvoOro)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.matoConvoOro), value);
    }

    public static bool MatoConvoSly
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.matoConvoSly)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.matoConvoSly), value);
    }

    public static bool SheoConvoMato
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.sheoConvoMato)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.sheoConvoMato), value);
    }

    public static bool SheoConvoOro
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.sheoConvoOro)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.sheoConvoOro), value);
    }

    public static bool SheoConvoSly
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.sheoConvoSly)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.sheoConvoSly), value);
    }

    public static bool SheoConvoNailsmith
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.sheoConvoNailsmith)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.sheoConvoNailsmith), value);
    }

    public static bool OroConvoSheo
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.oroConvoSheo)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.oroConvoSheo), value);
    }

    public static bool OroConvoMato
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.oroConvoMato)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.oroConvoMato), value);
    }

    public static bool OroConvoSly
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.oroConvoSly)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.oroConvoSly), value);
    }

    public static bool HunterRoared
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hunterRoared)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hunterRoared), value);
    }

    public static bool MetHunter
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.metHunter)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.metHunter), value);
    }

    public static bool HunterRewardOffered
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hunterRewardOffered)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hunterRewardOffered), value);
    }

    public static bool HuntersMarkOffered
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.huntersMarkOffered)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.huntersMarkOffered), value);
    }

    public static bool HasHuntersMark
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasHuntersMark)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasHuntersMark), value);
    }

    public static bool MetLegEater
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.metLegEater)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.metLegEater), value);
    }

    public static bool PaidLegEater
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.paidLegEater)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.paidLegEater), value);
    }

    public static bool RefusedLegEater
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.refusedLegEater)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.refusedLegEater), value);
    }

    public static bool LegEaterConvo1
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.legEaterConvo1)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.legEaterConvo1), value);
    }

    public static bool LegEaterConvo2
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.legEaterConvo2)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.legEaterConvo2), value);
    }

    public static bool LegEaterConvo3
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.legEaterConvo3)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.legEaterConvo3), value);
    }

    public static bool LegEaterBrokenConvo
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.legEaterBrokenConvo)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.legEaterBrokenConvo), value);
    }

    public static bool LegEaterDungConvo
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.legEaterDungConvo)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.legEaterDungConvo), value);
    }

    public static bool LegEaterInfectedCrossroadConvo
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.legEaterInfectedCrossroadConvo)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.legEaterInfectedCrossroadConvo), value);
    }

    public static bool LegEaterBoughtConvo
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.legEaterBoughtConvo)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.legEaterBoughtConvo), value);
    }

    public static bool LegEaterGoldConvo
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.legEaterGoldConvo)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.legEaterGoldConvo), value);
    }

    public static bool LegEaterLeft
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.legEaterLeft)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.legEaterLeft), value);
    }

    public static bool TukMet
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.tukMet)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.tukMet), value);
    }

    public static int TukEggPrice
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.tukEggPrice)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.tukEggPrice), value);
    }

    public static bool TukDungEgg
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.tukDungEgg)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.tukDungEgg), value);
    }

    public static bool MetEmilitia
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.metEmilitia)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.metEmilitia), value);
    }

    public static bool EmilitiaKingsBrandConvo
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.emilitiaKingsBrandConvo)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.emilitiaKingsBrandConvo), value);
    }

    public static bool MetCloth
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.metCloth)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.metCloth), value);
    }

    public static bool ClothEnteredTramRoom
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.clothEnteredTramRoom)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.clothEnteredTramRoom), value);
    }

    public static bool SavedCloth
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.savedCloth)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.savedCloth), value);
    }

    public static bool ClothEncounteredQueensGarden
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.clothEncounteredQueensGarden)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.clothEncounteredQueensGarden), value);
    }

    public static bool ClothKilled
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.clothKilled)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.clothKilled), value);
    }

    public static bool ClothInTown
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.clothInTown)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.clothInTown), value);
    }

    public static bool ClothLeftTown
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.clothLeftTown)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.clothLeftTown), value);
    }

    public static bool ClothGhostSpoken
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.clothGhostSpoken)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.clothGhostSpoken), value);
    }

    public static bool BigCatHitTail
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.bigCatHitTail)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.bigCatHitTail), value);
    }

    public static bool BigCatHitTailConvo
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.bigCatHitTailConvo)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.bigCatHitTailConvo), value);
    }

    public static bool BigCatMeet
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.bigCatMeet)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.bigCatMeet), value);
    }

    public static bool BigCatTalk1
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.bigCatTalk1)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.bigCatTalk1), value);
    }

    public static bool BigCatTalk2
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.bigCatTalk2)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.bigCatTalk2), value);
    }

    public static bool BigCatTalk3
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.bigCatTalk3)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.bigCatTalk3), value);
    }

    public static bool BigCatKingsBrandConvo
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.bigCatKingsBrandConvo)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.bigCatKingsBrandConvo), value);
    }

    public static bool BigCatShadeConvo
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.bigCatShadeConvo)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.bigCatShadeConvo), value);
    }

    public static bool TisoEncounteredTown
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.tisoEncounteredTown)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.tisoEncounteredTown), value);
    }

    public static bool TisoEncounteredBench
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.tisoEncounteredBench)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.tisoEncounteredBench), value);
    }

    public static bool TisoEncounteredLake
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.tisoEncounteredLake)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.tisoEncounteredLake), value);
    }

    public static bool TisoEncounteredColosseum
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.tisoEncounteredColosseum)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.tisoEncounteredColosseum), value);
    }

    public static bool TisoDead
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.tisoDead)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.tisoDead), value);
    }

    public static bool TisoShieldConvo
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.tisoShieldConvo)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.tisoShieldConvo), value);
    }

    public static int MossCultist
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.mossCultist)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.mossCultist), value);
    }

    public static bool MaskmakerMet
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.maskmakerMet)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.maskmakerMet), value);
    }

    public static bool MaskmakerConvo1
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.maskmakerConvo1)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.maskmakerConvo1), value);
    }

    public static bool MaskmakerConvo2
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.maskmakerConvo2)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.maskmakerConvo2), value);
    }

    public static bool MaskmakerUnmasked1
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.maskmakerUnmasked1)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.maskmakerUnmasked1), value);
    }

    public static bool MaskmakerUnmasked2
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.maskmakerUnmasked2)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.maskmakerUnmasked2), value);
    }

    public static bool MaskmakerShadowDash
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.maskmakerShadowDash)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.maskmakerShadowDash), value);
    }

    public static bool MaskmakerKingsBrand
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.maskmakerKingsBrand)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.maskmakerKingsBrand), value);
    }

    public static bool DungDefenderConvo1
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.dungDefenderConvo1)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.dungDefenderConvo1), value);
    }

    public static bool DungDefenderConvo2
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.dungDefenderConvo2)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.dungDefenderConvo2), value);
    }

    public static bool DungDefenderConvo3
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.dungDefenderConvo3)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.dungDefenderConvo3), value);
    }

    public static bool DungDefenderCharmConvo
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.dungDefenderCharmConvo)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.dungDefenderCharmConvo), value);
    }

    public static bool DungDefenderIsmaConvo
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.dungDefenderIsmaConvo)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.dungDefenderIsmaConvo), value);
    }

    public static bool DungDefenderAwoken
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.dungDefenderAwoken)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.dungDefenderAwoken), value);
    }

    public static bool DungDefenderLeft
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.dungDefenderLeft)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.dungDefenderLeft), value);
    }

    public static bool DungDefenderAwakeConvo
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.dungDefenderAwakeConvo)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.dungDefenderAwakeConvo), value);
    }

    public static bool MidwifeMet
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.midwifeMet)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.midwifeMet), value);
    }

    public static bool MidwifeConvo1
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.midwifeConvo1)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.midwifeConvo1), value);
    }

    public static bool MidwifeConvo2
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.midwifeConvo2)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.midwifeConvo2), value);
    }

    public static bool MetQueen
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.metQueen)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.metQueen), value);
    }

    public static bool QueenTalk1
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.queenTalk1)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.queenTalk1), value);
    }

    public static bool QueenTalk2
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.queenTalk2)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.queenTalk2), value);
    }

    public static bool QueenDung1
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.queenDung1)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.queenDung1), value);
    }

    public static bool QueenDung2
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.queenDung2)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.queenDung2), value);
    }

    public static bool QueenHornet
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.queenHornet)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.queenHornet), value);
    }

    public static bool QueenTalkExtra
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.queenTalkExtra)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.queenTalkExtra), value);
    }

    public static bool GotQueenFragment
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotQueenFragment)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotQueenFragment), value);
    }

    public static bool QueenConvo_grimm1
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.queenConvo_grimm1)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.queenConvo_grimm1), value);
    }

    public static bool QueenConvo_grimm2
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.queenConvo_grimm2)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.queenConvo_grimm2), value);
    }

    public static bool GotKingFragment
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotKingFragment)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotKingFragment), value);
    }

    public static bool MetXun
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.metXun)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.metXun), value);
    }

    public static bool XunFailedConvo1
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.xunFailedConvo1)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.xunFailedConvo1), value);
    }

    public static bool XunFailedConvo2
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.xunFailedConvo2)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.xunFailedConvo2), value);
    }

    public static bool XunFlowerBroken
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.xunFlowerBroken)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.xunFlowerBroken), value);
    }

    public static int XunFlowerBrokeTimes
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.xunFlowerBrokeTimes)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.xunFlowerBrokeTimes), value);
    }

    public static bool XunFlowerGiven
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.xunFlowerGiven)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.xunFlowerGiven), value);
    }

    public static bool XunRewardGiven
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.xunRewardGiven)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.xunRewardGiven), value);
    }

    public static int MenderState
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.menderState)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.menderState), value);
    }

    public static bool MenderSignBroken
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.menderSignBroken)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.menderSignBroken), value);
    }

    public static bool AllBelieverTabletsDestroyed
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.allBelieverTabletsDestroyed)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.allBelieverTabletsDestroyed), value);
    }

    public static int MrMushroomState
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.mrMushroomState)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.mrMushroomState), value);
    }

    public static bool OpenedMapperShop
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.openedMapperShop)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.openedMapperShop), value);
    }

    public static bool OpenedSlyShop
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.openedSlyShop)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.openedSlyShop), value);
    }

    public static bool MetStag
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.metStag)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.metStag), value);
    }

    public static bool Travelling
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.travelling)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.travelling), value);
    }

    public static int StagPosition
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.stagPosition)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.stagPosition), value);
    }

    public static int StationsOpened
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.stationsOpened)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.stationsOpened), value);
    }

    public static bool StagConvoTram
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.stagConvoTram)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.stagConvoTram), value);
    }

    public static bool StagConvoTiso
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.stagConvoTiso)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.stagConvoTiso), value);
    }

    public static bool StagRemember1
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.stagRemember1)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.stagRemember1), value);
    }

    public static bool StagRemember2
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.stagRemember2)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.stagRemember2), value);
    }

    public static bool StagRemember3
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.stagRemember3)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.stagRemember3), value);
    }

    public static bool StagEggInspected
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.stagEggInspected)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.stagEggInspected), value);
    }

    public static bool StagHopeConvo
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.stagHopeConvo)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.stagHopeConvo), value);
    }

    public static string nextScene
    {
        get => PlayerData.instance?.GetString(nameof(PlayerData.nextScene));
        set => PlayerData.instance?.SetString(nameof(PlayerData.nextScene), value);
    }

    public static bool LittleFoolMet
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.littleFoolMet)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.littleFoolMet), value);
    }

    public static bool RanAway
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.ranAway)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.ranAway), value);
    }

    public static bool SeenColosseumTitle
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.seenColosseumTitle)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.seenColosseumTitle), value);
    }

    public static bool ColosseumBronzeOpened
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.colosseumBronzeOpened)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.colosseumBronzeOpened), value);
    }

    public static bool ColosseumBronzeCompleted
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.colosseumBronzeCompleted)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.colosseumBronzeCompleted), value);
    }

    public static bool ColosseumSilverOpened
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.colosseumSilverOpened)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.colosseumSilverOpened), value);
    }

    public static bool ColosseumSilverCompleted
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.colosseumSilverCompleted)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.colosseumSilverCompleted), value);
    }

    public static bool ColosseumGoldOpened
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.colosseumGoldOpened)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.colosseumGoldOpened), value);
    }

    public static bool ColosseumGoldCompleted
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.colosseumGoldCompleted)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.colosseumGoldCompleted), value);
    }

    public static bool OpenedTown
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.openedTown)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.openedTown), value);
    }

    public static bool OpenedTownBuilding
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.openedTownBuilding)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.openedTownBuilding), value);
    }

    public static bool OpenedCrossroads
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.openedCrossroads)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.openedCrossroads), value);
    }

    public static bool OpenedGreenpath
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.openedGreenpath)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.openedGreenpath), value);
    }

    public static bool OpenedRuins1
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.openedRuins1)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.openedRuins1), value);
    }

    public static bool OpenedRuins2
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.openedRuins2)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.openedRuins2), value);
    }

    public static bool OpenedFungalWastes
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.openedFungalWastes)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.openedFungalWastes), value);
    }

    public static bool OpenedRoyalGardens
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.openedRoyalGardens)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.openedRoyalGardens), value);
    }

    public static bool OpenedRestingGrounds
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.openedRestingGrounds)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.openedRestingGrounds), value);
    }

    public static bool OpenedDeepnest
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.openedDeepnest)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.openedDeepnest), value);
    }

    public static bool OpenedStagNest
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.openedStagNest)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.openedStagNest), value);
    }

    public static bool OpenedHiddenStation
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.openedHiddenStation)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.openedHiddenStation), value);
    }

    public static string dreamReturnScene
    {
        get => PlayerData.instance?.GetString(nameof(PlayerData.dreamReturnScene));
        set => PlayerData.instance?.SetString(nameof(PlayerData.dreamReturnScene), value);
    }

    public static int CharmSlots
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmSlots)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmSlots), value);
    }

    public static int CharmSlotsFilled
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmSlotsFilled)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmSlotsFilled), value);
    }

    public static bool HasCharm
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasCharm)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasCharm), value);
    }

    public static bool CharmBenchMsg
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.charmBenchMsg)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.charmBenchMsg), value);
    }

    public static int CharmsOwned
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmsOwned)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmsOwned), value);
    }

    public static bool CanOvercharm
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.canOvercharm)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.canOvercharm), value);
    }

    public static bool Overcharmed
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.overcharmed)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.overcharmed), value);
    }

    public static bool GotCharm_1
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_1)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_1), value);
    }

    public static bool EquippedCharm_1
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_1)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_1), value);
    }

    public static int CharmCost_1
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_1)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_1), value);
    }

    public static bool NewCharm_1
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_1)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_1), value);
    }

    public static bool GotCharm_2
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_2)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_2), value);
    }

    public static bool EquippedCharm_2
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_2)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_2), value);
    }

    public static int CharmCost_2
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_2)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_2), value);
    }

    public static bool NewCharm_2
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_2)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_2), value);
    }

    public static bool GotCharm_3
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_3)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_3), value);
    }

    public static bool EquippedCharm_3
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_3)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_3), value);
    }

    public static int CharmCost_3
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_3)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_3), value);
    }

    public static bool NewCharm_3
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_3)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_3), value);
    }

    public static bool GotCharm_4
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_4)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_4), value);
    }

    public static bool EquippedCharm_4
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_4)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_4), value);
    }

    public static int CharmCost_4
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_4)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_4), value);
    }

    public static bool NewCharm_4
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_4)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_4), value);
    }

    public static bool GotCharm_5
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_5)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_5), value);
    }

    public static bool EquippedCharm_5
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_5)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_5), value);
    }

    public static int CharmCost_5
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_5)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_5), value);
    }

    public static bool NewCharm_5
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_5)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_5), value);
    }

    public static bool GotCharm_6
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_6)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_6), value);
    }

    public static bool EquippedCharm_6
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_6)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_6), value);
    }

    public static int CharmCost_6
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_6)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_6), value);
    }

    public static bool NewCharm_6
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_6)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_6), value);
    }

    public static bool GotCharm_7
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_7)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_7), value);
    }

    public static bool EquippedCharm_7
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_7)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_7), value);
    }

    public static int CharmCost_7
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_7)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_7), value);
    }

    public static bool NewCharm_7
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_7)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_7), value);
    }

    public static bool GotCharm_8
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_8)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_8), value);
    }

    public static bool EquippedCharm_8
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_8)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_8), value);
    }

    public static int CharmCost_8
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_8)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_8), value);
    }

    public static bool NewCharm_8
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_8)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_8), value);
    }

    public static bool GotCharm_9
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_9)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_9), value);
    }

    public static bool EquippedCharm_9
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_9)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_9), value);
    }

    public static int CharmCost_9
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_9)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_9), value);
    }

    public static bool NewCharm_9
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_9)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_9), value);
    }

    public static bool GotCharm_10
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_10)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_10), value);
    }

    public static bool EquippedCharm_10
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_10)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_10), value);
    }

    public static int CharmCost_10
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_10)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_10), value);
    }

    public static bool NewCharm_10
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_10)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_10), value);
    }

    public static bool GotCharm_11
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_11)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_11), value);
    }

    public static bool EquippedCharm_11
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_11)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_11), value);
    }

    public static int CharmCost_11
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_11)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_11), value);
    }

    public static bool NewCharm_11
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_11)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_11), value);
    }

    public static bool GotCharm_12
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_12)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_12), value);
    }

    public static bool EquippedCharm_12
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_12)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_12), value);
    }

    public static int CharmCost_12
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_12)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_12), value);
    }

    public static bool NewCharm_12
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_12)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_12), value);
    }

    public static bool GotCharm_13
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_13)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_13), value);
    }

    public static bool EquippedCharm_13
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_13)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_13), value);
    }

    public static int CharmCost_13
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_13)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_13), value);
    }

    public static bool NewCharm_13
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_13)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_13), value);
    }

    public static bool GotCharm_14
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_14)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_14), value);
    }

    public static bool EquippedCharm_14
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_14)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_14), value);
    }

    public static int CharmCost_14
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_14)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_14), value);
    }

    public static bool NewCharm_14
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_14)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_14), value);
    }

    public static bool GotCharm_15
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_15)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_15), value);
    }

    public static bool EquippedCharm_15
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_15)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_15), value);
    }

    public static int CharmCost_15
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_15)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_15), value);
    }

    public static bool NewCharm_15
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_15)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_15), value);
    }

    public static bool GotCharm_16
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_16)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_16), value);
    }

    public static bool EquippedCharm_16
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_16)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_16), value);
    }

    public static int CharmCost_16
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_16)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_16), value);
    }

    public static bool NewCharm_16
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_16)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_16), value);
    }

    public static bool GotCharm_17
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_17)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_17), value);
    }

    public static bool EquippedCharm_17
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_17)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_17), value);
    }

    public static int CharmCost_17
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_17)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_17), value);
    }

    public static bool NewCharm_17
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_17)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_17), value);
    }

    public static bool GotCharm_18
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_18)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_18), value);
    }

    public static bool EquippedCharm_18
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_18)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_18), value);
    }

    public static int CharmCost_18
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_18)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_18), value);
    }

    public static bool NewCharm_18
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_18)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_18), value);
    }

    public static bool GotCharm_19
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_19)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_19), value);
    }

    public static bool EquippedCharm_19
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_19)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_19), value);
    }

    public static int CharmCost_19
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_19)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_19), value);
    }

    public static bool NewCharm_19
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_19)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_19), value);
    }

    public static bool GotCharm_20
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_20)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_20), value);
    }

    public static bool EquippedCharm_20
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_20)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_20), value);
    }

    public static int CharmCost_20
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_20)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_20), value);
    }

    public static bool NewCharm_20
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_20)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_20), value);
    }

    public static bool GotCharm_21
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_21)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_21), value);
    }

    public static bool EquippedCharm_21
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_21)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_21), value);
    }

    public static int CharmCost_21
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_21)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_21), value);
    }

    public static bool NewCharm_21
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_21)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_21), value);
    }

    public static bool GotCharm_22
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_22)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_22), value);
    }

    public static bool EquippedCharm_22
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_22)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_22), value);
    }

    public static int CharmCost_22
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_22)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_22), value);
    }

    public static bool NewCharm_22
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_22)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_22), value);
    }

    public static bool GotCharm_23
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_23)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_23), value);
    }

    public static bool EquippedCharm_23
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_23)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_23), value);
    }

    public static bool BrokenCharm_23
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.brokenCharm_23)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.brokenCharm_23), value);
    }

    public static int CharmCost_23
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_23)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_23), value);
    }

    public static bool NewCharm_23
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_23)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_23), value);
    }

    public static bool GotCharm_24
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_24)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_24), value);
    }

    public static bool EquippedCharm_24
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_24)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_24), value);
    }

    public static bool BrokenCharm_24
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.brokenCharm_24)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.brokenCharm_24), value);
    }

    public static int CharmCost_24
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_24)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_24), value);
    }

    public static bool NewCharm_24
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_24)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_24), value);
    }

    public static bool GotCharm_25
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_25)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_25), value);
    }

    public static bool EquippedCharm_25
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_25)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_25), value);
    }

    public static bool BrokenCharm_25
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.brokenCharm_25)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.brokenCharm_25), value);
    }

    public static int CharmCost_25
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_25)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_25), value);
    }

    public static bool NewCharm_25
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_25)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_25), value);
    }

    public static bool GotCharm_26
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_26)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_26), value);
    }

    public static bool EquippedCharm_26
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_26)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_26), value);
    }

    public static int CharmCost_26
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_26)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_26), value);
    }

    public static bool NewCharm_26
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_26)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_26), value);
    }

    public static bool GotCharm_27
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_27)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_27), value);
    }

    public static bool EquippedCharm_27
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_27)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_27), value);
    }

    public static int CharmCost_27
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_27)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_27), value);
    }

    public static bool NewCharm_27
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_27)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_27), value);
    }

    public static bool GotCharm_28
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_28)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_28), value);
    }

    public static bool EquippedCharm_28
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_28)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_28), value);
    }

    public static int CharmCost_28
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_28)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_28), value);
    }

    public static bool NewCharm_28
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_28)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_28), value);
    }

    public static bool GotCharm_29
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_29)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_29), value);
    }

    public static bool EquippedCharm_29
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_29)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_29), value);
    }

    public static int CharmCost_29
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_29)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_29), value);
    }

    public static bool NewCharm_29
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_29)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_29), value);
    }

    public static bool GotCharm_30
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_30)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_30), value);
    }

    public static bool EquippedCharm_30
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_30)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_30), value);
    }

    public static int CharmCost_30
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_30)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_30), value);
    }

    public static bool NewCharm_30
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_30)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_30), value);
    }

    public static bool GotCharm_31
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_31)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_31), value);
    }

    public static bool EquippedCharm_31
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_31)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_31), value);
    }

    public static int CharmCost_31
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_31)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_31), value);
    }

    public static bool NewCharm_31
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_31)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_31), value);
    }

    public static bool GotCharm_32
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_32)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_32), value);
    }

    public static bool EquippedCharm_32
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_32)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_32), value);
    }

    public static int CharmCost_32
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_32)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_32), value);
    }

    public static bool NewCharm_32
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_32)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_32), value);
    }

    public static bool GotCharm_33
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_33)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_33), value);
    }

    public static bool EquippedCharm_33
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_33)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_33), value);
    }

    public static int CharmCost_33
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_33)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_33), value);
    }

    public static bool NewCharm_33
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_33)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_33), value);
    }

    public static bool GotCharm_34
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_34)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_34), value);
    }

    public static bool EquippedCharm_34
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_34)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_34), value);
    }

    public static int CharmCost_34
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_34)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_34), value);
    }

    public static bool NewCharm_34
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_34)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_34), value);
    }

    public static bool GotCharm_35
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_35)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_35), value);
    }

    public static bool EquippedCharm_35
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_35)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_35), value);
    }

    public static int CharmCost_35
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_35)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_35), value);
    }

    public static bool NewCharm_35
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_35)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_35), value);
    }

    public static bool GotCharm_36
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_36)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_36), value);
    }

    public static bool EquippedCharm_36
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_36)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_36), value);
    }

    public static int CharmCost_36
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_36)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_36), value);
    }

    public static bool NewCharm_36
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_36)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_36), value);
    }

    public static bool GotCharm_37
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_37)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_37), value);
    }

    public static bool EquippedCharm_37
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_37)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_37), value);
    }

    public static int CharmCost_37
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_37)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_37), value);
    }

    public static bool NewCharm_37
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_37)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_37), value);
    }

    public static bool GotCharm_38
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_38)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_38), value);
    }

    public static bool EquippedCharm_38
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_38)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_38), value);
    }

    public static int CharmCost_38
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_38)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_38), value);
    }

    public static bool NewCharm_38
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_38)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_38), value);
    }

    public static bool GotCharm_39
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_39)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_39), value);
    }

    public static bool EquippedCharm_39
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_39)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_39), value);
    }

    public static int CharmCost_39
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_39)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_39), value);
    }

    public static bool NewCharm_39
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_39)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_39), value);
    }

    public static bool GotCharm_40
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotCharm_40)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotCharm_40), value);
    }

    public static bool EquippedCharm_40
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.equippedCharm_40)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.equippedCharm_40), value);
    }

    public static int CharmCost_40
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.charmCost_40)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.charmCost_40), value);
    }

    public static bool NewCharm_40
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newCharm_40)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newCharm_40), value);
    }

    public static bool FragileHealth_unbreakable
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.fragileHealth_unbreakable)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.fragileHealth_unbreakable), value);
    }

    public static bool FragileGreed_unbreakable
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.fragileGreed_unbreakable)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.fragileGreed_unbreakable), value);
    }

    public static bool FragileStrength_unbreakable
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.fragileStrength_unbreakable)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.fragileStrength_unbreakable), value);
    }

    public static int RoyalCharmState
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.royalCharmState)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.royalCharmState), value);
    }

    public static bool HasJournal
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasJournal)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasJournal), value);
    }

    public static int LastJournalItem
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.lastJournalItem)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.lastJournalItem), value);
    }

    public static bool KilledDummy
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedDummy)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedDummy), value);
    }

    public static int KillsDummy
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsDummy)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsDummy), value);
    }

    public static bool NewDataDummy
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataDummy)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataDummy), value);
    }

    public static bool SeenJournalMsg
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.seenJournalMsg)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.seenJournalMsg), value);
    }

    public static bool SeenHunterMsg
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.seenHunterMsg)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.seenHunterMsg), value);
    }

    public static bool FillJournal
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.fillJournal)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.fillJournal), value);
    }

    public static int JournalEntriesCompleted
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.journalEntriesCompleted)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.journalEntriesCompleted), value);
    }

    public static int JournalNotesCompleted
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.journalNotesCompleted)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.journalNotesCompleted), value);
    }

    public static int JournalEntriesTotal
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.journalEntriesTotal)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.journalEntriesTotal), value);
    }

    public static bool KilledCrawler
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedCrawler)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedCrawler), value);
    }

    public static int KillsCrawler
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsCrawler)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsCrawler), value);
    }

    public static bool NewDataCrawler
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataCrawler)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataCrawler), value);
    }

    public static bool KilledBuzzer
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedBuzzer)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedBuzzer), value);
    }

    public static int KillsBuzzer
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsBuzzer)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsBuzzer), value);
    }

    public static bool NewDataBuzzer
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataBuzzer)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataBuzzer), value);
    }

    public static bool KilledBouncer
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedBouncer)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedBouncer), value);
    }

    public static int KillsBouncer
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsBouncer)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsBouncer), value);
    }

    public static bool NewDataBouncer
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataBouncer)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataBouncer), value);
    }

    public static bool KilledClimber
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedClimber)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedClimber), value);
    }

    public static int KillsClimber
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsClimber)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsClimber), value);
    }

    public static bool NewDataClimber
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataClimber)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataClimber), value);
    }

    public static bool KilledHopper
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedHopper)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedHopper), value);
    }

    public static int KillsHopper
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsHopper)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsHopper), value);
    }

    public static bool NewDataHopper
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataHopper)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataHopper), value);
    }

    public static bool KilledWorm
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedWorm)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedWorm), value);
    }

    public static int KillsWorm
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsWorm)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsWorm), value);
    }

    public static bool NewDataWorm
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataWorm)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataWorm), value);
    }

    public static bool KilledSpitter
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedSpitter)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedSpitter), value);
    }

    public static int KillsSpitter
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsSpitter)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsSpitter), value);
    }

    public static bool NewDataSpitter
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataSpitter)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataSpitter), value);
    }

    public static bool KilledHatcher
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedHatcher)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedHatcher), value);
    }

    public static int KillsHatcher
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsHatcher)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsHatcher), value);
    }

    public static bool NewDataHatcher
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataHatcher)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataHatcher), value);
    }

    public static bool KilledHatchling
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedHatchling)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedHatchling), value);
    }

    public static int KillsHatchling
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsHatchling)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsHatchling), value);
    }

    public static bool NewDataHatchling
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataHatchling)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataHatchling), value);
    }

    public static bool KilledZombieRunner
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedZombieRunner)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedZombieRunner), value);
    }

    public static int KillsZombieRunner
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsZombieRunner)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsZombieRunner), value);
    }

    public static bool NewDataZombieRunner
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataZombieRunner)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataZombieRunner), value);
    }

    public static bool KilledZombieHornhead
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedZombieHornhead)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedZombieHornhead), value);
    }

    public static int KillsZombieHornhead
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsZombieHornhead)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsZombieHornhead), value);
    }

    public static bool NewDataZombieHornhead
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataZombieHornhead)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataZombieHornhead), value);
    }

    public static bool KilledZombieLeaper
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedZombieLeaper)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedZombieLeaper), value);
    }

    public static int KillsZombieLeaper
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsZombieLeaper)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsZombieLeaper), value);
    }

    public static bool NewDataZombieLeaper
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataZombieLeaper)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataZombieLeaper), value);
    }

    public static bool KilledZombieBarger
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedZombieBarger)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedZombieBarger), value);
    }

    public static int KillsZombieBarger
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsZombieBarger)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsZombieBarger), value);
    }

    public static bool NewDataZombieBarger
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataZombieBarger)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataZombieBarger), value);
    }

    public static bool KilledZombieShield
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedZombieShield)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedZombieShield), value);
    }

    public static int KillsZombieShield
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsZombieShield)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsZombieShield), value);
    }

    public static bool NewDataZombieShield
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataZombieShield)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataZombieShield), value);
    }

    public static bool KilledZombieGuard
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedZombieGuard)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedZombieGuard), value);
    }

    public static int KillsZombieGuard
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsZombieGuard)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsZombieGuard), value);
    }

    public static bool NewDataZombieGuard
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataZombieGuard)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataZombieGuard), value);
    }

    public static bool KilledBigBuzzer
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedBigBuzzer)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedBigBuzzer), value);
    }

    public static int KillsBigBuzzer
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsBigBuzzer)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsBigBuzzer), value);
    }

    public static bool NewDataBigBuzzer
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataBigBuzzer)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataBigBuzzer), value);
    }

    public static bool KilledBigFly
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedBigFly)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedBigFly), value);
    }

    public static int KillsBigFly
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsBigFly)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsBigFly), value);
    }

    public static bool NewDataBigFly
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataBigFly)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataBigFly), value);
    }

    public static bool KilledMawlek
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedMawlek)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedMawlek), value);
    }

    public static int KillsMawlek
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsMawlek)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsMawlek), value);
    }

    public static bool NewDataMawlek
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataMawlek)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataMawlek), value);
    }

    public static bool KilledFalseKnight
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedFalseKnight)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedFalseKnight), value);
    }

    public static int KillsFalseKnight
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsFalseKnight)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsFalseKnight), value);
    }

    public static bool NewDataFalseKnight
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataFalseKnight)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataFalseKnight), value);
    }

    public static bool KilledRoller
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedRoller)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedRoller), value);
    }

    public static int KillsRoller
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsRoller)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsRoller), value);
    }

    public static bool NewDataRoller
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataRoller)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataRoller), value);
    }

    public static bool KilledBlocker
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedBlocker)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedBlocker), value);
    }

    public static int KillsBlocker
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsBlocker)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsBlocker), value);
    }

    public static bool NewDataBlocker
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataBlocker)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataBlocker), value);
    }

    public static bool KilledPrayerSlug
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedPrayerSlug)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedPrayerSlug), value);
    }

    public static int KillsPrayerSlug
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsPrayerSlug)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsPrayerSlug), value);
    }

    public static bool NewDataPrayerSlug
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataPrayerSlug)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataPrayerSlug), value);
    }

    public static bool KilledMenderBug
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedMenderBug)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedMenderBug), value);
    }

    public static int KillsMenderBug
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsMenderBug)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsMenderBug), value);
    }

    public static bool NewDataMenderBug
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataMenderBug)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataMenderBug), value);
    }

    public static bool KilledMossmanRunner
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedMossmanRunner)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedMossmanRunner), value);
    }

    public static int KillsMossmanRunner
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsMossmanRunner)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsMossmanRunner), value);
    }

    public static bool NewDataMossmanRunner
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataMossmanRunner)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataMossmanRunner), value);
    }

    public static bool KilledMossmanShaker
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedMossmanShaker)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedMossmanShaker), value);
    }

    public static int KillsMossmanShaker
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsMossmanShaker)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsMossmanShaker), value);
    }

    public static bool NewDataMossmanShaker
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataMossmanShaker)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataMossmanShaker), value);
    }

    public static bool KilledMosquito
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedMosquito)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedMosquito), value);
    }

    public static int KillsMosquito
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsMosquito)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsMosquito), value);
    }

    public static bool NewDataMosquito
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataMosquito)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataMosquito), value);
    }

    public static bool KilledBlobFlyer
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedBlobFlyer)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedBlobFlyer), value);
    }

    public static int KillsBlobFlyer
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsBlobFlyer)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsBlobFlyer), value);
    }

    public static bool NewDataBlobFlyer
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataBlobFlyer)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataBlobFlyer), value);
    }

    public static bool KilledFungifiedZombie
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedFungifiedZombie)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedFungifiedZombie), value);
    }

    public static int KillsFungifiedZombie
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsFungifiedZombie)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsFungifiedZombie), value);
    }

    public static bool NewDataFungifiedZombie
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataFungifiedZombie)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataFungifiedZombie), value);
    }

    public static bool KilledPlantShooter
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedPlantShooter)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedPlantShooter), value);
    }

    public static int KillsPlantShooter
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsPlantShooter)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsPlantShooter), value);
    }

    public static bool NewDataPlantShooter
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataPlantShooter)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataPlantShooter), value);
    }

    public static bool KilledMossCharger
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedMossCharger)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedMossCharger), value);
    }

    public static int KillsMossCharger
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsMossCharger)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsMossCharger), value);
    }

    public static bool NewDataMossCharger
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataMossCharger)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataMossCharger), value);
    }

    public static bool KilledMegaMossCharger
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedMegaMossCharger)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedMegaMossCharger), value);
    }

    public static int KillsMegaMossCharger
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsMegaMossCharger)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsMegaMossCharger), value);
    }

    public static bool NewDataMegaMossCharger
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataMegaMossCharger)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataMegaMossCharger), value);
    }

    public static bool KilledSnapperTrap
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedSnapperTrap)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedSnapperTrap), value);
    }

    public static int KillsSnapperTrap
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsSnapperTrap)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsSnapperTrap), value);
    }

    public static bool NewDataSnapperTrap
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataSnapperTrap)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataSnapperTrap), value);
    }

    public static bool KilledMossKnight
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedMossKnight)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedMossKnight), value);
    }

    public static int KillsMossKnight
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsMossKnight)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsMossKnight), value);
    }

    public static bool NewDataMossKnight
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataMossKnight)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataMossKnight), value);
    }

    public static bool KilledGrassHopper
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedGrassHopper)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedGrassHopper), value);
    }

    public static int KillsGrassHopper
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsGrassHopper)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsGrassHopper), value);
    }

    public static bool NewDataGrassHopper
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataGrassHopper)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataGrassHopper), value);
    }

    public static bool KilledAcidFlyer
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedAcidFlyer)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedAcidFlyer), value);
    }

    public static int KillsAcidFlyer
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsAcidFlyer)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsAcidFlyer), value);
    }

    public static bool NewDataAcidFlyer
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataAcidFlyer)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataAcidFlyer), value);
    }

    public static bool KilledAcidWalker
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedAcidWalker)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedAcidWalker), value);
    }

    public static int KillsAcidWalker
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsAcidWalker)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsAcidWalker), value);
    }

    public static bool NewDataAcidWalker
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataAcidWalker)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataAcidWalker), value);
    }

    public static bool KilledMossFlyer
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedMossFlyer)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedMossFlyer), value);
    }

    public static int KillsMossFlyer
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsMossFlyer)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsMossFlyer), value);
    }

    public static bool NewDataMossFlyer
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataMossFlyer)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataMossFlyer), value);
    }

    public static bool KilledMossKnightFat
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedMossKnightFat)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedMossKnightFat), value);
    }

    public static int KillsMossKnightFat
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsMossKnightFat)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsMossKnightFat), value);
    }

    public static bool NewDataMossKnightFat
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataMossKnightFat)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataMossKnightFat), value);
    }

    public static bool KilledMossWalker
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedMossWalker)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedMossWalker), value);
    }

    public static int KillsMossWalker
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsMossWalker)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsMossWalker), value);
    }

    public static bool NewDataMossWalker
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataMossWalker)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataMossWalker), value);
    }

    public static bool KilledInfectedKnight
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedInfectedKnight)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedInfectedKnight), value);
    }

    public static int KillsInfectedKnight
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsInfectedKnight)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsInfectedKnight), value);
    }

    public static bool NewDataInfectedKnight
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataInfectedKnight)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataInfectedKnight), value);
    }

    public static bool KilledLazyFlyer
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedLazyFlyer)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedLazyFlyer), value);
    }

    public static int KillsLazyFlyer
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsLazyFlyer)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsLazyFlyer), value);
    }

    public static bool NewDataLazyFlyer
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataLazyFlyer)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataLazyFlyer), value);
    }

    public static bool KilledZapBug
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedZapBug)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedZapBug), value);
    }

    public static int KillsZapBug
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsZapBug)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsZapBug), value);
    }

    public static bool NewDataZapBug
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataZapBug)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataZapBug), value);
    }

    public static bool KilledJellyfish
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedJellyfish)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedJellyfish), value);
    }

    public static int KillsJellyfish
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsJellyfish)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsJellyfish), value);
    }

    public static bool NewDataJellyfish
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataJellyfish)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataJellyfish), value);
    }

    public static bool KilledJellyCrawler
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedJellyCrawler)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedJellyCrawler), value);
    }

    public static int KillsJellyCrawler
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsJellyCrawler)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsJellyCrawler), value);
    }

    public static bool NewDataJellyCrawler
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataJellyCrawler)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataJellyCrawler), value);
    }

    public static bool KilledMegaJellyfish
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedMegaJellyfish)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedMegaJellyfish), value);
    }

    public static int KillsMegaJellyfish
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsMegaJellyfish)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsMegaJellyfish), value);
    }

    public static bool NewDataMegaJellyfish
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataMegaJellyfish)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataMegaJellyfish), value);
    }

    public static bool KilledFungoonBaby
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedFungoonBaby)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedFungoonBaby), value);
    }

    public static int KillsFungoonBaby
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsFungoonBaby)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsFungoonBaby), value);
    }

    public static bool NewDataFungoonBaby
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataFungoonBaby)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataFungoonBaby), value);
    }

    public static bool KilledMushroomTurret
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedMushroomTurret)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedMushroomTurret), value);
    }

    public static int KillsMushroomTurret
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsMushroomTurret)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsMushroomTurret), value);
    }

    public static bool NewDataMushroomTurret
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataMushroomTurret)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataMushroomTurret), value);
    }

    public static bool KilledMantis
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedMantis)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedMantis), value);
    }

    public static int KillsMantis
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsMantis)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsMantis), value);
    }

    public static bool NewDataMantis
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataMantis)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataMantis), value);
    }

    public static bool KilledMushroomRoller
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedMushroomRoller)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedMushroomRoller), value);
    }

    public static int KillsMushroomRoller
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsMushroomRoller)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsMushroomRoller), value);
    }

    public static bool NewDataMushroomRoller
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataMushroomRoller)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataMushroomRoller), value);
    }

    public static bool KilledMushroomBrawler
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedMushroomBrawler)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedMushroomBrawler), value);
    }

    public static int KillsMushroomBrawler
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsMushroomBrawler)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsMushroomBrawler), value);
    }

    public static bool NewDataMushroomBrawler
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataMushroomBrawler)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataMushroomBrawler), value);
    }

    public static bool KilledMushroomBaby
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedMushroomBaby)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedMushroomBaby), value);
    }

    public static int KillsMushroomBaby
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsMushroomBaby)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsMushroomBaby), value);
    }

    public static bool NewDataMushroomBaby
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataMushroomBaby)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataMushroomBaby), value);
    }

    public static bool KilledMantisFlyerChild
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedMantisFlyerChild)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedMantisFlyerChild), value);
    }

    public static int KillsMantisFlyerChild
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsMantisFlyerChild)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsMantisFlyerChild), value);
    }

    public static bool NewDataMantisFlyerChild
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataMantisFlyerChild)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataMantisFlyerChild), value);
    }

    public static bool KilledFungusFlyer
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedFungusFlyer)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedFungusFlyer), value);
    }

    public static int KillsFungusFlyer
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsFungusFlyer)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsFungusFlyer), value);
    }

    public static bool NewDataFungusFlyer
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataFungusFlyer)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataFungusFlyer), value);
    }

    public static bool KilledFungCrawler
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedFungCrawler)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedFungCrawler), value);
    }

    public static int KillsFungCrawler
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsFungCrawler)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsFungCrawler), value);
    }

    public static bool NewDataFungCrawler
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataFungCrawler)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataFungCrawler), value);
    }

    public static bool KilledMantisLord
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedMantisLord)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedMantisLord), value);
    }

    public static int KillsMantisLord
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsMantisLord)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsMantisLord), value);
    }

    public static bool NewDataMantisLord
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataMantisLord)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataMantisLord), value);
    }

    public static bool KilledBlackKnight
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedBlackKnight)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedBlackKnight), value);
    }

    public static int KillsBlackKnight
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsBlackKnight)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsBlackKnight), value);
    }

    public static bool NewDataBlackKnight
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataBlackKnight)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataBlackKnight), value);
    }

    public static bool KilledElectricMage
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedElectricMage)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedElectricMage), value);
    }

    public static int KillsElectricMage
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsElectricMage)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsElectricMage), value);
    }

    public static bool NewDataElectricMage
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataElectricMage)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataElectricMage), value);
    }

    public static bool KilledMage
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedMage)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedMage), value);
    }

    public static int KillsMage
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsMage)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsMage), value);
    }

    public static bool NewDataMage
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataMage)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataMage), value);
    }

    public static bool KilledMageKnight
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedMageKnight)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedMageKnight), value);
    }

    public static int KillsMageKnight
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsMageKnight)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsMageKnight), value);
    }

    public static bool NewDataMageKnight
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataMageKnight)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataMageKnight), value);
    }

    public static bool KilledRoyalDandy
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedRoyalDandy)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedRoyalDandy), value);
    }

    public static int KillsRoyalDandy
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsRoyalDandy)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsRoyalDandy), value);
    }

    public static bool NewDataRoyalDandy
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataRoyalDandy)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataRoyalDandy), value);
    }

    public static bool KilledRoyalCoward
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedRoyalCoward)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedRoyalCoward), value);
    }

    public static int KillsRoyalCoward
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsRoyalCoward)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsRoyalCoward), value);
    }

    public static bool NewDataRoyalCoward
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataRoyalCoward)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataRoyalCoward), value);
    }

    public static bool KilledRoyalPlumper
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedRoyalPlumper)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedRoyalPlumper), value);
    }

    public static int KillsRoyalPlumper
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsRoyalPlumper)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsRoyalPlumper), value);
    }

    public static bool NewDataRoyalPlumper
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataRoyalPlumper)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataRoyalPlumper), value);
    }

    public static bool KilledFlyingSentrySword
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedFlyingSentrySword)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedFlyingSentrySword), value);
    }

    public static int KillsFlyingSentrySword
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsFlyingSentrySword)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsFlyingSentrySword), value);
    }

    public static bool NewDataFlyingSentrySword
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataFlyingSentrySword)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataFlyingSentrySword), value);
    }

    public static bool KilledFlyingSentryJavelin
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedFlyingSentryJavelin)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedFlyingSentryJavelin), value);
    }

    public static int KillsFlyingSentryJavelin
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsFlyingSentryJavelin)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsFlyingSentryJavelin), value);
    }

    public static bool NewDataFlyingSentryJavelin
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataFlyingSentryJavelin)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataFlyingSentryJavelin), value);
    }

    public static bool KilledSentry
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedSentry)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedSentry), value);
    }

    public static int KillsSentry
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsSentry)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsSentry), value);
    }

    public static bool NewDataSentry
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataSentry)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataSentry), value);
    }

    public static bool KilledSentryFat
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedSentryFat)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedSentryFat), value);
    }

    public static int KillsSentryFat
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsSentryFat)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsSentryFat), value);
    }

    public static bool NewDataSentryFat
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataSentryFat)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataSentryFat), value);
    }

    public static bool KilledMageBlob
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedMageBlob)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedMageBlob), value);
    }

    public static int KillsMageBlob
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsMageBlob)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsMageBlob), value);
    }

    public static bool NewDataMageBlob
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataMageBlob)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataMageBlob), value);
    }

    public static bool KilledGreatShieldZombie
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedGreatShieldZombie)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedGreatShieldZombie), value);
    }

    public static int KillsGreatShieldZombie
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsGreatShieldZombie)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsGreatShieldZombie), value);
    }

    public static bool NewDataGreatShieldZombie
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataGreatShieldZombie)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataGreatShieldZombie), value);
    }

    public static bool KilledJarCollector
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedJarCollector)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedJarCollector), value);
    }

    public static int KillsJarCollector
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsJarCollector)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsJarCollector), value);
    }

    public static bool NewDataJarCollector
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataJarCollector)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataJarCollector), value);
    }

    public static bool KilledMageBalloon
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedMageBalloon)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedMageBalloon), value);
    }

    public static int KillsMageBalloon
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsMageBalloon)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsMageBalloon), value);
    }

    public static bool NewDataMageBalloon
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataMageBalloon)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataMageBalloon), value);
    }

    public static bool KilledMageLord
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedMageLord)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedMageLord), value);
    }

    public static int KillsMageLord
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsMageLord)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsMageLord), value);
    }

    public static bool NewDataMageLord
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataMageLord)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataMageLord), value);
    }

    public static bool KilledGorgeousHusk
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedGorgeousHusk)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedGorgeousHusk), value);
    }

    public static int KillsGorgeousHusk
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsGorgeousHusk)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsGorgeousHusk), value);
    }

    public static bool NewDataGorgeousHusk
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataGorgeousHusk)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataGorgeousHusk), value);
    }

    public static bool KilledFlipHopper
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedFlipHopper)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedFlipHopper), value);
    }

    public static int KillsFlipHopper
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsFlipHopper)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsFlipHopper), value);
    }

    public static bool NewDataFlipHopper
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataFlipHopper)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataFlipHopper), value);
    }

    public static bool KilledFlukeman
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedFlukeman)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedFlukeman), value);
    }

    public static int KillsFlukeman
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsFlukeman)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsFlukeman), value);
    }

    public static bool NewDataFlukeman
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataFlukeman)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataFlukeman), value);
    }

    public static bool KilledInflater
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedInflater)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedInflater), value);
    }

    public static int KillsInflater
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsInflater)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsInflater), value);
    }

    public static bool NewDataInflater
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataInflater)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataInflater), value);
    }

    public static bool KilledFlukefly
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedFlukefly)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedFlukefly), value);
    }

    public static int KillsFlukefly
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsFlukefly)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsFlukefly), value);
    }

    public static bool NewDataFlukefly
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataFlukefly)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataFlukefly), value);
    }

    public static bool KilledFlukeMother
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedFlukeMother)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedFlukeMother), value);
    }

    public static int KillsFlukeMother
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsFlukeMother)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsFlukeMother), value);
    }

    public static bool NewDataFlukeMother
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataFlukeMother)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataFlukeMother), value);
    }

    public static bool KilledDungDefender
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedDungDefender)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedDungDefender), value);
    }

    public static int KillsDungDefender
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsDungDefender)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsDungDefender), value);
    }

    public static bool NewDataDungDefender
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataDungDefender)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataDungDefender), value);
    }

    public static bool KilledCrystalCrawler
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedCrystalCrawler)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedCrystalCrawler), value);
    }

    public static int KillsCrystalCrawler
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsCrystalCrawler)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsCrystalCrawler), value);
    }

    public static bool NewDataCrystalCrawler
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataCrystalCrawler)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataCrystalCrawler), value);
    }

    public static bool KilledCrystalFlyer
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedCrystalFlyer)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedCrystalFlyer), value);
    }

    public static int KillsCrystalFlyer
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsCrystalFlyer)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsCrystalFlyer), value);
    }

    public static bool NewDataCrystalFlyer
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataCrystalFlyer)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataCrystalFlyer), value);
    }

    public static bool KilledLaserBug
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedLaserBug)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedLaserBug), value);
    }

    public static int KillsLaserBug
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsLaserBug)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsLaserBug), value);
    }

    public static bool NewDataLaserBug
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataLaserBug)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataLaserBug), value);
    }

    public static bool KilledBeamMiner
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedBeamMiner)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedBeamMiner), value);
    }

    public static int KillsBeamMiner
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsBeamMiner)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsBeamMiner), value);
    }

    public static bool NewDataBeamMiner
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataBeamMiner)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataBeamMiner), value);
    }

    public static bool KilledZombieMiner
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedZombieMiner)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedZombieMiner), value);
    }

    public static int KillsZombieMiner
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsZombieMiner)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsZombieMiner), value);
    }

    public static bool NewDataZombieMiner
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataZombieMiner)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataZombieMiner), value);
    }

    public static bool KilledMegaBeamMiner
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedMegaBeamMiner)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedMegaBeamMiner), value);
    }

    public static int KillsMegaBeamMiner
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsMegaBeamMiner)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsMegaBeamMiner), value);
    }

    public static bool NewDataMegaBeamMiner
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataMegaBeamMiner)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataMegaBeamMiner), value);
    }

    public static bool KilledMinesCrawler
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedMinesCrawler)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedMinesCrawler), value);
    }

    public static int KillsMinesCrawler
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsMinesCrawler)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsMinesCrawler), value);
    }

    public static bool NewDataMinesCrawler
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataMinesCrawler)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataMinesCrawler), value);
    }

    public static bool KilledAngryBuzzer
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedAngryBuzzer)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedAngryBuzzer), value);
    }

    public static int KillsAngryBuzzer
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsAngryBuzzer)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsAngryBuzzer), value);
    }

    public static bool NewDataAngryBuzzer
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataAngryBuzzer)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataAngryBuzzer), value);
    }

    public static bool KilledBurstingBouncer
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedBurstingBouncer)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedBurstingBouncer), value);
    }

    public static int KillsBurstingBouncer
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsBurstingBouncer)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsBurstingBouncer), value);
    }

    public static bool NewDataBurstingBouncer
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataBurstingBouncer)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataBurstingBouncer), value);
    }

    public static bool KilledBurstingZombie
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedBurstingZombie)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedBurstingZombie), value);
    }

    public static int KillsBurstingZombie
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsBurstingZombie)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsBurstingZombie), value);
    }

    public static bool NewDataBurstingZombie
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataBurstingZombie)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataBurstingZombie), value);
    }

    public static bool KilledSpittingZombie
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedSpittingZombie)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedSpittingZombie), value);
    }

    public static int KillsSpittingZombie
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsSpittingZombie)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsSpittingZombie), value);
    }

    public static bool NewDataSpittingZombie
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataSpittingZombie)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataSpittingZombie), value);
    }

    public static bool KilledBabyCentipede
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedBabyCentipede)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedBabyCentipede), value);
    }

    public static int KillsBabyCentipede
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsBabyCentipede)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsBabyCentipede), value);
    }

    public static bool NewDataBabyCentipede
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataBabyCentipede)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataBabyCentipede), value);
    }

    public static bool KilledBigCentipede
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedBigCentipede)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedBigCentipede), value);
    }

    public static int KillsBigCentipede
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsBigCentipede)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsBigCentipede), value);
    }

    public static bool NewDataBigCentipede
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataBigCentipede)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataBigCentipede), value);
    }

    public static bool KilledCentipedeHatcher
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedCentipedeHatcher)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedCentipedeHatcher), value);
    }

    public static int KillsCentipedeHatcher
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsCentipedeHatcher)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsCentipedeHatcher), value);
    }

    public static bool NewDataCentipedeHatcher
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataCentipedeHatcher)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataCentipedeHatcher), value);
    }

    public static bool KilledLesserMawlek
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedLesserMawlek)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedLesserMawlek), value);
    }

    public static int KillsLesserMawlek
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsLesserMawlek)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsLesserMawlek), value);
    }

    public static bool NewDataLesserMawlek
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataLesserMawlek)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataLesserMawlek), value);
    }

    public static bool KilledSlashSpider
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedSlashSpider)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedSlashSpider), value);
    }

    public static int KillsSlashSpider
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsSlashSpider)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsSlashSpider), value);
    }

    public static bool NewDataSlashSpider
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataSlashSpider)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataSlashSpider), value);
    }

    public static bool KilledSpiderCorpse
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedSpiderCorpse)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedSpiderCorpse), value);
    }

    public static int KillsSpiderCorpse
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsSpiderCorpse)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsSpiderCorpse), value);
    }

    public static bool NewDataSpiderCorpse
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataSpiderCorpse)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataSpiderCorpse), value);
    }

    public static bool KilledShootSpider
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedShootSpider)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedShootSpider), value);
    }

    public static int KillsShootSpider
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsShootSpider)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsShootSpider), value);
    }

    public static bool NewDataShootSpider
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataShootSpider)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataShootSpider), value);
    }

    public static bool KilledMiniSpider
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedMiniSpider)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedMiniSpider), value);
    }

    public static int KillsMiniSpider
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsMiniSpider)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsMiniSpider), value);
    }

    public static bool NewDataMiniSpider
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataMiniSpider)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataMiniSpider), value);
    }

    public static bool KilledSpiderFlyer
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedSpiderFlyer)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedSpiderFlyer), value);
    }

    public static int KillsSpiderFlyer
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsSpiderFlyer)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsSpiderFlyer), value);
    }

    public static bool NewDataSpiderFlyer
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataSpiderFlyer)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataSpiderFlyer), value);
    }

    public static bool KilledMimicSpider
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedMimicSpider)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedMimicSpider), value);
    }

    public static int KillsMimicSpider
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsMimicSpider)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsMimicSpider), value);
    }

    public static bool NewDataMimicSpider
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataMimicSpider)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataMimicSpider), value);
    }

    public static bool KilledBeeHatchling
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedBeeHatchling)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedBeeHatchling), value);
    }

    public static int KillsBeeHatchling
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsBeeHatchling)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsBeeHatchling), value);
    }

    public static bool NewDataBeeHatchling
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataBeeHatchling)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataBeeHatchling), value);
    }

    public static bool KilledBeeStinger
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedBeeStinger)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedBeeStinger), value);
    }

    public static int KillsBeeStinger
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsBeeStinger)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsBeeStinger), value);
    }

    public static bool NewDataBeeStinger
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataBeeStinger)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataBeeStinger), value);
    }

    public static bool KilledBigBee
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedBigBee)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedBigBee), value);
    }

    public static int KillsBigBee
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsBigBee)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsBigBee), value);
    }

    public static bool NewDataBigBee
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataBigBee)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataBigBee), value);
    }

    public static bool KilledHiveKnight
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedHiveKnight)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedHiveKnight), value);
    }

    public static int KillsHiveKnight
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsHiveKnight)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsHiveKnight), value);
    }

    public static bool NewDataHiveKnight
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataHiveKnight)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataHiveKnight), value);
    }

    public static bool KilledBlowFly
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedBlowFly)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedBlowFly), value);
    }

    public static int KillsBlowFly
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsBlowFly)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsBlowFly), value);
    }

    public static bool NewDataBlowFly
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataBlowFly)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataBlowFly), value);
    }

    public static bool KilledCeilingDropper
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedCeilingDropper)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedCeilingDropper), value);
    }

    public static int KillsCeilingDropper
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsCeilingDropper)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsCeilingDropper), value);
    }

    public static bool NewDataCeilingDropper
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataCeilingDropper)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataCeilingDropper), value);
    }

    public static bool KilledGiantHopper
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedGiantHopper)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedGiantHopper), value);
    }

    public static int KillsGiantHopper
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsGiantHopper)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsGiantHopper), value);
    }

    public static bool NewDataGiantHopper
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataGiantHopper)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataGiantHopper), value);
    }

    public static bool KilledGrubMimic
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedGrubMimic)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedGrubMimic), value);
    }

    public static int KillsGrubMimic
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsGrubMimic)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsGrubMimic), value);
    }

    public static bool NewDataGrubMimic
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataGrubMimic)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataGrubMimic), value);
    }

    public static bool KilledMawlekTurret
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedMawlekTurret)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedMawlekTurret), value);
    }

    public static int KillsMawlekTurret
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsMawlekTurret)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsMawlekTurret), value);
    }

    public static bool NewDataMawlekTurret
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataMawlekTurret)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataMawlekTurret), value);
    }

    public static bool KilledOrangeScuttler
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedOrangeScuttler)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedOrangeScuttler), value);
    }

    public static int KillsOrangeScuttler
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsOrangeScuttler)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsOrangeScuttler), value);
    }

    public static bool NewDataOrangeScuttler
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataOrangeScuttler)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataOrangeScuttler), value);
    }

    public static bool KilledHealthScuttler
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedHealthScuttler)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedHealthScuttler), value);
    }

    public static int KillsHealthScuttler
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsHealthScuttler)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsHealthScuttler), value);
    }

    public static bool NewDataHealthScuttler
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataHealthScuttler)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataHealthScuttler), value);
    }

    public static bool KilledPigeon
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedPigeon)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedPigeon), value);
    }

    public static int KillsPigeon
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsPigeon)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsPigeon), value);
    }

    public static bool NewDataPigeon
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataPigeon)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataPigeon), value);
    }

    public static bool KilledZombieHive
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedZombieHive)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedZombieHive), value);
    }

    public static int KillsZombieHive
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsZombieHive)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsZombieHive), value);
    }

    public static bool NewDataZombieHive
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataZombieHive)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataZombieHive), value);
    }

    public static bool KilledDreamGuard
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedDreamGuard)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedDreamGuard), value);
    }

    public static int KillsDreamGuard
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsDreamGuard)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsDreamGuard), value);
    }

    public static bool NewDataDreamGuard
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataDreamGuard)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataDreamGuard), value);
    }

    public static bool KilledHornet
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedHornet)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedHornet), value);
    }

    public static int KillsHornet
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsHornet)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsHornet), value);
    }

    public static bool NewDataHornet
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataHornet)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataHornet), value);
    }

    public static bool KilledAbyssCrawler
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedAbyssCrawler)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedAbyssCrawler), value);
    }

    public static int KillsAbyssCrawler
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsAbyssCrawler)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsAbyssCrawler), value);
    }

    public static bool NewDataAbyssCrawler
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataAbyssCrawler)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataAbyssCrawler), value);
    }

    public static bool KilledSuperSpitter
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedSuperSpitter)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedSuperSpitter), value);
    }

    public static int KillsSuperSpitter
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsSuperSpitter)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsSuperSpitter), value);
    }

    public static bool NewDataSuperSpitter
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataSuperSpitter)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataSuperSpitter), value);
    }

    public static bool KilledSibling
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedSibling)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedSibling), value);
    }

    public static int KillsSibling
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsSibling)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsSibling), value);
    }

    public static bool NewDataSibling
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataSibling)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataSibling), value);
    }

    public static bool KilledPalaceFly
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedPalaceFly)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedPalaceFly), value);
    }

    public static int KillsPalaceFly
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsPalaceFly)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsPalaceFly), value);
    }

    public static bool NewDataPalaceFly
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataPalaceFly)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataPalaceFly), value);
    }

    public static bool KilledEggSac
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedEggSac)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedEggSac), value);
    }

    public static int KillsEggSac
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsEggSac)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsEggSac), value);
    }

    public static bool NewDataEggSac
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataEggSac)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataEggSac), value);
    }

    public static bool KilledMummy
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedMummy)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedMummy), value);
    }

    public static int KillsMummy
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsMummy)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsMummy), value);
    }

    public static bool NewDataMummy
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataMummy)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataMummy), value);
    }

    public static bool KilledOrangeBalloon
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedOrangeBalloon)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedOrangeBalloon), value);
    }

    public static int KillsOrangeBalloon
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsOrangeBalloon)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsOrangeBalloon), value);
    }

    public static bool NewDataOrangeBalloon
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataOrangeBalloon)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataOrangeBalloon), value);
    }

    public static bool KilledAbyssTendril
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedAbyssTendril)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedAbyssTendril), value);
    }

    public static int KillsAbyssTendril
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsAbyssTendril)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsAbyssTendril), value);
    }

    public static bool NewDataAbyssTendril
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataAbyssTendril)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataAbyssTendril), value);
    }

    public static bool KilledHeavyMantis
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedHeavyMantis)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedHeavyMantis), value);
    }

    public static int KillsHeavyMantis
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsHeavyMantis)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsHeavyMantis), value);
    }

    public static bool NewDataHeavyMantis
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataHeavyMantis)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataHeavyMantis), value);
    }

    public static bool KilledTraitorLord
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedTraitorLord)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedTraitorLord), value);
    }

    public static int KillsTraitorLord
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsTraitorLord)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsTraitorLord), value);
    }

    public static bool NewDataTraitorLord
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataTraitorLord)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataTraitorLord), value);
    }

    public static bool KilledMantisHeavyFlyer
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedMantisHeavyFlyer)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedMantisHeavyFlyer), value);
    }

    public static int KillsMantisHeavyFlyer
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsMantisHeavyFlyer)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsMantisHeavyFlyer), value);
    }

    public static bool NewDataMantisHeavyFlyer
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataMantisHeavyFlyer)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataMantisHeavyFlyer), value);
    }

    public static bool KilledGardenZombie
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedGardenZombie)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedGardenZombie), value);
    }

    public static int KillsGardenZombie
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsGardenZombie)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsGardenZombie), value);
    }

    public static bool NewDataGardenZombie
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataGardenZombie)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataGardenZombie), value);
    }

    public static bool KilledRoyalGuard
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedRoyalGuard)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedRoyalGuard), value);
    }

    public static int KillsRoyalGuard
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsRoyalGuard)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsRoyalGuard), value);
    }

    public static bool NewDataRoyalGuard
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataRoyalGuard)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataRoyalGuard), value);
    }

    public static bool KilledWhiteRoyal
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedWhiteRoyal)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedWhiteRoyal), value);
    }

    public static int KillsWhiteRoyal
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsWhiteRoyal)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsWhiteRoyal), value);
    }

    public static bool NewDataWhiteRoyal
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataWhiteRoyal)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataWhiteRoyal), value);
    }

    public static bool OpenedPalaceGrounds
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.openedPalaceGrounds)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.openedPalaceGrounds), value);
    }

    public static bool KilledOblobble
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedOblobble)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedOblobble), value);
    }

    public static int KillsOblobble
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsOblobble)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsOblobble), value);
    }

    public static bool NewDataOblobble
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataOblobble)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataOblobble), value);
    }

    public static bool KilledZote
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedZote)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedZote), value);
    }

    public static int KillsZote
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsZote)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsZote), value);
    }

    public static bool NewDataZote
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataZote)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataZote), value);
    }

    public static bool KilledBlobble
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedBlobble)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedBlobble), value);
    }

    public static int KillsBlobble
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsBlobble)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsBlobble), value);
    }

    public static bool NewDataBlobble
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataBlobble)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataBlobble), value);
    }

    public static bool KilledColMosquito
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedColMosquito)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedColMosquito), value);
    }

    public static int KillsColMosquito
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsColMosquito)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsColMosquito), value);
    }

    public static bool NewDataColMosquito
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataColMosquito)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataColMosquito), value);
    }

    public static bool KilledColRoller
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedColRoller)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedColRoller), value);
    }

    public static int KillsColRoller
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsColRoller)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsColRoller), value);
    }

    public static bool NewDataColRoller
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataColRoller)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataColRoller), value);
    }

    public static bool KilledColFlyingSentry
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedColFlyingSentry)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedColFlyingSentry), value);
    }

    public static int KillsColFlyingSentry
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsColFlyingSentry)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsColFlyingSentry), value);
    }

    public static bool NewDataColFlyingSentry
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataColFlyingSentry)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataColFlyingSentry), value);
    }

    public static bool KilledColMiner
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedColMiner)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedColMiner), value);
    }

    public static int KillsColMiner
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsColMiner)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsColMiner), value);
    }

    public static bool NewDataColMiner
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataColMiner)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataColMiner), value);
    }

    public static bool KilledColShield
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedColShield)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedColShield), value);
    }

    public static int KillsColShield
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsColShield)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsColShield), value);
    }

    public static bool NewDataColShield
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataColShield)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataColShield), value);
    }

    public static bool KilledColWorm
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedColWorm)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedColWorm), value);
    }

    public static int KillsColWorm
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsColWorm)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsColWorm), value);
    }

    public static bool NewDataColWorm
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataColWorm)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataColWorm), value);
    }

    public static bool KilledColHopper
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedColHopper)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedColHopper), value);
    }

    public static int KillsColHopper
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsColHopper)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsColHopper), value);
    }

    public static bool NewDataColHopper
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataColHopper)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataColHopper), value);
    }

    public static bool KilledLobsterLancer
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedLobsterLancer)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedLobsterLancer), value);
    }

    public static int KillsLobsterLancer
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsLobsterLancer)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsLobsterLancer), value);
    }

    public static bool NewDataLobsterLancer
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataLobsterLancer)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataLobsterLancer), value);
    }

    public static bool KilledGhostAladar
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedGhostAladar)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedGhostAladar), value);
    }

    public static int KillsGhostAladar
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsGhostAladar)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsGhostAladar), value);
    }

    public static bool NewDataGhostAladar
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataGhostAladar)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataGhostAladar), value);
    }

    public static bool KilledGhostXero
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedGhostXero)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedGhostXero), value);
    }

    public static int KillsGhostXero
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsGhostXero)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsGhostXero), value);
    }

    public static bool NewDataGhostXero
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataGhostXero)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataGhostXero), value);
    }

    public static bool KilledGhostHu
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedGhostHu)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedGhostHu), value);
    }

    public static int KillsGhostHu
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsGhostHu)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsGhostHu), value);
    }

    public static bool NewDataGhostHu
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataGhostHu)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataGhostHu), value);
    }

    public static bool KilledGhostMarmu
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedGhostMarmu)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedGhostMarmu), value);
    }

    public static int KillsGhostMarmu
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsGhostMarmu)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsGhostMarmu), value);
    }

    public static bool NewDataGhostMarmu
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataGhostMarmu)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataGhostMarmu), value);
    }

    public static bool KilledGhostNoEyes
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedGhostNoEyes)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedGhostNoEyes), value);
    }

    public static int KillsGhostNoEyes
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsGhostNoEyes)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsGhostNoEyes), value);
    }

    public static bool NewDataGhostNoEyes
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataGhostNoEyes)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataGhostNoEyes), value);
    }

    public static bool KilledGhostMarkoth
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedGhostMarkoth)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedGhostMarkoth), value);
    }

    public static int KillsGhostMarkoth
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsGhostMarkoth)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsGhostMarkoth), value);
    }

    public static bool NewDataGhostMarkoth
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataGhostMarkoth)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataGhostMarkoth), value);
    }

    public static bool KilledGhostGalien
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedGhostGalien)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedGhostGalien), value);
    }

    public static int KillsGhostGalien
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsGhostGalien)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsGhostGalien), value);
    }

    public static bool NewDataGhostGalien
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataGhostGalien)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataGhostGalien), value);
    }

    public static bool KilledWhiteDefender
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedWhiteDefender)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedWhiteDefender), value);
    }

    public static int KillsWhiteDefender
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsWhiteDefender)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsWhiteDefender), value);
    }

    public static bool NewDataWhiteDefender
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataWhiteDefender)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataWhiteDefender), value);
    }

    public static bool KilledGreyPrince
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedGreyPrince)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedGreyPrince), value);
    }

    public static int KillsGreyPrince
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsGreyPrince)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsGreyPrince), value);
    }

    public static bool NewDataGreyPrince
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataGreyPrince)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataGreyPrince), value);
    }

    public static bool KilledZotelingBalloon
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedZotelingBalloon)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedZotelingBalloon), value);
    }

    public static int KillsZotelingBalloon
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsZotelingBalloon)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsZotelingBalloon), value);
    }

    public static bool NewDataZotelingBalloon
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataZotelingBalloon)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataZotelingBalloon), value);
    }

    public static bool KilledZotelingHopper
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedZotelingHopper)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedZotelingHopper), value);
    }

    public static int KillsZotelingHopper
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsZotelingHopper)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsZotelingHopper), value);
    }

    public static bool NewDataZotelingHopper
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataZotelingHopper)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataZotelingHopper), value);
    }

    public static bool KilledZotelingBuzzer
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedZotelingBuzzer)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedZotelingBuzzer), value);
    }

    public static int KillsZotelingBuzzer
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsZotelingBuzzer)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsZotelingBuzzer), value);
    }

    public static bool NewDataZotelingBuzzer
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataZotelingBuzzer)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataZotelingBuzzer), value);
    }

    public static bool KilledHollowKnight
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedHollowKnight)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedHollowKnight), value);
    }

    public static int KillsHollowKnight
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsHollowKnight)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsHollowKnight), value);
    }

    public static bool NewDataHollowKnight
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataHollowKnight)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataHollowKnight), value);
    }

    public static bool KilledFinalBoss
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedFinalBoss)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedFinalBoss), value);
    }

    public static int KillsFinalBoss
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsFinalBoss)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsFinalBoss), value);
    }

    public static bool NewDataFinalBoss
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataFinalBoss)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataFinalBoss), value);
    }

    public static bool KilledHunterMark
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedHunterMark)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedHunterMark), value);
    }

    public static int KillsHunterMark
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsHunterMark)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsHunterMark), value);
    }

    public static bool NewDataHunterMark
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataHunterMark)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataHunterMark), value);
    }

    public static bool KilledFlameBearerSmall
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedFlameBearerSmall)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedFlameBearerSmall), value);
    }

    public static int KillsFlameBearerSmall
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsFlameBearerSmall)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsFlameBearerSmall), value);
    }

    public static bool NewDataFlameBearerSmall
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataFlameBearerSmall)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataFlameBearerSmall), value);
    }

    public static bool KilledFlameBearerMed
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedFlameBearerMed)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedFlameBearerMed), value);
    }

    public static int KillsFlameBearerMed
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsFlameBearerMed)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsFlameBearerMed), value);
    }

    public static bool NewDataFlameBearerMed
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataFlameBearerMed)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataFlameBearerMed), value);
    }

    public static bool KilledFlameBearerLarge
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedFlameBearerLarge)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedFlameBearerLarge), value);
    }

    public static int KillsFlameBearerLarge
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsFlameBearerLarge)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsFlameBearerLarge), value);
    }

    public static bool NewDataFlameBearerLarge
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataFlameBearerLarge)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataFlameBearerLarge), value);
    }

    public static bool KilledGrimm
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedGrimm)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedGrimm), value);
    }

    public static int KillsGrimm
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsGrimm)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsGrimm), value);
    }

    public static bool NewDataGrimm
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataGrimm)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataGrimm), value);
    }

    public static bool KilledNightmareGrimm
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedNightmareGrimm)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedNightmareGrimm), value);
    }

    public static int KillsNightmareGrimm
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsNightmareGrimm)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsNightmareGrimm), value);
    }

    public static bool NewDataNightmareGrimm
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataNightmareGrimm)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataNightmareGrimm), value);
    }

    public static bool KilledBindingSeal
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedBindingSeal)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedBindingSeal), value);
    }

    public static int KillsBindingSeal
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsBindingSeal)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsBindingSeal), value);
    }

    public static bool NewDataBindingSeal
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataBindingSeal)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataBindingSeal), value);
    }

    public static bool KilledFatFluke
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedFatFluke)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedFatFluke), value);
    }

    public static int KillsFatFluke
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsFatFluke)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsFatFluke), value);
    }

    public static bool NewDataFatFluke
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataFatFluke)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataFatFluke), value);
    }

    public static bool KilledPaleLurker
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedPaleLurker)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedPaleLurker), value);
    }

    public static int KillsPaleLurker
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsPaleLurker)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsPaleLurker), value);
    }

    public static bool NewDataPaleLurker
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataPaleLurker)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataPaleLurker), value);
    }

    public static bool KilledNailBros
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedNailBros)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedNailBros), value);
    }

    public static int KillsNailBros
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsNailBros)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsNailBros), value);
    }

    public static bool NewDataNailBros
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataNailBros)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataNailBros), value);
    }

    public static bool KilledPaintmaster
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedPaintmaster)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedPaintmaster), value);
    }

    public static int KillsPaintmaster
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsPaintmaster)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsPaintmaster), value);
    }

    public static bool NewDataPaintmaster
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataPaintmaster)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataPaintmaster), value);
    }

    public static bool KilledNailsage
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedNailsage)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedNailsage), value);
    }

    public static int KillsNailsage
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsNailsage)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsNailsage), value);
    }

    public static bool NewDataNailsage
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataNailsage)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataNailsage), value);
    }

    public static bool KilledHollowKnightPrime
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedHollowKnightPrime)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedHollowKnightPrime), value);
    }

    public static int KillsHollowKnightPrime
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsHollowKnightPrime)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsHollowKnightPrime), value);
    }

    public static bool NewDataHollowKnightPrime
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataHollowKnightPrime)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataHollowKnightPrime), value);
    }

    public static bool KilledGodseekerMask
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedGodseekerMask)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedGodseekerMask), value);
    }

    public static int KillsGodseekerMask
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsGodseekerMask)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsGodseekerMask), value);
    }

    public static bool NewDataGodseekerMask
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataGodseekerMask)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataGodseekerMask), value);
    }

    public static bool KilledVoidIdol_1
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedVoidIdol_1)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedVoidIdol_1), value);
    }

    public static int KillsVoidIdol_1
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsVoidIdol_1)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsVoidIdol_1), value);
    }

    public static bool NewDataVoidIdol_1
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataVoidIdol_1)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataVoidIdol_1), value);
    }

    public static bool KilledVoidIdol_2
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedVoidIdol_2)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedVoidIdol_2), value);
    }

    public static int KillsVoidIdol_2
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsVoidIdol_2)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsVoidIdol_2), value);
    }

    public static bool NewDataVoidIdol_2
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataVoidIdol_2)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataVoidIdol_2), value);
    }

    public static bool KilledVoidIdol_3
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.killedVoidIdol_3)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.killedVoidIdol_3), value);
    }

    public static int KillsVoidIdol_3
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.killsVoidIdol_3)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.killsVoidIdol_3), value);
    }

    public static bool NewDataVoidIdol_3
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDataVoidIdol_3)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDataVoidIdol_3), value);
    }

    public static int GrubsCollected
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.grubsCollected)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.grubsCollected), value);
    }

    public static int GrubRewards
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.grubRewards)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.grubRewards), value);
    }

    public static bool FinalGrubRewardCollected
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.finalGrubRewardCollected)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.finalGrubRewardCollected), value);
    }

    public static bool FatGrubKing
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.fatGrubKing)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.fatGrubKing), value);
    }

    public static bool FalseKnightDefeated
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.falseKnightDefeated)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.falseKnightDefeated), value);
    }

    public static bool FalseKnightDreamDefeated
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.falseKnightDreamDefeated)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.falseKnightDreamDefeated), value);
    }

    public static bool FalseKnightOrbsCollected
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.falseKnightOrbsCollected)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.falseKnightOrbsCollected), value);
    }

    public static bool MawlekDefeated
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.mawlekDefeated)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.mawlekDefeated), value);
    }

    public static bool GiantBuzzerDefeated
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.giantBuzzerDefeated)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.giantBuzzerDefeated), value);
    }

    public static bool GiantFlyDefeated
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.giantFlyDefeated)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.giantFlyDefeated), value);
    }

    public static bool Blocker1Defeated
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.blocker1Defeated)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.blocker1Defeated), value);
    }

    public static bool Blocker2Defeated
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.blocker2Defeated)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.blocker2Defeated), value);
    }

    public static bool Hornet1Defeated
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hornet1Defeated)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hornet1Defeated), value);
    }

    public static bool CollectorDefeated
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.collectorDefeated)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.collectorDefeated), value);
    }

    public static bool HornetOutskirtsDefeated
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hornetOutskirtsDefeated)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hornetOutskirtsDefeated), value);
    }

    public static bool MageLordDreamDefeated
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.mageLordDreamDefeated)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.mageLordDreamDefeated), value);
    }

    public static bool MageLordOrbsCollected
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.mageLordOrbsCollected)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.mageLordOrbsCollected), value);
    }

    public static bool InfectedKnightDreamDefeated
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.infectedKnightDreamDefeated)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.infectedKnightDreamDefeated), value);
    }

    public static bool InfectedKnightOrbsCollected
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.infectedKnightOrbsCollected)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.infectedKnightOrbsCollected), value);
    }

    public static bool WhiteDefenderDefeated
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.whiteDefenderDefeated)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.whiteDefenderDefeated), value);
    }

    public static bool WhiteDefenderOrbsCollected
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.whiteDefenderOrbsCollected)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.whiteDefenderOrbsCollected), value);
    }

    public static int WhiteDefenderDefeats
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.whiteDefenderDefeats)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.whiteDefenderDefeats), value);
    }

    public static int GreyPrinceDefeats
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.greyPrinceDefeats)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.greyPrinceDefeats), value);
    }

    public static bool GreyPrinceDefeated
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.greyPrinceDefeated)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.greyPrinceDefeated), value);
    }

    public static bool GreyPrinceOrbsCollected
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.greyPrinceOrbsCollected)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.greyPrinceOrbsCollected), value);
    }

    public static int AladarSlugDefeated
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.aladarSlugDefeated)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.aladarSlugDefeated), value);
    }

    public static int XeroDefeated
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.xeroDefeated)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.xeroDefeated), value);
    }

    public static int ElderHuDefeated
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.elderHuDefeated)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.elderHuDefeated), value);
    }

    public static int MumCaterpillarDefeated
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.mumCaterpillarDefeated)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.mumCaterpillarDefeated), value);
    }

    public static int NoEyesDefeated
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.noEyesDefeated)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.noEyesDefeated), value);
    }

    public static int MarkothDefeated
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.markothDefeated)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.markothDefeated), value);
    }

    public static int GalienDefeated
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.galienDefeated)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.galienDefeated), value);
    }

    public static bool XERO_encountered
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.XERO_encountered)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.XERO_encountered), value);
    }

    public static bool ALADAR_encountered
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.ALADAR_encountered)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.ALADAR_encountered), value);
    }

    public static bool HU_encountered
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.HU_encountered)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.HU_encountered), value);
    }

    public static bool MUMCAT_encountered
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.MUMCAT_encountered)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.MUMCAT_encountered), value);
    }

    public static bool NOEYES_encountered
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.NOEYES_encountered)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.NOEYES_encountered), value);
    }

    public static bool MARKOTH_encountered
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.MARKOTH_encountered)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.MARKOTH_encountered), value);
    }

    public static bool GALIEN_encountered
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.GALIEN_encountered)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.GALIEN_encountered), value);
    }

    public static bool XeroPinned
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.xeroPinned)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.xeroPinned), value);
    }

    public static bool AladarPinned
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.aladarPinned)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.aladarPinned), value);
    }

    public static bool HuPinned
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.huPinned)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.huPinned), value);
    }

    public static bool MumCaterpillarPinned
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.mumCaterpillarPinned)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.mumCaterpillarPinned), value);
    }

    public static bool NoEyesPinned
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.noEyesPinned)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.noEyesPinned), value);
    }

    public static bool MarkothPinned
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.markothPinned)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.markothPinned), value);
    }

    public static bool GalienPinned
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.galienPinned)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.galienPinned), value);
    }

    public static int CurrentInvPane
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.currentInvPane)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.currentInvPane), value);
    }

    public static bool ShowGeoUI
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.showGeoUI)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.showGeoUI), value);
    }

    public static bool ShowHealthUI
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.showHealthUI)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.showHealthUI), value);
    }

    public static bool PromptFocus
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.promptFocus)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.promptFocus), value);
    }

    public static bool SeenFocusTablet
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.seenFocusTablet)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.seenFocusTablet), value);
    }

    public static bool SeenDreamNailPrompt
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.seenDreamNailPrompt)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.seenDreamNailPrompt), value);
    }

    public static bool IsFirstGame
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.isFirstGame)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.isFirstGame), value);
    }

    public static bool EnteredTutorialFirstTime
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.enteredTutorialFirstTime)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.enteredTutorialFirstTime), value);
    }

    public static bool IsInvincible
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.isInvincible)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.isInvincible), value);
    }

    public static bool InfiniteAirJump
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.infiniteAirJump)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.infiniteAirJump), value);
    }

    public static bool InvinciTest
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.invinciTest)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.invinciTest), value);
    }

    public static int CurrentArea
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.currentArea)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.currentArea), value);
    }

    public static bool VisitedDirtmouth
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.visitedDirtmouth)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.visitedDirtmouth), value);
    }

    public static bool VisitedCrossroads
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.visitedCrossroads)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.visitedCrossroads), value);
    }

    public static bool VisitedGreenpath
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.visitedGreenpath)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.visitedGreenpath), value);
    }

    public static bool VisitedFungus
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.visitedFungus)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.visitedFungus), value);
    }

    public static bool VisitedHive
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.visitedHive)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.visitedHive), value);
    }

    public static bool VisitedCrossroadsInfected
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.visitedCrossroadsInfected)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.visitedCrossroadsInfected), value);
    }

    public static bool VisitedRuins
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.visitedRuins)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.visitedRuins), value);
    }

    public static bool VisitedMines
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.visitedMines)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.visitedMines), value);
    }

    public static bool VisitedRoyalGardens
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.visitedRoyalGardens)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.visitedRoyalGardens), value);
    }

    public static bool VisitedFogCanyon
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.visitedFogCanyon)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.visitedFogCanyon), value);
    }

    public static bool VisitedDeepnest
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.visitedDeepnest)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.visitedDeepnest), value);
    }

    public static bool VisitedRestingGrounds
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.visitedRestingGrounds)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.visitedRestingGrounds), value);
    }

    public static bool VisitedWaterways
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.visitedWaterways)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.visitedWaterways), value);
    }

    public static bool VisitedAbyss
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.visitedAbyss)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.visitedAbyss), value);
    }

    public static bool VisitedOutskirts
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.visitedOutskirts)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.visitedOutskirts), value);
    }

    public static bool VisitedWhitePalace
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.visitedWhitePalace)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.visitedWhitePalace), value);
    }

    public static bool VisitedCliffs
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.visitedCliffs)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.visitedCliffs), value);
    }

    public static bool VisitedAbyssLower
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.visitedAbyssLower)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.visitedAbyssLower), value);
    }

    public static bool VisitedGodhome
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.visitedGodhome)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.visitedGodhome), value);
    }

    public static bool VisitedMines10
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.visitedMines10)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.visitedMines10), value);
    }

    public static bool HasMap
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasMap)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasMap), value);
    }

    public static bool MapAllRooms
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.mapAllRooms)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.mapAllRooms), value);
    }

    public static bool AtMapPrompt
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.atMapPrompt)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.atMapPrompt), value);
    }

    public static bool MapDirtmouth
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.mapDirtmouth)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.mapDirtmouth), value);
    }

    public static bool MapCrossroads
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.mapCrossroads)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.mapCrossroads), value);
    }

    public static bool MapGreenpath
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.mapGreenpath)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.mapGreenpath), value);
    }

    public static bool MapFogCanyon
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.mapFogCanyon)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.mapFogCanyon), value);
    }

    public static bool MapRoyalGardens
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.mapRoyalGardens)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.mapRoyalGardens), value);
    }

    public static bool MapFungalWastes
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.mapFungalWastes)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.mapFungalWastes), value);
    }

    public static bool MapCity
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.mapCity)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.mapCity), value);
    }

    public static bool MapWaterways
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.mapWaterways)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.mapWaterways), value);
    }

    public static bool MapMines
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.mapMines)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.mapMines), value);
    }

    public static bool MapDeepnest
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.mapDeepnest)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.mapDeepnest), value);
    }

    public static bool MapCliffs
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.mapCliffs)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.mapCliffs), value);
    }

    public static bool MapOutskirts
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.mapOutskirts)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.mapOutskirts), value);
    }

    public static bool MapRestingGrounds
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.mapRestingGrounds)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.mapRestingGrounds), value);
    }

    public static bool MapAbyss
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.mapAbyss)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.mapAbyss), value);
    }

    public static bool HasPin
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasPin)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasPin), value);
    }

    public static bool HasPinBench
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasPinBench)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasPinBench), value);
    }

    public static bool HasPinCocoon
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasPinCocoon)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasPinCocoon), value);
    }

    public static bool HasPinDreamPlant
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasPinDreamPlant)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasPinDreamPlant), value);
    }

    public static bool HasPinGuardian
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasPinGuardian)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasPinGuardian), value);
    }

    public static bool HasPinBlackEgg
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasPinBlackEgg)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasPinBlackEgg), value);
    }

    public static bool HasPinShop
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasPinShop)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasPinShop), value);
    }

    public static bool HasPinSpa
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasPinSpa)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasPinSpa), value);
    }

    public static bool HasPinStag
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasPinStag)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasPinStag), value);
    }

    public static bool HasPinTram
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasPinTram)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasPinTram), value);
    }

    public static bool HasPinGhost
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasPinGhost)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasPinGhost), value);
    }

    public static bool HasPinGrub
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasPinGrub)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasPinGrub), value);
    }

    public static bool HasMarker
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasMarker)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasMarker), value);
    }

    public static bool HasMarker_r
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasMarker_r)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasMarker_r), value);
    }

    public static bool HasMarker_b
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasMarker_b)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasMarker_b), value);
    }

    public static bool HasMarker_y
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasMarker_y)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasMarker_y), value);
    }

    public static bool HasMarker_w
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasMarker_w)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasMarker_w), value);
    }

    public static int SpareMarkers_r
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.spareMarkers_r)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.spareMarkers_r), value);
    }

    public static int SpareMarkers_b
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.spareMarkers_b)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.spareMarkers_b), value);
    }

    public static int SpareMarkers_y
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.spareMarkers_y)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.spareMarkers_y), value);
    }

    public static int SpareMarkers_w
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.spareMarkers_w)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.spareMarkers_w), value);
    }

    public static int EnvironmentType
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.environmentType)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.environmentType), value);
    }

    public static int EnvironmentTypeDefault
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.environmentTypeDefault)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.environmentTypeDefault), value);
    }

    public static int PreviousDarkness
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.previousDarkness)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.previousDarkness), value);
    }

    public static bool OpenedTramLower
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.openedTramLower)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.openedTramLower), value);
    }

    public static bool OpenedTramRestingGrounds
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.openedTramRestingGrounds)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.openedTramRestingGrounds), value);
    }

    public static int TramLowerPosition
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.tramLowerPosition)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.tramLowerPosition), value);
    }

    public static int TramRestingGroundsPosition
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.tramRestingGroundsPosition)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.tramRestingGroundsPosition), value);
    }

    public static bool MineLiftOpened
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.mineLiftOpened)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.mineLiftOpened), value);
    }

    public static bool MenderDoorOpened
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.menderDoorOpened)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.menderDoorOpened), value);
    }

    public static bool VesselFragStagNest
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.vesselFragStagNest)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.vesselFragStagNest), value);
    }

    public static bool ShamanPillar
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.shamanPillar)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.shamanPillar), value);
    }

    public static bool CrossroadsMawlekWall
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.crossroadsMawlekWall)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.crossroadsMawlekWall), value);
    }

    public static bool EggTempleVisited
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.eggTempleVisited)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.eggTempleVisited), value);
    }

    public static bool CrossroadsInfected
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.crossroadsInfected)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.crossroadsInfected), value);
    }

    public static bool FalseKnightFirstPlop
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.falseKnightFirstPlop)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.falseKnightFirstPlop), value);
    }

    public static bool FalseKnightWallRepaired
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.falseKnightWallRepaired)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.falseKnightWallRepaired), value);
    }

    public static bool FalseKnightWallBroken
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.falseKnightWallBroken)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.falseKnightWallBroken), value);
    }

    public static bool FalseKnightGhostDeparted
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.falseKnightGhostDeparted)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.falseKnightGhostDeparted), value);
    }

    public static bool SpaBugsEncountered
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.spaBugsEncountered)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.spaBugsEncountered), value);
    }

    public static bool HornheadVinePlat
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hornheadVinePlat)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hornheadVinePlat), value);
    }

    public static bool InfectedKnightEncountered
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.infectedKnightEncountered)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.infectedKnightEncountered), value);
    }

    public static bool MegaMossChargerEncountered
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.megaMossChargerEncountered)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.megaMossChargerEncountered), value);
    }

    public static bool MegaMossChargerDefeated
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.megaMossChargerDefeated)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.megaMossChargerDefeated), value);
    }

    public static bool DreamerScene1
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.dreamerScene1)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.dreamerScene1), value);
    }

    public static bool SlugEncounterComplete
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.slugEncounterComplete)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.slugEncounterComplete), value);
    }

    public static bool DefeatedDoubleBlockers
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.defeatedDoubleBlockers)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.defeatedDoubleBlockers), value);
    }

    public static bool OneWayArchive
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.oneWayArchive)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.oneWayArchive), value);
    }

    public static bool DefeatedMegaJelly
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.defeatedMegaJelly)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.defeatedMegaJelly), value);
    }

    public static bool SummonedMonomon
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.summonedMonomon)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.summonedMonomon), value);
    }

    public static bool SawWoundedQuirrel
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.sawWoundedQuirrel)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.sawWoundedQuirrel), value);
    }

    public static bool EncounteredMegaJelly
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.encounteredMegaJelly)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.encounteredMegaJelly), value);
    }

    public static bool DefeatedMantisLords
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.defeatedMantisLords)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.defeatedMantisLords), value);
    }

    public static bool EncounteredGatekeeper
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.encounteredGatekeeper)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.encounteredGatekeeper), value);
    }

    public static bool DeepnestWall
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.deepnestWall)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.deepnestWall), value);
    }

    public static bool QueensStationNonDisplay
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.queensStationNonDisplay)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.queensStationNonDisplay), value);
    }

    public static bool CityBridge1
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.cityBridge1)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.cityBridge1), value);
    }

    public static bool CityBridge2
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.cityBridge2)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.cityBridge2), value);
    }

    public static bool CityLift1
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.cityLift1)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.cityLift1), value);
    }

    public static bool CityLift1_isUp
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.cityLift1_isUp)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.cityLift1_isUp), value);
    }

    public static bool LiftArrival
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.liftArrival)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.liftArrival), value);
    }

    public static bool OpenedMageDoor
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.openedMageDoor)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.openedMageDoor), value);
    }

    public static bool OpenedMageDoor_v2
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.openedMageDoor_v2)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.openedMageDoor_v2), value);
    }

    public static bool BrokenMageWindow
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.brokenMageWindow)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.brokenMageWindow), value);
    }

    public static bool BrokenMageWindowGlass
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.brokenMageWindowGlass)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.brokenMageWindowGlass), value);
    }

    public static bool MageLordEncountered
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.mageLordEncountered)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.mageLordEncountered), value);
    }

    public static bool MageLordEncountered_2
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.mageLordEncountered_2)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.mageLordEncountered_2), value);
    }

    public static bool MageLordDefeated
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.mageLordDefeated)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.mageLordDefeated), value);
    }

    public static bool Ruins1_5_tripleDoor
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.ruins1_5_tripleDoor)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.ruins1_5_tripleDoor), value);
    }

    public static bool OpenedCityGate
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.openedCityGate)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.openedCityGate), value);
    }

    public static bool CityGateClosed
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.cityGateClosed)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.cityGateClosed), value);
    }

    public static bool BathHouseOpened
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.bathHouseOpened)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.bathHouseOpened), value);
    }

    public static bool BathHouseWall
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.bathHouseWall)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.bathHouseWall), value);
    }

    public static bool CityLift2
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.cityLift2)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.cityLift2), value);
    }

    public static bool CityLift2_isUp
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.cityLift2_isUp)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.cityLift2_isUp), value);
    }

    public static bool City2_sewerDoor
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.city2_sewerDoor)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.city2_sewerDoor), value);
    }

    public static bool OpenedLoveDoor
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.openedLoveDoor)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.openedLoveDoor), value);
    }

    public static bool WatcherChandelier
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.watcherChandelier)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.watcherChandelier), value);
    }

    public static bool CompletedQuakeArea
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.completedQuakeArea)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.completedQuakeArea), value);
    }

    public static bool KingsStationNonDisplay
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.kingsStationNonDisplay)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.kingsStationNonDisplay), value);
    }

    public static bool TollBenchCity
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.tollBenchCity)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.tollBenchCity), value);
    }

    public static bool WaterwaysGate
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.waterwaysGate)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.waterwaysGate), value);
    }

    public static bool DefeatedDungDefender
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.defeatedDungDefender)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.defeatedDungDefender), value);
    }

    public static bool DungDefenderEncounterReady
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.dungDefenderEncounterReady)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.dungDefenderEncounterReady), value);
    }

    public static bool FlukeMotherEncountered
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.flukeMotherEncountered)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.flukeMotherEncountered), value);
    }

    public static bool FlukeMotherDefeated
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.flukeMotherDefeated)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.flukeMotherDefeated), value);
    }

    public static bool OpenedWaterwaysManhole
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.openedWaterwaysManhole)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.openedWaterwaysManhole), value);
    }

    public static bool WaterwaysAcidDrained
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.waterwaysAcidDrained)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.waterwaysAcidDrained), value);
    }

    public static bool DungDefenderWallBroken
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.dungDefenderWallBroken)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.dungDefenderWallBroken), value);
    }

    public static bool DungDefenderSleeping
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.dungDefenderSleeping)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.dungDefenderSleeping), value);
    }

    public static bool DefeatedMegaBeamMiner
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.defeatedMegaBeamMiner)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.defeatedMegaBeamMiner), value);
    }

    public static bool DefeatedMegaBeamMiner2
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.defeatedMegaBeamMiner2)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.defeatedMegaBeamMiner2), value);
    }

    public static bool BrokeMinersWall
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.brokeMinersWall)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.brokeMinersWall), value);
    }

    public static bool EncounteredMimicSpider
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.encounteredMimicSpider)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.encounteredMimicSpider), value);
    }

    public static bool SteppedBeyondBridge
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.steppedBeyondBridge)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.steppedBeyondBridge), value);
    }

    public static bool DeepnestBridgeCollapsed
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.deepnestBridgeCollapsed)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.deepnestBridgeCollapsed), value);
    }

    public static bool SpiderCapture
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.spiderCapture)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.spiderCapture), value);
    }

    public static bool Deepnest26b_switch
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.deepnest26b_switch)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.deepnest26b_switch), value);
    }

    public static bool OpenedRestingGrounds02
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.openedRestingGrounds02)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.openedRestingGrounds02), value);
    }

    public static bool RestingGroundsCryptWall
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.restingGroundsCryptWall)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.restingGroundsCryptWall), value);
    }

    public static bool DreamNailConvo
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.dreamNailConvo)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.dreamNailConvo), value);
    }

    public static int GladeGhostsKilled
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.gladeGhostsKilled)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.gladeGhostsKilled), value);
    }

    public static bool OpenedGardensStagStation
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.openedGardensStagStation)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.openedGardensStagStation), value);
    }

    public static bool ExtendedGramophone
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.extendedGramophone)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.extendedGramophone), value);
    }

    public static bool TollBenchQueensGardens
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.tollBenchQueensGardens)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.tollBenchQueensGardens), value);
    }

    public static bool BlizzardEnded
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.blizzardEnded)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.blizzardEnded), value);
    }

    public static bool EncounteredHornet
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.encounteredHornet)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.encounteredHornet), value);
    }

    public static bool SavedByHornet
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.savedByHornet)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.savedByHornet), value);
    }

    public static bool OutskirtsWall
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.outskirtsWall)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.outskirtsWall), value);
    }

    public static bool AbyssGateOpened
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.abyssGateOpened)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.abyssGateOpened), value);
    }

    public static bool AbyssLighthouse
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.abyssLighthouse)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.abyssLighthouse), value);
    }

    public static bool BlueVineDoor
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.blueVineDoor)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.blueVineDoor), value);
    }

    public static bool GotShadeCharm
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotShadeCharm)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotShadeCharm), value);
    }

    public static bool TollBenchAbyss
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.tollBenchAbyss)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.tollBenchAbyss), value);
    }

    public static int FountainGeo
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.fountainGeo)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.fountainGeo), value);
    }

    public static bool FountainVesselSummoned
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.fountainVesselSummoned)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.fountainVesselSummoned), value);
    }

    public static bool OpenedBlackEggPath
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.openedBlackEggPath)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.openedBlackEggPath), value);
    }

    public static bool EnteredDreamWorld
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.enteredDreamWorld)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.enteredDreamWorld), value);
    }

    public static bool DuskKnightDefeated
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.duskKnightDefeated)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.duskKnightDefeated), value);
    }

    public static bool WhitePalaceOrb_1
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.whitePalaceOrb_1)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.whitePalaceOrb_1), value);
    }

    public static bool WhitePalaceOrb_2
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.whitePalaceOrb_2)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.whitePalaceOrb_2), value);
    }

    public static bool WhitePalaceOrb_3
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.whitePalaceOrb_3)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.whitePalaceOrb_3), value);
    }

    public static bool WhitePalace05_lever
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.whitePalace05_lever)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.whitePalace05_lever), value);
    }

    public static bool WhitePalaceMidWarp
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.whitePalaceMidWarp)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.whitePalaceMidWarp), value);
    }

    public static bool WhitePalaceSecretRoomVisited
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.whitePalaceSecretRoomVisited)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.whitePalaceSecretRoomVisited), value);
    }

    public static bool TramOpenedDeepnest
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.tramOpenedDeepnest)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.tramOpenedDeepnest), value);
    }

    public static bool TramOpenedCrossroads
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.tramOpenedCrossroads)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.tramOpenedCrossroads), value);
    }

    public static bool OpenedBlackEggDoor
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.openedBlackEggDoor)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.openedBlackEggDoor), value);
    }

    public static bool UnchainedHollowKnight
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.unchainedHollowKnight)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.unchainedHollowKnight), value);
    }

    public static int FlamesCollected
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.flamesCollected)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.flamesCollected), value);
    }

    public static int FlamesRequired
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.flamesRequired)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.flamesRequired), value);
    }

    public static bool NightmareLanternAppeared
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.nightmareLanternAppeared)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.nightmareLanternAppeared), value);
    }

    public static bool NightmareLanternLit
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.nightmareLanternLit)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.nightmareLanternLit), value);
    }

    public static bool TroupeInTown
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.troupeInTown)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.troupeInTown), value);
    }

    public static bool DivineInTown
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.divineInTown)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.divineInTown), value);
    }

    public static int GrimmChildLevel
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.grimmChildLevel)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.grimmChildLevel), value);
    }

    public static bool ElderbugConvoGrimm
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.elderbugConvoGrimm)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.elderbugConvoGrimm), value);
    }

    public static bool SlyConvoGrimm
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.slyConvoGrimm)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.slyConvoGrimm), value);
    }

    public static bool IseldaConvoGrimm
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.iseldaConvoGrimm)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.iseldaConvoGrimm), value);
    }

    public static bool MidwifeWeaverlingConvo
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.midwifeWeaverlingConvo)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.midwifeWeaverlingConvo), value);
    }

    public static bool MetGrimm
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.metGrimm)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.metGrimm), value);
    }

    public static bool FoughtGrimm
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.foughtGrimm)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.foughtGrimm), value);
    }

    public static bool MetBrum
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.metBrum)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.metBrum), value);
    }

    public static bool DefeatedNightmareGrimm
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.defeatedNightmareGrimm)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.defeatedNightmareGrimm), value);
    }

    public static bool GrimmchildAwoken
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.grimmchildAwoken)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.grimmchildAwoken), value);
    }

    public static bool GotBrummsFlame
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotBrummsFlame)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotBrummsFlame), value);
    }

    public static bool BrummBrokeBrazier
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.brummBrokeBrazier)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.brummBrokeBrazier), value);
    }

    public static bool DestroyedNightmareLantern
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.destroyedNightmareLantern)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.destroyedNightmareLantern), value);
    }

    public static bool GotGrimmNotch
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gotGrimmNotch)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gotGrimmNotch), value);
    }

    public static bool NymmInTown
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.nymmInTown)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.nymmInTown), value);
    }

    public static bool NymmSpoken
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.nymmSpoken)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.nymmSpoken), value);
    }

    public static bool NymmCharmConvo
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.nymmCharmConvo)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.nymmCharmConvo), value);
    }

    public static bool NymmFinalConvo
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.nymmFinalConvo)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.nymmFinalConvo), value);
    }

    public static bool ElderbugNymmConvo
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.elderbugNymmConvo)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.elderbugNymmConvo), value);
    }

    public static bool SlyNymmConvo
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.slyNymmConvo)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.slyNymmConvo), value);
    }

    public static bool IseldaNymmConvo
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.iseldaNymmConvo)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.iseldaNymmConvo), value);
    }

    public static bool NymmMissedEggOpen
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.nymmMissedEggOpen)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.nymmMissedEggOpen), value);
    }

    public static bool ElderbugTroupeLeftConvo
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.elderbugTroupeLeftConvo)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.elderbugTroupeLeftConvo), value);
    }

    public static bool ElderbugBrettaLeft
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.elderbugBrettaLeft)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.elderbugBrettaLeft), value);
    }

    public static bool JijiGrimmConvo
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.jijiGrimmConvo)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.jijiGrimmConvo), value);
    }

    public static bool MetDivine
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.metDivine)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.metDivine), value);
    }

    public static bool DivineFinalConvo
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.divineFinalConvo)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.divineFinalConvo), value);
    }

    public static bool GaveFragileHeart
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gaveFragileHeart)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gaveFragileHeart), value);
    }

    public static bool GaveFragileGreed
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gaveFragileGreed)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gaveFragileGreed), value);
    }

    public static bool GaveFragileStrength
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.gaveFragileStrength)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.gaveFragileStrength), value);
    }

    public static int DivineEatenConvos
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.divineEatenConvos)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.divineEatenConvos), value);
    }

    public static bool PooedFragileHeart
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.pooedFragileHeart)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.pooedFragileHeart), value);
    }

    public static bool PooedFragileGreed
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.pooedFragileGreed)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.pooedFragileGreed), value);
    }

    public static bool PooedFragileStrength
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.pooedFragileStrength)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.pooedFragileStrength), value);
    }

    public static float completionPercentage
    {
        get => PlayerData.instance?.GetFloat(nameof(PlayerData.completionPercentage)) ?? -1;
        set => PlayerData.instance?.SetFloat(nameof(PlayerData.completionPercentage), value);
    }

    public static bool DisablePause
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.disablePause)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.disablePause), value);
    }

    public static bool BackerCredits
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.backerCredits)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.backerCredits), value);
    }

    public static bool UnlockedCompletionRate
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.unlockedCompletionRate)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.unlockedCompletionRate), value);
    }

    public static int MapKeyPref
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.mapKeyPref)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.mapKeyPref), value);
    }

    public static string playerStoryOutput
    {
        get => PlayerData.instance?.GetString(nameof(PlayerData.playerStoryOutput));
        set => PlayerData.instance?.SetString(nameof(PlayerData.playerStoryOutput), value);
    }

    public static bool BetaEnd
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.betaEnd)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.betaEnd), value);
    }

    public static bool NewDatTraitorLord
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.newDatTraitorLord)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.newDatTraitorLord), value);
    }

    public static string bossReturnEntryGate
    {
        get => PlayerData.instance?.GetString(nameof(PlayerData.bossReturnEntryGate));
        set => PlayerData.instance?.SetString(nameof(PlayerData.bossReturnEntryGate), value);
    }

    public static int BossStatueTargetLevel
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.bossStatueTargetLevel)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.bossStatueTargetLevel), value);
    }

    public static string currentBossStatueCompletionKey
    {
        get => PlayerData.instance?.GetString(nameof(PlayerData.currentBossStatueCompletionKey));
        set => PlayerData.instance?.SetString(nameof(PlayerData.currentBossStatueCompletionKey), value);
    }

    public static bool GodseekerUnlocked
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.godseekerUnlocked)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.godseekerUnlocked), value);
    }

    public static bool BossRushMode
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.bossRushMode)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.bossRushMode), value);
    }

    public static bool BossDoorCageUnlocked
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.bossDoorCageUnlocked)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.bossDoorCageUnlocked), value);
    }

    public static bool BlueRoomDoorUnlocked
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.blueRoomDoorUnlocked)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.blueRoomDoorUnlocked), value);
    }

    public static bool BlueRoomActivated
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.blueRoomActivated)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.blueRoomActivated), value);
    }

    public static bool FinalBossDoorUnlocked
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.finalBossDoorUnlocked)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.finalBossDoorUnlocked), value);
    }

    public static bool HasGodfinder
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.hasGodfinder)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.hasGodfinder), value);
    }

    public static bool UnlockedNewBossStatue
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.unlockedNewBossStatue)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.unlockedNewBossStatue), value);
    }

    public static bool ScaredFlukeHermitEncountered
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.scaredFlukeHermitEncountered)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.scaredFlukeHermitEncountered), value);
    }

    public static bool ScaredFlukeHermitReturned
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.scaredFlukeHermitReturned)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.scaredFlukeHermitReturned), value);
    }

    public static bool EnteredGGAtrium
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.enteredGGAtrium)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.enteredGGAtrium), value);
    }

    public static bool ExtraFlowerAppear
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.extraFlowerAppear)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.extraFlowerAppear), value);
    }

    public static bool GivenGodseekerFlower
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.givenGodseekerFlower)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.givenGodseekerFlower), value);
    }

    public static bool GivenOroFlower
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.givenOroFlower)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.givenOroFlower), value);
    }

    public static bool GivenWhiteLadyFlower
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.givenWhiteLadyFlower)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.givenWhiteLadyFlower), value);
    }

    public static bool GivenEmilitiaFlower
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.givenEmilitiaFlower)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.givenEmilitiaFlower), value);
    }

    public static bool QueuedGodfinderIcon
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.queuedGodfinderIcon)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.queuedGodfinderIcon), value);
    }

    public static bool GodseekerSpokenAwake
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.godseekerSpokenAwake)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.godseekerSpokenAwake), value);
    }

    public static bool NailsmithCorpseAppeared
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.nailsmithCorpseAppeared)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.nailsmithCorpseAppeared), value);
    }

    public static int GodseekerWaterwaysSeenState
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.godseekerWaterwaysSeenState)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.godseekerWaterwaysSeenState), value);
    }

    public static bool GodseekerWaterwaysSpoken1
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.godseekerWaterwaysSpoken1)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.godseekerWaterwaysSpoken1), value);
    }

    public static bool GodseekerWaterwaysSpoken2
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.godseekerWaterwaysSpoken2)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.godseekerWaterwaysSpoken2), value);
    }

    public static bool GodseekerWaterwaysSpoken3
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.godseekerWaterwaysSpoken3)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.godseekerWaterwaysSpoken3), value);
    }

    public static int BossDoorEntranceTextSeen
    {
        get => PlayerData.instance?.GetInt(nameof(PlayerData.bossDoorEntranceTextSeen)) ?? -1;
        set => PlayerData.instance?.SetInt(nameof(PlayerData.bossDoorEntranceTextSeen), value);
    }

    public static bool SeenDoor4Finale
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.seenDoor4Finale)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.seenDoor4Finale), value);
    }

    public static bool ZoteStatueWallBroken
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.zoteStatueWallBroken)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.zoteStatueWallBroken), value);
    }

    public static bool SeenGGWastes
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.seenGGWastes)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.seenGGWastes), value);
    }

    public static bool OrdealAchieved
    {
        get => PlayerData.instance?.GetBool(nameof(PlayerData.ordealAchieved)) ?? false;
        set => PlayerData.instance?.SetBool(nameof(PlayerData.ordealAchieved), value);
    }

    #endregion
}
