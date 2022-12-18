using UnityEngine;

public class SceneStart : MonoBehaviour
{
    private void Awake()
    {
        AudioListener.volume = SettingsController.volume;                                                           // Set volume from settings
        var loading = Instantiate(GamePrefabChanger.allPrefabs[5], GamePrefabChanger.prefabPlace.transform, false); // Set loading picture                                            // Destroy loading picture after 0.5 seconds
    }
}
