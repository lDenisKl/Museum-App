using UnityEngine;

public class GamePrefabChanger : MonoBehaviour // ������ ��� ����� ������� �������� ������ ����� Game
{
    
    public GameObject _gameMenuPrefab;
    public static GameObject gameMenuPrefab;
    
    public GameObject _puzzleMenuPrefab;
    public static GameObject puzzleMenuPrefab;

    public GameObject _simplePuzzleGamePrefab;
    public static GameObject simplePuzzleGamePrefab;

    public GameObject _winPuzzleGameParticle;
    public static GameObject winPuzzleGameParticle;
    
    public GameObject _winDescription1;
    public static GameObject winDescription1;
    
    public GameObject _menuPrefab;
    public static GameObject menuPrefab;

    public GameObject _prefabPlace;
    public static GameObject prefabPlace;


    private void Awake()
    {
        // ������ �� �������
        menuPrefab = _menuPrefab;
        winDescription1 = _winDescription1;
        winPuzzleGameParticle = _winPuzzleGameParticle;
        gameMenuPrefab = _gameMenuPrefab;
        puzzleMenuPrefab = _puzzleMenuPrefab;
        simplePuzzleGamePrefab = _simplePuzzleGamePrefab;
        prefabPlace = _prefabPlace;

        Instantiate(gameMenuPrefab, prefabPlace.transform, false); // �� ������� ��������� ������ �������� ���� ��� ������ �� ����� Game
    }

    public static void ChangePrefab(GameObject prefab) // �����, ����������� ����� �������� ������ ����� Game
    {
            Instantiate(prefab, prefabPlace.transform, false);
    }
}
