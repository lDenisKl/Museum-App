using System;
using UnityEngine;
using UnityEngine.UI;


public class AddPuzzlesToArr : MonoBehaviour
{

   
    public GameObject[] puzzlePiecesunsolved; // ������ ����������� ������, ������� ��������� ��� �����
    Sprite[] _puzzlePiecesSprites; // ��������� ������ �������� ������� ����������
    public static Sprite[] puzzlePiecesSprites = new Sprite[9];  // ������ �������� ������� ���������� ��� �������������
    public static AudioClip winAudio; // ���� ������


    private void Awake()
    {
        winAudio = Resources.Load("Sounds/WinAudio") as AudioClip; // �������� ����� ������ �� ����� Resources
        _puzzlePiecesSprites = Resources.LoadAll<Sprite>("7");//Convert.ToString(UnityEngine.Random.Range(1, 11))); // ���������� ������� ��������� ���������� ����������� �� ����� Resources
        for(int i = 0; i < _puzzlePiecesSprites.Length - 1; i++) // ���������� ������������ ������� �������� ���������� ��� ������ ��� ����������(��������� ����������)
        {
            puzzlePiecesSprites[i] = _puzzlePiecesSprites[i];
        }
        

        for (int i = 0; i < puzzlePiecesSprites.Length; i++)
        {
            puzzlePiecesunsolved[i].GetComponent<Image>().sprite = puzzlePiecesSprites[i]; // ������������ ������� ����� ������ ��������
        }

    }

}
