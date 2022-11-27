using UnityEngine;

public class GamePrefabChanger : MonoBehaviour // Скрипт для смены игровых префабов внутри сцены Game
{
    [Header("Array for win description for SimplePuzzle")]
    public GameObject[] _winPrefabs;
    public static GameObject[] winPrefabs; 
    
    [Header("Array for win description for 9Puzzle")]
    public GameObject[] _FifteenwinPrefabs;
    public static GameObject[] fifteenWinPrefabs;
    
    [Header("Array for win description for MapPuzzle")]
    public GameObject[] _mapWinPrefabs;
    public static GameObject[] mapWinPrefabs; 
    
    [Header("Array for MapPuzzles")]
    public GameObject[] _mapPuzzlePrefabs;
    public static GameObject[] mapPuzzlePrefabs; 
    
    [Header("Array for all prefabs")]
    public GameObject[] _allPrefabs;
    public static GameObject[] allPrefabs;

    [Header("Prefab place")]
    public GameObject _prefabPlace;
    public static GameObject prefabPlace;


    private void Awake()
    {
        // Ссылки на префабы
        allPrefabs = _allPrefabs;
        winPrefabs = _winPrefabs;
        fifteenWinPrefabs = _FifteenwinPrefabs;
        mapPuzzlePrefabs = _mapPuzzlePrefabs;
        mapWinPrefabs = _mapWinPrefabs;
        prefabPlace = _prefabPlace;

        Instantiate(allPrefabs[0], prefabPlace.transform, false); // По дефолту создавать префаб игрового меню при заходе на сцену Game
    }

    public static void ChangePrefab(GameObject prefab) // Метод, реализующий смену префабов внутри сцены Game
    {
            Instantiate(prefab, prefabPlace.transform, false);
    }
}
