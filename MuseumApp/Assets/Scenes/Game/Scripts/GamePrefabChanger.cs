using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePrefabChanger : MonoBehaviour
{
    public GameObject _gameMenuPrefab;
    public static GameObject gameMenuPrefab;
    
    public GameObject _puzzleMenuPrefab;
    public static GameObject puzzleMenuPrefab;

    public GameObject _simplePuzzleGamePrefab;
    public static GameObject simplePuzzleGamePrefab;

    public GameObject _prefabPlace;
    public static GameObject prefabPlace;


    private void Awake()
    {

        gameMenuPrefab = _gameMenuPrefab;
        puzzleMenuPrefab = _puzzleMenuPrefab;
        simplePuzzleGamePrefab = _simplePuzzleGamePrefab;
        prefabPlace = _prefabPlace;

        Instantiate(gameMenuPrefab, prefabPlace.transform, false);
    }
    public static void ChangePrefab(GameObject prefab)
    {
            Instantiate(prefab, prefabPlace.transform, false);
    }
}
