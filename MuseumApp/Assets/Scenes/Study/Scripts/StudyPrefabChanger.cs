using UnityEngine;

public class StudyPrefabChanger : MonoBehaviour
{
    [Header("Array for all prefabs")]
    public GameObject[] _allPrefabs;
    public static GameObject[] allPrefabs;
    
    [Header("Array for article prefabs")]
    public GameObject[] _articlePrefabs;
    public static GameObject[] articlePrefabs;

    [Header("Prefab place")]
    public GameObject _prefabPlace;
    public static GameObject prefabPlace;


    private void Awake()
    {
        // Ссылки на префабы
        articlePrefabs = _articlePrefabs;
        allPrefabs = _allPrefabs;
        prefabPlace = _prefabPlace;

        Instantiate(allPrefabs[0], prefabPlace.transform, false); // По дефолту создавать префаб игрового меню при заходе на сцену Game
    }

    public static void ChangePrefab(GameObject prefab) // Метод, реализующий смену префабов внутри сцены Game
    {
        Instantiate(prefab, prefabPlace.transform, false);
    }
}
