namespace KorzUtils.Enums;

/// <summary>
/// Defines the kind of hook which should be added.
/// </summary>
internal enum Hook
{
    /// <summary>
    /// Executed before the player enters a new save file.
    /// </summary>
    BeforeStartGame,

    /// <summary>
    /// Executed after the player enters a new save file.
    /// </summary>
    AfterStartGame,

    /// <summary>
    /// Executed before the player enters an already existing save file.
    /// </summary>
    BeforeContinueGame,

    /// <summary>
    /// Executed after the player enters an already existing save file.
    /// </summary>
    AfterContinueGame,

    /// <summary>
    /// Executed before the player returns to the main menu from a save file.
    /// </summary>
    BeforeExitGame,

    /// <summary>
    /// Executed after the player returns to the main menu from a save file.
    /// </summary>
    AfterExitGame,

    /// <summary>
    /// Executed when an integer from PlayerData is requested.
    /// </summary>
    PlayerGetInt,

    /// <summary>
    /// Executed when an integer from PlayerData should be set.
    /// </summary>
    PlayerSetInt,

    /// <summary>
    /// Executed when a bool from PlayerData is requested.
    /// </summary>
    PlayerGetBool,

    /// <summary>
    /// Executed when an bool from PlayerData should be set.
    /// </summary>
    PlayerSetBool,

    /// <summary>
    /// Executed when a float from PlayerData is requested.
    /// </summary>
    PlayerGetString,

    /// <summary>
    /// Executed when an float from PlayerData should be set.
    /// </summary>
    PlayerSetString,

    /// <summary>
    /// Executed when the player takes damage.
    /// </summary>
    HeroTakeDamage,

    /// <summary>
    /// Executed before the player dies.
    /// </summary>
    BeforeHeroDie,

    /// <summary>
    /// Executed after the player dies.
    /// </summary>
    AfterHeroDie,

    /// <summary>
    /// Executed before an enemy takes damage.
    /// </summary>
    BeforeEnemyTakeDamage,

    /// <summary>
    /// Executed after an enemy takes damage.
    /// </summary>
    AfterEnemyTakeDamage,

    /// <summary>
    /// Executed before an enemy dies.
    /// </summary>
    BeforeEnemyDie,

    /// <summary>
    /// Executed after an enemy dies.
    /// </summary>
    AfterEnemyDie,

    /// <summary>
    /// Executed before a fsm is enabled.
    /// </summary>
    BeforeEnableFsm,

    /// <summary>
    /// Executed after a fsm is enabled.
    /// </summary>
    AfterEnableFsm,

    LanguageGet
}
