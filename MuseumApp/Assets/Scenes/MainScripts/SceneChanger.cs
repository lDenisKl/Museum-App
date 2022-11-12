using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{


    private void Awake()
    {
    }
    
    public static void MoveToAnotherScene(int sceneNum, int activeSceneNum)
    {
        switch (activeSceneNum)
        {
            case 0:
                MenuPrefabChanger.ChangePrefab(MenuPrefabChanger.allPrefabs[0]);
                break;
            case 1:
                GamePrefabChanger.ChangePrefab(GamePrefabChanger.allPrefabs[5]);
                break;
            case 2:
                // Для сцены обучения смена на загрузочный префаб
                break;
        }
        SceneManager.LoadScene(sceneNum);
    }
}
