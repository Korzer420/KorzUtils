using System.IO;
using System.Reflection;

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
    /// <param name="assembly">The assembly in which the resource file is placed.</param>
    /// <param name="modName">The name of the mod.</param>
    /// <param name="fileName">The name (and additional path) of the file. Format is: <paramref name="modName"/>.Resource.<paramref name="fileName"/></param>
    /// <returns></returns>
    public static Stream LoadResource(Assembly assembly, string modName, string fileName)
    => assembly.GetManifestResourceStream($"{modName}.Resources.{fileName}");
    

    #endregion
}
