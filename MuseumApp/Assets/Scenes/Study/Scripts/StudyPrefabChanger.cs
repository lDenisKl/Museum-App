using UnityEngine;

public class StudyPrefabChanger : MonoBehaviour
{
    [Header("Array for all prefabs")]
    public GameObject[] _allPrefabs;
    public static GameObject[] allPrefabs;
    
    [Header("Array for article prefabs")]
    public GameObject[] _articlePrefabs;
    public static GameObject[] articlePrefabs;

    [Header("Array for sight articles prefabs")]
    public GameObject[] _sightsPrefabs;
    public static GameObject[] sightsPrefabs;

    [Header("Prefab place")]
    public GameObject _prefabPlace;
    public static GameObject prefabPlace;


    private void Awake()
    {
        sightsPrefabs = _sightsPrefabs;
        articlePrefabs = _articlePrefabs;
        allPrefabs = _allPrefabs;
        prefabPlace = _prefabPlace;

        Instantiate(allPrefabs[0], prefabPlace.transform, false); // �� ������� ��������� ������ �������� ���� ��� ������ �� ����� Game
    }

    public static void ChangePrefab(GameObject prefab) // �����, ����������� ����� �������� ������ ����� Game
    {
        Instantiate(prefab, prefabPlace.transform, false);
    }
}
