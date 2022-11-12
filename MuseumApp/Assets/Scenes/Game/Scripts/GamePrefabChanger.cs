using UnityEngine;

public class GamePrefabChanger : MonoBehaviour // ������ ��� ����� ������� �������� ������ ����� Game
{
    [Header("������ �������� ��������")]
    public GameObject[] _winPrefabs;
    public static GameObject[] winPrefabs; 
    
    [Header("������ ���� ��������")]
    public GameObject[] _allPrefabs;
    public static GameObject[] allPrefabs;


    [Header("����� ��� ��������")]
    public GameObject _prefabPlace;
    public static GameObject prefabPlace;


    private void Awake()
    {
        // ������ �� �������
        allPrefabs = _allPrefabs;
        winPrefabs = _winPrefabs;
        prefabPlace = _prefabPlace;

        Instantiate(allPrefabs[0], prefabPlace.transform, false); // �� ������� ��������� ������ �������� ���� ��� ������ �� ����� Game
    }

    public static void ChangePrefab(GameObject prefab) // �����, ����������� ����� �������� ������ ����� Game
    {
            Instantiate(prefab, prefabPlace.transform, false);
    }
}
