using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace KorzUtils.Helper;

/// <summary>
/// Provides useful methods relating to sounds/audio
/// </summary>
public static class SoundHelper
{
    private static readonly Dictionary<string, AudioClip> _cachedSounds = [];

    /// <summary>
    /// Creates a new <see cref="AudioClip"/> from the stream of an uncompressed 16-bit .wav (PCM) file.
    /// </summary>
    /// <param name="wavStream">The full stream containing the .wav file.</param>
    /// <param name="clipName">The name of the clip.</param>
    /// <param name="cacheSound">If true, the cache will be searched for a clip with the same name to return. If not present, the created sound will be cached instead.</param>
    public static AudioClip CreateSound(Stream wavStream, string clipName, bool cacheSound = true)
    {
        if (cacheSound && _cachedSounds.TryGetValue(clipName, out AudioClip cachedClip))
            return cachedClip;
        using BinaryReader reader = new(wavStream);
        // Read the wav header and skip unimportant data for us.
        // "RIFF" tag
        reader.ReadChars(4);
        // Chunk size
        reader.ReadInt32();
        // "WAVE" tag
        reader.ReadChars(4); 
        // "fmt " tag
        reader.ReadChars(4);
        // Subchunk
        reader.ReadInt32();
        // Audio format
        reader.ReadInt16();

        short numChannels = reader.ReadInt16();
        int sampleRate = reader.ReadInt32();
        // Byte rate
        reader.ReadInt32();
        // Block align
        reader.ReadInt16();
        short bitsPerSample = reader.ReadInt16();

        // If fact chunk exist, we ignore it. (It's not relevant for us)
        if (reader.PeekChar() == 'f')
        {
            string factChunk = new(reader.ReadChars(4));
            int factChunkSize = reader.ReadInt32();
            reader.ReadBytes(factChunkSize);
        }

        // Look for the audio data.
        string dataStartTag = new(reader.ReadChars(4));
        while (!string.Equals(dataStartTag, "data"))
        {
            int skipSize = reader.ReadInt32();
            reader.ReadBytes(skipSize);
            dataStartTag = new(reader.ReadChars(4));
        }

        int dataSize = reader.ReadInt32();
        byte[] rawData = reader.ReadBytes(dataSize);
        // Unity expects values between -1f and 1f. Therefore we need to convert it.
        int sampleCount = dataSize / (bitsPerSample / 8);
        float[] audioData = new float[sampleCount];
        float normalizeValue = short.MaxValue + 1;
        if (bitsPerSample == 16)
            for (int i = 0; i < sampleCount; i++)
            {
                short sample = BitConverter.ToInt16(rawData, i * 2);
                audioData[i] = sample / normalizeValue; 
            }
        else
            throw new NotSupportedException("Unsupported audio file.");
        AudioClip clip = AudioClip.Create(clipName, sampleCount / numChannels, numChannels, sampleRate, false);
        clip.SetData(audioData, 0);
        if (cacheSound)
            _cachedSounds.Add(clipName, clip);
        return clip;
    }
}
