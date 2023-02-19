using ItemChanger;
using ItemChanger.Util;
using UnityEngine;

namespace KorzUtils.Helper;

/// <summary>
/// Provides functions regarding item changer items. (Requires ItemChanger)
/// <para>ItemChanger is not a dependency of this mod, keep that in mind.</para>
/// </summary>
public static class ItemHelper
{
    #region Methods

    /// <summary>
    /// Spawns a shiny at the passed position which contains the content of the placement.
    /// </summary>
    /// <param name="position"></param>
    /// <param name="placement"></param>
    public static void SpawnShiny(Vector3 position, AbstractPlacement placement)
    {
        Container container = Container.GetContainer(Container.Shiny);
        GameObject shiny = container.GetNewContainer(new ContainerInfo(container.Name, placement, FlingType.Everywhere));
        shiny.transform.position = position;
        shiny.SetActive(true);
    }

    /// <summary>
    /// Flings a shiny created from a placement.
    /// </summary>
    /// <param name="gameObject"></param>
    /// <param name="placement"></param>
    public static void FlingShiny(GameObject gameObject, AbstractPlacement placement)
    {
        Container container = Container.GetContainer(Container.Shiny);
        GameObject treasure = container.GetNewContainer(new ContainerInfo(container.Name, placement, FlingType.Everywhere));
        ShinyUtility.FlingShinyRandomly(treasure.LocateMyFSM("Shiny Control"));
        container.ApplyTargetContext(treasure, gameObject, 0f);
    }

    #endregion
}
