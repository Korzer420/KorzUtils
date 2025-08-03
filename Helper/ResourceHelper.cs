using Modding;
using Newtonsoft.Json;
using System;
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
    /// <para/>Make sure to dispose the stream afterwards!
    /// </summary>
    /// <typeparam name="T">The mod (assembly) from which the resource stream should be taken. This also serves as the first part of the resource path.</typeparam>
    /// <param name="fileName">The name (and additional path) of the file. Starts in the resource folder. Format is [ModName].Resources.[<paramref name="fileName"/>]
    /// <para/>Keep in mind that the mod class name has to match the namespace to work. For example a mod class "BetterFuryMod" in the namespace "BetterFury" will not work correctly.</param>
    [Obsolete("Deprecated. Use Load instead.")]
    public static Stream LoadResource<T>(string fileName) where T : Mod
        => typeof(T).Assembly.GetManifestResourceStream($"{typeof(T).Name}.Resources.{fileName.Replace("/", ".").Replace("\\", ".")}");

    /// <summary>
    /// Loads a resource from the assembly into a stream.
    /// <para/>Make sure to dispose the stream afterwards!
    /// </summary>
    /// <typeparam name="T">The mod (assembly) from which the resource stream should be taken.</typeparam>
    /// <param name="resourcePath">The full path to the resources. Unlike <see cref="LoadResource{T}(string)"/> this requires the FULL namespace path.
    /// <para/>For example: "BetterFury.Properties.Resources.Data.json". This allows the actual mod class to have a different name than the namespace.</param>
    public static Stream Load<T>(string resourcePath) where T : Mod
        => typeof(T).Assembly.GetManifestResourceStream(resourcePath.Replace("/", ".").Replace("\\", "."));

    /// <summary>
    /// Loads a json file and deserialize the result.
    /// </summary>
    /// <typeparam name="T">The mod assembly from which the resource should be loaded.</typeparam>
    /// <typeparam name="ResultType">The type in which the result stream should be deserialized.</typeparam>
    /// <param name="fileName"/>The name (and additional path) of the file. Starts in the resource folder. Format is [ModName].Resources.
    /// <para>Use "." to seperate directories instead of "/"</para>.
    [Obsolete("Deprecated. Use LoadJson instead.")]
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

    /// <summary>
    /// Loads a json file and deserialize the result.
    /// </summary>
    /// <typeparam name="T">The mod assembly from which the resource should be loaded.</typeparam>
    /// <typeparam name="ResultType">The type in which the result stream should be deserialized.</typeparam>
    /// <param name="resourcePath"/>The full resource path in the assembly given by T.
    public static ResultType LoadJson<T, ResultType>(string resourcePath) where T : Mod
    {
        try
        {
            using Stream locationStream = Load<T>(resourcePath);
            using StreamReader reader = new(locationStream);
            JsonSerializer jsonSerializer = new()
            {
                TypeNameHandling = TypeNameHandling.Auto
            };
            return jsonSerializer.Deserialize<ResultType>(new JsonTextReader(reader));
        }
        catch (System.Exception exception)
        {
            LogHelper.Write<KorzUtils>("Failed to load json file " + resourcePath, exception, false);
        }
        return default;
    }

    #endregion
}
