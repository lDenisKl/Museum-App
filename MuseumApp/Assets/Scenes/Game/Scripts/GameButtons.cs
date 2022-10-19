
using UnityEngine;

public class GameButtons : MonoBehaviour
{
    public void MoveToSimplePuzzleGame()
    {
        //
        GamePrefabChanger.ChangePrefab(GamePrefabChanger.simplePuzzleGamePrefab);
        Destroy(gameObject);
    }
    public void MoveToGameMenu()
    {
        //
        GamePrefabChanger.ChangePrefab(GamePrefabChanger.gameMenuPrefab);
        Destroy(gameObject);
    }
}
