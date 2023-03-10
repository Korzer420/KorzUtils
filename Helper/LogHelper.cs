using KorzUtils.Enums;
using Modding;
using System;

namespace KorzUtils.Helper;

/// <summary>
/// Provides useful functions regarding logging.
/// </summary>
public static class LogHelper
{
    /// <summary>
    /// Creates a log entry in the modlog.
    /// </summary>
    /// <typeparam name="T">The mod which name should be included in the log.</typeparam>
    /// <param name="message">The message that should be written.</param>
    /// <param name="logType">The type of log message</param>
    /// <param name="includeScene">If <see langword="true"/>, the current scene is prepended.</param>
    public static void Write<T>(string message, LogType logType = LogType.Normal, bool includeScene = true) where T : Mod
    {
        if (includeScene)
            message = $"(In scene: {UnityEngine.SceneManagement.SceneManager.GetActiveScene().name}) " + message;

        message = $"[{typeof(T).Name}]" + message;
        switch (logType)
        {
            case LogType.Normal:
                Logger.Log(message);
                break;
            case LogType.Warning:
                Logger.LogWarn(message);
                break;
            case LogType.Error:
                Logger.LogError(message);
                break;
            case LogType.Debug:
                Logger.LogDebug(message);
                break;
            default:
                Logger.LogFine(message);
                break;
        }
    }

    /// <summary>
    /// Creates a log error entry in the modlog.
    /// </summary>
    /// <typeparam name="T">The mod which name should be included in the log.</typeparam>
    /// <param name="message">The message that should be written.</param>
    /// <param name="error">The error that should be thrown</param>
    /// <param name="includeScene">If <see langword="true"/>, the current scene is prepended.</param>
    public static void Write<T>(string message, Exception error, bool includeScene = true) where T : Mod
     => Write<T>(message + error.ToString(), LogType.Error, includeScene);

}
