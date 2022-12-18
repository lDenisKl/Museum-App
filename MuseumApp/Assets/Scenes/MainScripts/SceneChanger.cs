using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public static void MoveToAnotherScene(int sceneNum, int activeSceneNum) // Method for changing scene
    {
        switch (activeSceneNum)// Setting loading prefab
        {
            case 0:
                MenuPrefabChanger.ChangePrefab(MenuPrefabChanger.allPrefabs[0]);
                break;
            case 1:
                GamePrefabChanger.ChangePrefab(GamePrefabChanger.allPrefabs[5]);
                break;
            case 2:
                StudyPrefabChanger.ChangePrefab(StudyPrefabChanger.allPrefabs[1]);
                break;
        }
        SceneManager.LoadScene(sceneNum); // Move to another scene
    }
}
