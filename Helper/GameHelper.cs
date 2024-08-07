using HutongGames.PlayMaker;
using KorzUtils.Data;
using Modding;
using Modding.Delegates;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Linq;
using UnityEngine;

namespace KorzUtils.Helper;

/// <summary>
/// Provides functions for some more generic ingame behaviour
/// </summary>
public static class GameHelper
{
    #region Members

    private static float _waitCounter = 0f;
    private static Coroutine _queueRoutine;
    private static ConcurrentQueue<string> _queuedMessages = new();

    #endregion

    #region Methods

    /// <summary>
    /// Displays a message in the dream nail dialogue box used for enemy hits.
    /// </summary>
    /// <param name="message">The message to display.</param>
    public static void DisplayMessage(string message)
    {
        if (HeroController.instance == null)
        {
            LogHelper.Write("No hero detected. Message '{0}' will be disposed.", Enums.LogType.Warning);
            return;
        }
        _queuedMessages.Enqueue(message);
        if (_queueRoutine == null)
        {
            if (GameManager.instance == null)
            {
                GameObject dummy = new("Dummy");
                _queueRoutine = dummy.AddComponent<DummyComponent>().StartCoroutine(Queue(dummy));
            }
            else
                _queueRoutine = GameManager.instance.StartCoroutine(Queue());
        }
    }

    /// <summary>
    /// Hooks the translation process to overwrite the matching key with the given message, but only once.
    /// </summary>
    /// <param name="key">The key which text should be overwritten.</param>
    /// <param name="message">The text to send back to the game to display.</param>
    /// <param name="sheet">The sheet that has to be matched (in addition to the key). If <see langword="null"/>, the sheet will be ignored in the comparison.</param>
    public static void OneTimeMessage(string key, string message, string sheet = null)
    {
        LanguageGetProxy languageGetProxy = null;
        languageGetProxy = new((x, y, z) =>
        {
            if (x == key && (string.IsNullOrEmpty(sheet) || y == sheet))
            {
                ModHooks.LanguageGetHook -= languageGetProxy;
                return message;
            }
            return z;
        });
        ModHooks.LanguageGetHook += languageGetProxy;
    }

    private static IEnumerator Queue(GameObject executingObject = null)
    {
        while (_queuedMessages.Any())
        {
            // Wait for the hero to accept inputs.
            while (HeroController.instance?.acceptingInput != true)
                yield return null;
            try
            {
                PlayMakerFSM playMakerFSM = PlayMakerFSM.FindFsmOnGameObject(FsmVariables.GlobalVariables.GetFsmGameObject("Enemy Dream Msg").Value, "Display");
                playMakerFSM.FsmVariables.GetFsmInt("Convo Amount").Value = 1;
                playMakerFSM.FsmVariables.GetFsmString("Convo Title").Value = $"Korz_Util";
                LanguageGetProxy languageGetProxy = null;
                languageGetProxy = new((x, y, z) =>
                {
                    if (x == "Korz_Util_1")
                    {
                        ModHooks.LanguageGetHook -= languageGetProxy;
                        _queuedMessages.TryDequeue(out string message);
                        return message;
                    }
                    return z;
                });
                ModHooks.LanguageGetHook += languageGetProxy;
                playMakerFSM.SendEvent("DISPLAY ENEMY DREAM");
            }
            catch (Exception exception)
            {
                LogHelper.Write($"Failed to display message.", exception);
            }
            // Delay messages so they don't override each other.
            _waitCounter = 5f;
            while(_waitCounter > 0f)
            {
                _waitCounter -= Time.deltaTime;
                yield return null;
            }
        }
        // If this coroutine was run on a dummy object destroy it afterwards.
        if (executingObject != null)
            GameObject.Destroy(executingObject);
        _queueRoutine = null;
    }

    #endregion
}
