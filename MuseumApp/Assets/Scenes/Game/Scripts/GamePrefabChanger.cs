using UnityEngine;

public class GamePrefabChanger : MonoBehaviour // Скрипт для смены игровых префабов внутри сцены Game
{
    
    public GameObject _gameMenuPrefab;
    public static GameObject gameMenuPrefab;
    
    public GameObject _puzzleMenuPrefab;
    public static GameObject puzzleMenuPrefab;

    public GameObject _simplePuzzleGamePrefab;
    public static GameObject simplePuzzleGamePrefab;

    public GameObject _winPuzzleGameParticle;
    public static GameObject winPuzzleGameParticle;
    
    public GameObject _winDescription1;
    public static GameObject winDescription1;
    
    public GameObject _menuPrefab;
    public static GameObject menuPrefab;

    public GameObject _prefabPlace;
    public static GameObject prefabPlace;


    private void Awake()
    {
        // Ссылки на префабы
        menuPrefab = _menuPrefab;
        winDescription1 = _winDescription1;
        winPuzzleGameParticle = _winPuzzleGameParticle;
        gameMenuPrefab = _gameMenuPrefab;
        puzzleMenuPrefab = _puzzleMenuPrefab;
        simplePuzzleGamePrefab = _simplePuzzleGamePrefab;
        prefabPlace = _prefabPlace;

        Instantiate(gameMenuPrefab, prefabPlace.transform, false); // По дефолту создавать префаб игрового меню при заходе на сцену Game
    }

    public static void ChangePrefab(GameObject prefab) // Метод, реализующий смену префабов внутри сцены Game
    {
            Instantiate(prefab, prefabPlace.transform, false);
    }
}
