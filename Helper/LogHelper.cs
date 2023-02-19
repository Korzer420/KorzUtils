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
    /// <param name="timeStamp">If <see langword="true"/> the current date time is included.</param>
    /// <param name="includeScene">If <see langword="true"/>, the current scene is prepended.</param>
    public static void Write<T>(string message, LogType logType = LogType.Normal, bool timeStamp = true, bool includeScene = true) where T : Mod
    {
        if (includeScene)
            message = $"(In scene: {UnityEngine.SceneManagement.SceneManager.GetActiveScene().name}) " + message;
        if (timeStamp)
            message = $"(At {DateTime.Now}) " + message;

        message = $"From mod: {typeof(T).Name} -> " + message;
        switch (logType)
        {
            case LogType.Normal:
                KorzUtils.Instance.Log(message);
                break;
            case LogType.Warning:
                KorzUtils.Instance.LogWarn(message);
                break;
            case LogType.Error:
                KorzUtils.Instance.LogError(message);
                break;
            case LogType.Debug:
                KorzUtils.Instance.LogDebug(message);
                break;
            default:
                KorzUtils.Instance.LogFine(message);
                break;
        }
    }
}
