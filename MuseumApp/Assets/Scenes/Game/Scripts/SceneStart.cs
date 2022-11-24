
using UnityEngine;

public class SceneStart : MonoBehaviour
{
    private void Awake()
    {
        AudioListener.volume = SettingsController.volume;
        var loading = Instantiate(GamePrefabChanger.allPrefabs[5], GamePrefabChanger.prefabPlace.transform, false);
        Destroy(loading, 1f);
    }
}
