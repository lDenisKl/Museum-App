using System;
using UnityEngine;
using UnityEngine.UI;

public class AddPuzzles : MonoBehaviour
{
    [Header("Array for all buttons")]
    public GameObject[] _puzzleButtons;
    public static GameObject[] puzzleButtons;

    [Header("Array for pieces")]
    public Sprite[] _puzzlePiecesSprites;
    public static Sprite[] puzzlePiecesSprites;

    [Header("Photo-Tip")]
    public GameObject _tipImage;
    public static GameObject tipImage;

    [Header("Game Place")]
    public Transform puzzlePlace;

    [Header("Puzzle Piece Prefab")]
    public GameObject button;

    public static GameObject[] puzzleButtonsSolved;
    public static AudioClip winAudio; // Audio, plays on win
    public static int activePuzzle;

    private void Awake()
    {
        winAudio = Resources.Load("Sounds/WinAudio") as AudioClip;    // Geting win audioclip from Resources folder

        activePuzzle = UnityEngine.Random.Range(1, 6);
        _puzzlePiecesSprites = Resources.LoadAll<Sprite>("For9Puzzle/" + Convert.ToString(activePuzzle)); // Getting sprites from Resources folder

        puzzlePiecesSprites = _puzzlePiecesSprites;                   // Reference and object connection
        tipImage = _tipImage;
        puzzleButtons = _puzzleButtons;
        puzzleButtonsSolved = puzzleButtons;

        for (int j = 0; j < 9; j++)                                   // Adding puzzles to game place
        {
            var go = Instantiate(button, puzzlePlace, false);         // Puzzle piece creation
            puzzleButtons[j] = go;                                    // Adding piece to array
            go.GetComponent<Image>().sprite = puzzlePiecesSprites[j]; // Put sprite on piece
        }
        puzzleButtons[8].GetComponent<Image>().sprite = null;         // Making one piece empty

    }
}
