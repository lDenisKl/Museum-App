using System;
using UnityEngine;
using UnityEngine.UI;


public class AddPuzzlesToArr : MonoBehaviour
{
    [Header("������ ���� ������")]
    public GameObject[] puzzlePiecessolved;     // ������ ��������� ������, ������� ��������� � �����
    [Header("������ ������")]
    public GameObject[] puzzlePiecesunsolved;   // ������ ����������� ������, ������� ��������� ��� �����

    private Sprite[] _puzzlePiecesSprites;                        // ��������� ������ �������� ������� ����������
    private static Sprite[] puzzlePiecesSprites = new Sprite[9];  // ������ �������� ������� ���������� ��� �������������
   

    private void Awake()
    {
        _puzzlePiecesSprites = Resources.LoadAll<Sprite>("ForSimplePuzzles/" + Convert.ToString(UnityEngine.Random.Range(1, 14))); // ���������� ������� ��������� ���������� ����������� �� ����� Resources

        for(int i = 0; i < _puzzlePiecesSprites.Length - 1; i++) // ���������� ������������ ������� �������� ���������� ��� ������ ��� ����������(��������� ����������)
        {
            puzzlePiecesSprites[i] = _puzzlePiecesSprites[i];
        }
        

        for (int i = 0; i < puzzlePiecesSprites.Length; i++)
        {
            puzzlePiecessolved[i].GetComponent<Image>().sprite = puzzlePiecesSprites[i]; // ������������ ������� ����� ������ ��������
            puzzlePiecesunsolved[i].GetComponent<Image>().sprite = puzzlePiecesSprites[i]; // ������������ ������� ����� ������ ��������
        }

    }

}
