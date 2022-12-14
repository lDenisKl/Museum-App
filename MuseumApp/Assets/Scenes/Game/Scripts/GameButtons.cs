using UnityEngine;

public class GameButtons : MonoBehaviour
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
        IsWin.solvedPuzzles = 0;
        IsMapWin.solvedMapPuzzles = 0;
        DestroyAll();
        GamePrefabChanger.ChangePrefab(GamePrefabChanger.allPrefabs[number]);
    }

    public void MoveToMapPuzzle()
    {
        DestroyAll();
        GamePrefabChanger.ChangePrefab(GamePrefabChanger.mapPuzzlePrefabs[Random.Range(0, 2)]);
    }
    
    public void PlayAgain()
    {
        if (GameObject.Find("SimplePuzzleGame(Clone)"))
        {
            IsWin.solvedPuzzles = 0;
            DestroyAll();
            GamePrefabChanger.ChangePrefab(GamePrefabChanger.allPrefabs[2]);
        }
        else if(GameObject.Find("15PuzzleGame(Clone)"))
        {
            DestroyAll();
            GamePrefabChanger.ChangePrefab(GamePrefabChanger.allPrefabs[3]);
        }
        else
        {
            MoveToMapPuzzle();
        }
        
    }

    public void MoveToMainMenu()
    {
        SceneChanger.MoveToAnotherScene(0, 1);
        Destroy(gameObject);
    }
   
}
