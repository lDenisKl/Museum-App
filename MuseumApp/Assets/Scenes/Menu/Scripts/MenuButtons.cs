using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    public static void DestroyAll() // Method for destroying all objects on the scene
    {
        for (int i = 0; i < MenuPrefabChanger.prefabPlace.transform.childCount; i++)
        {
            Destroy(MenuPrefabChanger.prefabPlace.transform.GetChild(i).gameObject);
        }
    }

    public void MoveToPlay() // Move to Play scene
    {
        MenuPrefabChanger.ChangePrefab(MenuPrefabChanger.allPrefabs[0]);
        SceneChanger.MoveToAnotherScene(1, 0);
    }

    public void MoveToAnotherPrefab(int number) // Set another prefab
    {
        DestroyAll();
        MenuPrefabChanger.ChangePrefab(MenuPrefabChanger.allPrefabs[number]);
    }

    public void MoveToStudy() // Move to Study scene
    {
        MenuPrefabChanger.ChangePrefab(MenuPrefabChanger.allPrefabs[0]);
        SceneChanger.MoveToAnotherScene(2, 0);
    }
    
    public void SwitchTips() // Method for swiching tips with toggle
    {
        if (SettingsController.tipToggle1.isOn)
        {
            SettingsController.isTipOn = false;
            PlayerPrefs.SetInt("tip", 0);
        }
        else
        {
            SettingsController.isTipOn = true;
            PlayerPrefs.SetInt("tip", 1);
        }
    }

    public void ControllVolume() // Method, controlling volume
    {
        SettingsController.volume = SettingsController.volumeSlider.value; // Getting value from toogle and setting it in volume variable
        AudioListener.volume = SettingsController.volume;                  // Setting audiolistener volume
        PlayerPrefs.SetFloat("volume", SettingsController.volume);         // Saving volume variable
    }

    public void Quit()
    {
        Application.Quit();
    }
}
