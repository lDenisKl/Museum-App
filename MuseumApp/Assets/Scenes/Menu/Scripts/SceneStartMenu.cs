
using UnityEngine;

public class SceneStartMenu : MonoBehaviour
{
    private void Awake()
    {
        if (PlayerPrefs.HasKey("tip") && PlayerPrefs.GetInt("tip") == 1)
        {
            SettingsController.isTipOn = true;
        }
        else if (PlayerPrefs.HasKey("tip") && PlayerPrefs.GetInt("tip") == 0)
        {
            SettingsController.isTipOn = false;
        }

        if (PlayerPrefs.HasKey("volume"))
        {
            SettingsController.volume = PlayerPrefs.GetFloat("volume");
            AudioListener.volume = PlayerPrefs.GetFloat("volume");
        }
        MenuPrefabChanger.ChangePrefab(MenuPrefabChanger.allPrefabs[2]);
        var loading = Instantiate(MenuPrefabChanger.allPrefabs[0], MenuPrefabChanger.prefabPlace.transform, false);
        Destroy(loading, 1f);
    }
}
