using UnityEngine;
using static MenuPrefabChanger; // Connecting prefab changing script

public class SceneStartMenu : MonoBehaviour
{
    private void Awake()
    {
        // Check settings values from PlayerPrefs and set needed values
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
        
        ChangePrefab(allPrefabs[2]); // Instantiate default menu form
        DBManager.GetSights();

        var loading = Instantiate(allPrefabs[0], prefabPlace.transform, false); // Instantiate loading image
    }
}
