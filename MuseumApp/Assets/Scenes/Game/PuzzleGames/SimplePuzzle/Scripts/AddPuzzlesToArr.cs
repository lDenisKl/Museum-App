using System;
using UnityEngine;
using UnityEngine.UI;


public class AddPuzzlesToArr : MonoBehaviour
{

   
    public GameObject[] puzzlePiecesunsolved; // ������ ����������� ������, ������� ��������� ��� �����
    Sprite[] _puzzlePiecesSprites; // ������ ��� �������� ������� ����������
    public static Sprite[] puzzlePiecesSprites; 
    public static AudioClip winAudio;


    private void Awake()
    {
        winAudio = Resources.Load("Sounds/WinAudio") as AudioClip;
        _puzzlePiecesSprites = Resources.LoadAll<Sprite>(Convert.ToString(UnityEngine.Random.Range(1, 11))); // ���������� ������� ��������� ���������� ����������� �� ����� Resources
        puzzlePiecesSprites = _puzzlePiecesSprites;

        for (int i = 0; i < puzzlePiecesSprites.Length; i++)
        {
            puzzlePiecesunsolved[i].GetComponent<Image>().sprite = puzzlePiecesSprites[i]; // ������������ ������� ����� ������ ��������
        }

    }

}
