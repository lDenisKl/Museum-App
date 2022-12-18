using UnityEngine;

public class GamePrefabChanger : MonoBehaviour // ������ ��� ����� ������� �������� ������ ����� Game
{
    
    [Header("Array for win description")]
    public GameObject[] _winPrefabs;
    public static GameObject[] winPrefabs; 
    
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
        // ������ �� �������
        allPrefabs = _allPrefabs;
        mapPuzzlePrefabs = _mapPuzzlePrefabs;
        winPrefabs = _winPrefabs;
        prefabPlace = _prefabPlace;

        Instantiate(allPrefabs[0], prefabPlace.transform, false); // �� ������� ��������� ������ �������� ���� ��� ������ �� ����� Game
    }

    public static void ChangePrefab(GameObject prefab) // �����, ����������� ����� �������� ������ ����� Game
    {
            Instantiate(prefab, prefabPlace.transform, false);
    }
}
