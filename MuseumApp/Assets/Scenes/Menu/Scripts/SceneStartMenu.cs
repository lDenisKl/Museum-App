
using UnityEngine;

public class SceneStartMenu : MonoBehaviour
{
    private void Awake()
    {
        var loading = Instantiate(MenuPrefabChanger.allPrefabs[0], MenuPrefabChanger.prefabPlace.transform, false);
        Destroy(loading, 1f);
    }
}
