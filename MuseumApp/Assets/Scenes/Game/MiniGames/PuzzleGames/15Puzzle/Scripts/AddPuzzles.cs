using System;
using UnityEngine;
using UnityEngine.UI;

public class AddPuzzles : MonoBehaviour
{
    public GameObject[] _puzzleButtons; // ������ ��� �������
    public static GameObject[] puzzleButtons;

    Sprite[] _puzzlePiecesSprites; // ������ ��� �������� ������� ����������
    public static Sprite[] puzzlePiecesSprites;

    public static GameObject[] puzzleButtonsSolved;
    public Transform puzzlePlace;
    public GameObject button;
    public GameObject _tipImage;
    public static GameObject tipImage;
    public static AudioClip winAudio;

    private void Awake()
    {
        winAudio = Resources.Load("Sounds/WinAudio") as AudioClip;
        _puzzlePiecesSprites = Resources.LoadAll<Sprite>("100"); // ���������� ������� ��������� ���������� ����������� �� ����� Resources
        puzzlePiecesSprites = _puzzlePiecesSprites;
        tipImage = _tipImage;
        puzzleButtons = _puzzleButtons;
        puzzleButtonsSolved = puzzleButtons;

        for (int j = 0; j < 16; j++)
        {
            var go = Instantiate(button, puzzlePlace, false);
            puzzleButtons[j] = go;
            go.GetComponent<Image>().sprite = puzzlePiecesSprites[j];
        }
        puzzleButtons[15].GetComponent<Image>().sprite = null;

    }
}
