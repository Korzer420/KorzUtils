namespace KorzUtils.Helper;

public enum LogType
{
    Normal,

    Warning,

    Error,

    Debug,

    Fine
}

/// <summary>
/// Provides useful functions regarding logging.
/// </summary>
public static class LogHelper
{
    internal static void Write(string message, LogType logType = LogType.Normal)
    => Write(null, message, logType);

    internal static void Write(string mod, string message, LogType logType = LogType.Normal)
    {
        message = $"(At {UnityEngine.SceneManagement.SceneManager.GetActiveScene().name}) {message}";
        if (!string.IsNullOrEmpty(mod))
            message = "{From " + mod + "}" + message;
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
