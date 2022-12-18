using UnityEngine;

public class MenuPrefabChanger : MonoBehaviour
{
    [Header("Array for all prefabs")]
    public GameObject[] _allPrefabs;
    public static GameObject[] allPrefabs;

    [Header("Prefab place")]
    public GameObject _prefabPlace;
    public static GameObject prefabPlace;


    private void Awake()
    {
        allPrefabs = _allPrefabs;
        prefabPlace = _prefabPlace;

        ChangePrefab(allPrefabs[0]); // Set default prefab (Main Menu)
    }

    public static void ChangePrefab(GameObject prefab)
    {
        Instantiate(prefab, prefabPlace.transform, false);
    }
}
