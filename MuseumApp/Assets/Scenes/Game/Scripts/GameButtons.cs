using UnityEngine;

public class GameButtons : MonoBehaviour // Скрипт с методами, которые будут выполняться кнопками
{

    public void MoveToSimplePuzzleGame()
    {
        GamePrefabChanger.ChangePrefab(GamePrefabChanger.simplePuzzleGamePrefab);
        Destroy(gameObject);
    }

    public void MoveToGameMenu()
    {
        GamePrefabChanger.ChangePrefab(GamePrefabChanger.gameMenuPrefab);
        Destroy(gameObject);
    }
    
    public void MoveToMainMenu()
    {
        SceneChanger.MoveToAnotherScene(0);
    }
}
