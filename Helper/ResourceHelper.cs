using Modding;
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
    /// <param name="fileName">The name (and additional path) of the file. Starts in the resource folder. Format is [ModName].Resources.fileName<paramref name="fileName"/>
    /// <para>Use "." to seperate directories instead of "/"</para>.</param>
    /// <returns></returns>
    public static Stream LoadResource<T>(string fileName) where T : Mod
    => typeof(T).Assembly.GetManifestResourceStream($"{typeof(T).Name}.Resources.{fileName}");
    

    #endregion
}
