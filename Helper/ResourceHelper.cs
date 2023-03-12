using Modding;
using Newtonsoft.Json;
using System.IO;

namespace KorzUtils.Helper;

/// <summary>
/// Provides useful functions around resources.
/// </summary>
public static class ResourceHelper
{
    #region Methods

    /// <summary>
    /// Loads a file from the resource path.
    /// <para>Make sure to dispose the stream afterwards!</para>
    /// </summary>
    /// <param name="fileName">The name (and additional path) of the file. Starts in the resource folder. Format is [ModName].Resources.<paramref name="fileName"/>
    /// <para>Use "." to seperate directories instead of "/"</para>.</param>
    public static Stream LoadResource<T>(string fileName) where T : Mod
    => typeof(T).Assembly.GetManifestResourceStream($"{typeof(T).Name}.Resources.{fileName.Replace("/", ".").Replace("\\", ".")}");

    /// <summary>
    /// Loads a json file and deserialize the result.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="ResultType">The type in which the result stream should be deserialized.</typeparam>
    /// <param name="fileName">The name (and additional path) of the file. Starts in the resource folder. Format is [ModName].Resources.<paramref name="fileName"/>
    /// <para>Use "." to seperate directories instead of "/"</para>.
    public static ResultType LoadJsonResource<T, ResultType>(string fileName) where T : Mod
    {
        try
        {
            using Stream locationStream = LoadResource<T>(fileName);
            using StreamReader reader = new(locationStream);
            JsonSerializer jsonSerializer = new()
            {
                TypeNameHandling = TypeNameHandling.Auto
            };
            return jsonSerializer.Deserialize<ResultType>(new JsonTextReader(reader));
        }
        catch (System.Exception exception)
        {
            LogHelper.Write<KorzUtils>("Failed to load json file " + fileName, exception, false);
        }

        return default;
    }

    #endregion
}
