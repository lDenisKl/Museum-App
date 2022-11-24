using UnityEngine;

public class MenuButtons : MonoBehaviour // Скрипт с методами, которые будут выполняться кнопками внутри сцены Menu
{
    public static void DestroyAll()
    {
        for (int i = 0; i < MenuPrefabChanger.prefabPlace.transform.childCount; i++)
        {
            Destroy(MenuPrefabChanger.prefabPlace.transform.GetChild(i).gameObject);
        }
    }
    public void MoveToPlay() // Перемещение на игровую сцену
    {
        MenuPrefabChanger.ChangePrefab(MenuPrefabChanger.allPrefabs[0]);
        SceneChanger.MoveToAnotherScene(1, 0);
    }

    public void MoveToAnotherPrefab(int number)
    {
        DestroyAll();
        MenuPrefabChanger.ChangePrefab(MenuPrefabChanger.allPrefabs[number]);
    }

    public void MoveToStudy() // Перемещение на учебную сцену
    {
        SceneChanger.MoveToAnotherScene(2, 0);
    }

    public void MoveToSettings()
    {
        DestroyAll();
        MenuPrefabChanger.ChangePrefab(MenuPrefabChanger.allPrefabs[1]);
    }
    
    public void SwitchTips()
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

    public void ControllVolume()
    {
        SettingsController.volume = SettingsController.volumeSlider.value;
        AudioListener.volume = SettingsController.volume;
        PlayerPrefs.SetFloat("volume", SettingsController.volume);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
