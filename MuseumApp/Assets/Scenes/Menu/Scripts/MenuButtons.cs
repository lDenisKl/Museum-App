using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour // Скрипт с методами, которые будут выполняться кнопками внутри сцены Menu
{
    public void MoveToPlay() // Перемещение на игровую сцену
    {
        MenuPrefabChanger.ChangePrefab(MenuPrefabChanger.allPrefabs[0]);
        SceneChanger.MoveToAnotherScene(1, 0);
        
    }

    public void MoveToStudy() // Перемещение на учебную сцену
    {
        SceneChanger.MoveToAnotherScene(2, 0);
    }

    public void MoveToSettings()
    {
        // Инициализация префаба настроек
    }
    
    public void Quit()
    {
        Application.Quit();
    }
}
