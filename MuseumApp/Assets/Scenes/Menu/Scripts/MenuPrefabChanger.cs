using UnityEngine;

public class MenuPrefabChanger : MonoBehaviour // Скрипт для смены игровых префабов внутри сцены Menu
{
    [Header("Массив всех префабов")]
    public GameObject[] _allPrefabs;
    public static GameObject[] allPrefabs;


    [Header("Место для префабов")]
    public GameObject _prefabPlace;
    public static GameObject prefabPlace;


    private void Awake()
    {
        // Ссылки на префабы
        allPrefabs = _allPrefabs;
        prefabPlace = _prefabPlace;

        //Instantiate(allPrefabs[0], prefabPlace.transform, false); // По дефолту создавать префаб игрового меню при заходе на сцену Game
    }

    public static void ChangePrefab(GameObject prefab) // Метод, реализующий смену префабов внутри сцены Game
    {
        Instantiate(prefab, prefabPlace.transform, false);
    }
}
