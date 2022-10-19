using System;
using UnityEngine;
using UnityEngine.UI;


public class AddPuzzlesToArr : MonoBehaviour
{

   
    public GameObject[] puzzlePiecesunsolved; // ������ ����������� ������, ������� ��������� ��� �����
    Sprite[] _puzzlePiecesSprites; // ������ ��� �������� ������� ����������
    static Sprite[] puzzlePiecesSprites; 

    private void Awake()
    {
        _puzzlePiecesSprites = Resources.LoadAll<Sprite>(Convert.ToString(UnityEngine.Random.Range(1, 5))); // ���������� ������� ��������� ���������� ����������� �� ����� Resources
        puzzlePiecesSprites = _puzzlePiecesSprites;

        for (int i = 0; i < puzzlePiecesSprites.Length; i++)
        {
            puzzlePiecesunsolved[i].GetComponent<Image>().sprite = puzzlePiecesSprites[i]; // ������������ ������� ����� ������ ��������
        }

    }

}
