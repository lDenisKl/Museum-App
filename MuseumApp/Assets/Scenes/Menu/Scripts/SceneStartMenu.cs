
using UnityEngine;

public class SceneStartMenu : MonoBehaviour
{
    private void Awake()
    {
        var loading = Instantiate(MenuPrefabChanger.allPrefabs[0], MenuPrefabChanger.prefabPlace.transform, false);
        Destroy(loading, 0.5f);
        MenuPrefabChanger.ChangePrefab(MenuPrefabChanger.allPrefabs[2]);
    }
}
