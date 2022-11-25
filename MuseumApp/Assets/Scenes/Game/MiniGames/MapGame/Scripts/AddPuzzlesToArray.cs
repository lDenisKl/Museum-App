using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPuzzlesToArray : MonoBehaviour
{

    [Header("Массив форм пазлов")]
    public static GameObject[] puzzlePiecessolved;     // Массив собранных пазлов, которые находятся в форме
    public GameObject[] _puzzlePiecessolved;
    [Header("Массив пазлов")]
    public static GameObject[] puzzlePiecesunsolved;   // Массив несобранных пазлов, которые находятся вне формы
    public GameObject[] _puzzlePiecesunsolved;

    private void Awake()
    {
        puzzlePiecessolved = _puzzlePiecessolved;
        puzzlePiecesunsolved = _puzzlePiecesunsolved;
    }
}
