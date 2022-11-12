using UnityEngine;

public class GameButtons : MonoBehaviour // Скрипт с методами, которые будут выполняться кнопками
{
    public static void DestroyAll()
    {
        for (int i = 0; i < GamePrefabChanger.prefabPlace.transform.childCount; i++)
        {
            Destroy(GamePrefabChanger.prefabPlace.transform.GetChild(i).gameObject);
        }
    }

    public void MoveToAnotherPrefab(int number)
    {
        DestroyAll();
        GamePrefabChanger.ChangePrefab(GamePrefabChanger.allPrefabs[number]);
    }

    public void BackTo(int number)
    {
        DestroyAll();
        GamePrefabChanger.ChangePrefab(GamePrefabChanger.allPrefabs[number]);
    }
    
    public void PlayAgain()
    {
        if (GameObject.Find("SimplePuzzleGame(Clone)"))
        {
            DestroyAll();
            GamePrefabChanger.ChangePrefab(GamePrefabChanger.allPrefabs[2]);
        }
        else if(GameObject.Find("15PuzzleGame(Clone)"))
        {
            DestroyAll();
            GamePrefabChanger.ChangePrefab(GamePrefabChanger.allPrefabs[3]);
        }
        
    }

    public void MoveToMainMenu()
    {
        SceneChanger.MoveToAnotherScene(0, 1);
        Destroy(gameObject);
    }
   
}
