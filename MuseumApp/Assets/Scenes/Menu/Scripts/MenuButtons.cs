using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    public void MoveToPlay() // Перемещение на игровую сцену
    {
        SceneChanger.MoveToAnotherScene(1);
    }

    public void MoveToStudy() // Перемещение на учебную сцену
    {
        SceneChanger.MoveToAnotherScene(2);
    }

    public void MoveToSettings()
    {
        // Инициализация префаба настроек
    }
}
