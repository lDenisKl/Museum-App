using UnityEngine;

public class GameButtons : MonoBehaviour // Скрипт с методами, которые будут выполняться кнопками
{

    public void MoveToSimplePuzzleGame()
    {
        DestroyAll();
        GamePrefabChanger.ChangePrefab(GamePrefabChanger.simplePuzzleGamePrefab);
    }

    public void MoveToFifteenPuzzleGame()
    {
        DestroyAll();
        GamePrefabChanger.ChangePrefab(GamePrefabChanger.fifteenPuzzleGamePrefab);
    }

    public void MoveToGameMenu()
    {
        DestroyAll();
        GamePrefabChanger.ChangePrefab(GamePrefabChanger.gameMenuPrefab);
    }
    
    public void MoveToMainMenu()
    {
        SceneChanger.MoveToAnotherScene(0);
        Destroy(gameObject);
    }
    public static void DestroyAll()
    {
        for (int i = 0; i < GamePrefabChanger.prefabPlace.transform.childCount; i++)
        {
            Destroy(GamePrefabChanger.prefabPlace.transform.GetChild(i).gameObject);
        }
    } 
}
