using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine;

namespace KorzUtils.Helper;

/// <summary>
/// Provides useful function regarding sprites.
/// </summary>
public static class SpriteHelper
{
    private static Dictionary<string, Sprite> _cachedSprites = new();

    /// <summary>
    /// Creates a sprite from the given image path. Starts in the resource folder.
    /// </summary>
    public static Sprite CreateSprite(Assembly assembly, string modName, string spriteName) => CreateSprite(assembly, modName, spriteName, ".png");

    /// <summary>
    /// Creates a sprite from the given image path. Starts in this Resource folder.
    /// </summary>
    public static Sprite CreateSprite(Assembly assembly, string modName, string spriteName, string extension)
    {
        if (!_cachedSprites.ContainsKey($"{modName}{spriteName}"))
        {
            // Don't ask...
            using Stream stream = ResourceHelper.LoadResource(assembly,modName,$"{spriteName + extension}");
            using MemoryStream ms = new();
            stream.CopyTo(ms);
            byte[] imageData = ms.ToArray();
            Texture2D tex = new(1, 1, TextureFormat.RGBA32, false);
            ImageConversion.LoadImage(tex, imageData, true);
            tex.filterMode = FilterMode.Bilinear;
            _cachedSprites.Add($"{modName}{spriteName}", Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), new Vector2(.5f, .5f)));
        }
        return _cachedSprites[$"{modName}{spriteName}"];
    }
}