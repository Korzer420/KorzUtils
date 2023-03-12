using Modding;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace KorzUtils.Helper;

/// <summary>
/// Provides useful function regarding sprites.
/// </summary>
public static class SpriteHelper
{
    private static Dictionary<string, Sprite> _cachedSprites = new();

    /// <summary>
    /// Creates a sprite from the given image path. Starts in the Resource folder.
    /// <para>All "/" and "\" will be replaced with "."</para>
    /// </summary>
    public static Sprite CreateSprite<T>(string spriteName, string extension = ".png") where T : Mod
    {
        string modName = typeof(T).Name;
        string fullFileName = $"{modName}.{spriteName.Replace("/", ".").Replace("\\", ".") + extension}";
        if (!_cachedSprites.ContainsKey(fullFileName))
        {
            // Don't ask...
            using Stream stream = ResourceHelper.LoadResource<T>(spriteName + extension);
            using MemoryStream ms = new();
            stream.CopyTo(ms);
            byte[] imageData = ms.ToArray();
            Texture2D tex = new(1, 1, TextureFormat.RGBA32, false);
            ImageConversion.LoadImage(tex, imageData, true);
            tex.filterMode = FilterMode.Bilinear;
            _cachedSprites.Add(fullFileName, Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), new Vector2(.5f, .5f)));
        }
        return _cachedSprites[fullFileName];
    }
}