using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPuzzlesToArray : MonoBehaviour
{

    [Header("������ ���� ������")]
    public static GameObject[] puzzlePiecessolved;     // ������ ��������� ������, ������� ��������� � �����
    public GameObject[] _puzzlePiecessolved;
    [Header("������ ������")]
    public static GameObject[] puzzlePiecesunsolved;   // ������ ����������� ������, ������� ��������� ��� �����
    public GameObject[] _puzzlePiecesunsolved;

    private void Awake()
    {
        puzzlePiecessolved = _puzzlePiecessolved;
        puzzlePiecesunsolved = _puzzlePiecesunsolved;
    }
}
