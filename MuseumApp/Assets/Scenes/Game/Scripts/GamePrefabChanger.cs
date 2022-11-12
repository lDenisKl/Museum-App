using UnityEngine;

public class GamePrefabChanger : MonoBehaviour // Скрипт для смены игровых префабов внутри сцены Game
{
    [Header("Массив победных описаний")]
    public GameObject[] _winPrefabs;
    public static GameObject[] winPrefabs; 
    
    [Header("Массив всех префабов")]
    public GameObject[] _allPrefabs;
    public static GameObject[] allPrefabs;


    [Header("Место для префабов")]
    public GameObject _prefabPlace;
    public static GameObject prefabPlace;


    private void Awake()
    {
        SetLoadingPicture();
        System.Threading.Thread.Sleep(3000);
        GameButtons.DestroyAll();
        // Ссылки на префабы
        allPrefabs = _allPrefabs;
        winPrefabs = _winPrefabs;
        prefabPlace = _prefabPlace;

        Instantiate(allPrefabs[0], prefabPlace.transform, false); // По дефолту создавать префаб игрового меню при заходе на сцену Game
    }

    public static void ChangePrefab(GameObject prefab) // Метод, реализующий смену префабов внутри сцены Game
    {
            Instantiate(prefab, prefabPlace.transform, false);
    }

    public static void SetLoadingPicture()
    {
        ChangePrefab(allPrefabs[5]);
        
    }
}
