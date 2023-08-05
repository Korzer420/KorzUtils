using KorzUtils.Data;
using System;
using System.Collections;
using UnityEngine;

namespace KorzUtils.Helper;

/// <summary>
/// Provides useful function for working with coroutines.
/// </summary>
public static class CoroutineHelper
{
    #region Wait Frames

    /// <summary>
    /// Wraps an action to be executed after a frame delay.
    /// </summary>
    /// <param name="action">The action to be executed.</param>
    /// <param name="framesToWait">The amount of frames that should be waited before the action is executed.</param>
    public static IEnumerator WaitFrames(Action action, int framesToWait = 1)
    {
        for (int i = 0; i < framesToWait; i++)
            yield return null;
        action?.Invoke();
    }

    /// <summary>
    /// Wraps an action to be executed after a frame delay.
    /// </summary>
    /// <param name="action">The action to be executed.</param>
    /// <param name="value">The value that should be passed to the action.</param>
    /// <param name="framesToWait">The amount of frames that should be waited before the action is executed.</param>
    public static IEnumerator WaitFrames<T>(Action<T> action, T value, int framesToWait = 1)
    {
        for (int i = 0; i < framesToWait; i++)
            yield return null;
        action?.Invoke(value);
    }

    /// <summary>
    /// Wraps an action to be executed after a frame delay on an independed behaviour. The created GameObject is disposed afterwards.
    /// </summary>
    /// <param name="action">The action to be executed.</param>
    /// <param name="persistentBetweenScenes">If <see langword="true"/>, the object on which the coroutine is executed will not be interrupted by a scene transition.</param>
    /// <param name="framesToWait">The amount of frames that should be waited before the action is executed.</param>
    public static void WaitFrames(Action action, bool persistentBetweenScenes, int framesToWait = 1)
    {
        GameObject dummy = new("Dummy");
        if (persistentBetweenScenes)
            GameObject.DontDestroyOnLoad(dummy);
        dummy.AddComponent<DummyComponent>().StartCoroutine(WaitFrames(() =>
        {
            action?.Invoke();
            GameObject.Destroy(dummy);
        }, framesToWait));
    }

    /// <summary>
    /// Wraps an action to be executed after a frame delay on an independed behaviour. The created GameObject is disposed afterwards.
    /// </summary>
    /// <param name="action">The action to be executed.</param>
    /// <param name="value">The value that should be passed to the action.</param>
    /// <param name="persistentBetweenScenes">If <see langword="true"/>, the object on which the coroutine is executed will not be interrupted by a scene transition.</param>
    /// <param name="framesToWait">The amount of frames that should be waited before the action is executed.</param>
    public static void WaitFrames<T>(Action<T> action, T value, bool persistentBetweenScenes, int framesToWait = 1)
    {
        GameObject dummy = new("Dummy");
        if (persistentBetweenScenes)
            GameObject.DontDestroyOnLoad(dummy);
        dummy.AddComponent<DummyComponent>().StartCoroutine(WaitFrames(() =>
        {
            try
            {
                action?.Invoke(value);
            }
            catch (Exception exception)
            {
                LogHelper.Write("Failed to execute action: ", exception);
            }
            GameObject.Destroy(dummy);
        }, framesToWait));
    }

    #endregion

    #region Wait for Hero

    /// <summary>
    /// Executes an action after the player has regained control.
    /// </summary>
    /// <param name="action">The action to executed after the player has regained control.</param>
    public static IEnumerator WaitForHero(Action action) => WaitUntil(action, () => HeroController.instance?.acceptingInput == true);

    /// <summary>
    /// Executes an action after the player has regained control.
    /// </summary>
    /// <param name="action">The action to executed after the player has regained control.</param>
    /// <param name="persistentBetweenScenes"></param>
    public static void WaitForHero(Action action, bool persistentBetweenScenes)
        => WaitUntil(action, () => HeroController.instance?.acceptingInput == true, persistentBetweenScenes);

    /// <summary>
    /// Executes an action after the player has regained control.
    /// </summary>
    /// <param name="action">The action to executed after the player has regained control.</param>
    /// <param name="value"></param>
    public static IEnumerator WaitForHero<T>(Action<T> action, T value) => WaitUntil(action, value, () => HeroController.instance?.acceptingInput == true);

    /// <summary>
    /// Executes an action after the player has regained control.
    /// </summary>
    /// <param name="action">The action to executed after the player has regained control.</param>
    /// <param name="value"></param>
    /// <param name="persistentBetweenScenes"></param>
    public static void WaitForHero<T>(Action<T> action, T value, bool persistentBetweenScenes)
        => WaitUntil(action, value, () => HeroController.instance?.acceptingInput == true, persistentBetweenScenes);

    #endregion

    #region WaitUntil

    public static IEnumerator WaitUntil(Action action, Func<bool> waitFunction)
    {
        yield return new WaitUntil(waitFunction);
        action?.Invoke();
    }

    public static void WaitUntil(Action action, Func<bool> waitFunction, bool persistentBetweenScenes)
    {
        GameObject dummy = new("Dummy");
        if (persistentBetweenScenes)
            GameObject.DontDestroyOnLoad(dummy);
        dummy.AddComponent<DummyComponent>().StartCoroutine(WaitUntil(() =>
        {
            action?.Invoke();
            GameObject.Destroy(dummy);
        }, waitFunction));
    }

    public static IEnumerator WaitUntil<T>(Action<T> action, T value, Func<bool> waitFunction)
    {
        yield return new WaitUntil(waitFunction);
        action?.Invoke(value);
    }

    public static void WaitUntil<T>(Action<T> action, T value, Func<bool> waitFunction, bool persistentBetweenScenes)
    {
        GameObject dummy = new("Dummy");
        if (persistentBetweenScenes)
            GameObject.DontDestroyOnLoad(dummy);
        dummy.AddComponent<DummyComponent>().StartCoroutine(WaitUntil(() =>
        {
            action?.Invoke(value);
            GameObject.Destroy(dummy);
        }, waitFunction));
    }

    #endregion
}
