using Modding;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
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
    /// <param name="spriteName">The sprite name/path in the resource directory.</param>
    /// <param name="extension">The extension of the sprite.</param>
    [Obsolete("Deprecated. Use Create or CreateFromDisk instead.")]
    public static Sprite CreateSprite<T>(string spriteName,
        string extension = ".png") where T : Mod
    {
        string modName = typeof(T).Name;
        string fullFileName = $"{modName}.{spriteName.Replace("/", ".").Replace("\\", ".") + extension}";
        if (!_cachedSprites.ContainsKey(fullFileName))
        {
            using Stream stream = ResourceHelper.LoadResource<T>(spriteName + extension);
            LoadSprite(fullFileName, true, stream);
        }
        return _cachedSprites[fullFileName];
    }

    /// <summary>
    /// Creates a sprite from an embedded assembly resource.
    /// </summary>
    /// <typeparam name="T">The mod assembly to load from.</typeparam>
    /// <param name="spritePath">The full path into the assembly for the file.</param>
    /// <param name="cacheSprite">If true, if the sprite is already cached, the cached one is taken (if it does not exist, the new one will be cached) instead.</param>
    public static Sprite Create<T>(string spritePath,
        bool cacheSprite = true) where T : Mod
    {
        if (cacheSprite && CheckCache(spritePath, out Sprite sprite))
            return sprite;
        using Stream stream = ResourceHelper.Load<T>(spritePath);
        if (stream == null)
            return null;
        return LoadSprite(spritePath, cacheSprite, stream);
    }

    /// <summary>
    /// Creates a sprite from the file path.
    /// <para/>For the sake of simplicity the path always start in mod directory (set by parameter T)
    /// </summary>
    /// <typeparam name="T">The mod which assembly location should be used as the base path.</typeparam>
    /// <param name="spritePath">The relative path to the sprite. Format is [Location of assembly of T]/[<paramref name="spritePath"/>]</param>
    /// <param name="cacheSprite">If true, if the sprite is already cached, the cached one is taken (if it does not exist, the new one will be cached) instead.</param>
    public static Sprite CreateFromDisk<T>(string spritePath,
        bool cacheSprite = true) where T : Mod
    {
        string assemblyLocation = Path.GetDirectoryName(typeof(T).Assembly.Location);
        string fullPath = Path.Combine(assemblyLocation, spritePath).Replace('/', '\\');
        if (cacheSprite && CheckCache(fullPath, out Sprite sprite))
            return sprite;
        if (!File.Exists(fullPath))
            return null;
        using FileStream stream = System.IO.File.OpenRead(fullPath);
        return LoadSprite(fullPath, cacheSprite, stream);
    }

    /// <summary>
    /// Removes all sprites from the cache.
    /// </summary>
    public static void ClearCache() => _cachedSprites.Clear();

    #region Private Methods

    private static bool CheckCache(string spritePath, out Sprite sprite)
    {
        sprite = null;
        if (_cachedSprites.ContainsKey(spritePath))
        {
            sprite = _cachedSprites[spritePath];
            return true;
        }
        else
            return false;
    }

    private static Sprite LoadSprite(string spritePath,
        bool cacheSprite,
        Stream resourceStream)
    {
        using MemoryStream ms = new();
        resourceStream.CopyTo(ms);
        byte[] imageData = ms.ToArray();
        Texture2D tex = new(1, 1, TextureFormat.RGBA32, false);
        ImageConversion.LoadImage(tex, imageData, true);
        tex.filterMode = FilterMode.Bilinear;
        Sprite sprite = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), new Vector2(.5f, .5f));
        if (cacheSprite)
            _cachedSprites.Add(spritePath, sprite);
        return sprite;
    } 

    #endregion
}