using System;
using UnityEngine;
using UnityEngine.UI;


public class AddPuzzlesToArr : MonoBehaviour
{
    [Header("Array for solved forms")]
    public GameObject[] puzzlePiecessolved;

    [Header("Array for unsolved puzzle pieces")]
    public GameObject[] puzzlePiecesunsolved;

    [Header("Array for sprites")]
    private Sprite[] _puzzlePiecesSprites;
    private static Sprite[] puzzlePiecesSprites = new Sprite[9];

    public static int activePuzzle;
    public int puzzlePhotosAmount;
   

    private void Awake()
    {
        activePuzzle = UnityEngine.Random.Range(1, puzzlePhotosAmount + 1);
        _puzzlePiecesSprites = Resources.LoadAll<Sprite>("ForSimplePuzzles/" + Convert.ToString(activePuzzle)); // Getting sprites from Resources folder

        for(int i = 0; i < _puzzlePiecesSprites.Length - 1; i++)                                                // Adding to static array only necessary
        {
            puzzlePiecesSprites[i] = _puzzlePiecesSprites[i];
        }
        

        for (int i = 0; i < puzzlePiecesSprites.Length; i++)
        {
            if (SettingsController.isTipOn)
            {
                puzzlePiecessolved[i].GetComponent<Image>().sprite = puzzlePiecesSprites[i]; // Adding puzzle sprite to every piece (Tips)
            }

            puzzlePiecesunsolved[i].GetComponent<Image>().sprite = puzzlePiecesSprites[i]; // Adding sprites to every piece
        }

    }

}
