using UnityEngine;

public class StudyPrefabChanger : MonoBehaviour
{
    [Header("Array for all prefabs")]
    public GameObject[] _allPrefabs;
    public static GameObject[] allPrefabs;
    
    [Header("Article prefab")]
    public GameObject _articlePrefab;
    public static GameObject articlePrefab;

    [Header("Prefab place")]
    public GameObject _prefabPlace;
    public static GameObject prefabPlace;


    private void Awake()
    {
        articlePrefab = _articlePrefab;
        allPrefabs = _allPrefabs;
        prefabPlace = _prefabPlace;

        ChangePrefab(allPrefabs[0]); // Set default prefab (Game Menu)
    }

    public static void ChangePrefab(GameObject prefab) // Method for changing prefab
    {
        Instantiate(prefab, prefabPlace.transform, false);
    }
}
