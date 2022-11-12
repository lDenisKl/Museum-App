using UnityEngine;

public class MenuPrefabChanger : MonoBehaviour // ������ ��� ����� ������� �������� ������ ����� Menu
{
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
        prefabPlace = _prefabPlace;

        //Instantiate(allPrefabs[0], prefabPlace.transform, false); // �� ������� ��������� ������ �������� ���� ��� ������ �� ����� Game
    }

    public static void ChangePrefab(GameObject prefab) // �����, ����������� ����� �������� ������ ����� Game
    {
        Instantiate(prefab, prefabPlace.transform, false);
    }
}
