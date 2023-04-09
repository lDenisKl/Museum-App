using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class AddPuzzles : MonoBehaviour
{
    [Header("Array for all buttons")]
    public GameObject[] _puzzleButtons;
    public static GameObject[] puzzleButtons;

    [Header("Array for pieces")]
    public static Sprite[] _puzzlePiecesSprites = new Sprite[9];
    public static Sprite[] puzzlePiecesSprites = new Sprite[9];

    [Header("Photo-Tip")]
    public GameObject _tipImage;
    public static GameObject tipImage;

    [Header("Game Place")]
    public Transform puzzlePlace;

    [Header("Puzzle Piece Prefab")]
    public GameObject button;

    public static GameObject[] puzzleButtonsSolved;
    public static AudioClip winAudio; // Audio, plays on win

    public static Article activePuzzle;
    public static int puzzlePhotosAmount;
    private int[] gg = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 0}; // Indexes for pictures
    private static int prevId;


    private void Awake()
    {
        tipImage = _tipImage;
        puzzleButtons = _puzzleButtons;
        puzzleButtonsSolved = puzzleButtons;


        //puzzlePhotosAmount = (new DirectoryInfo("Assets/Resources/For9Puzzles").GetFiles("*.jpg")).Length; // Getting amount of pictures for 9Puzzle
        winAudio = Resources.Load("Sounds/Games/WinAudio") as AudioClip;    // Geting win audioclip from Resources folder

        int puzzId = UnityEngine.Random.Range(0, Article.sightArticles.Count);

        activePuzzle = Article.sightArticles[puzzId]; // Getting active sight object
        while (activePuzzle.PhotoPath.Contains("Simple") || puzzId == prevId)
        {
            puzzId = UnityEngine.Random.Range(0, Article.sightArticles.Count);
            activePuzzle = Article.sightArticles[puzzId];
        }
        prevId = puzzId;

        puzzlePiecesSprites = Resources.LoadAll<Sprite>(activePuzzle.PhotoPath); // Getting pieces

        int[] newArr = new int[9];
        while (true)
        {
            newArr = Shuffle(gg);
            if (isSolvable(newArr))
            {
                break;
            }
        }
        GgToPics(newArr);
        for (int j = 0; j < 9; j++)                                   // Adding puzzles to game place
        {
            var go = Instantiate(button, puzzlePlace, false);         // Puzzle piece creation
            puzzleButtons[j] = go;                                    // Adding piece to array
            go.GetComponent<Image>().sprite = _puzzlePiecesSprites[j]; // Put sprite on piece
        }
        tipImage.GetComponent<Image>().preserveAspect = true;
    }

    private void GgToPics(int[] gg) // Set pictures in needed sequence
    {
        for (int i = 0; i < _puzzlePiecesSprites.Length-1; i++)
        {
            _puzzlePiecesSprites[i] = puzzlePiecesSprites[gg[i]-1];
        }
    }

    private bool isSolvable(int[] gg) // Check if position is solvable
    {
        int summ = 0;
        for (int i = 0; i < gg.Length - 1; i++)
        {
            int value1 = gg[i];
            for (int j = i + 1; j < gg.Length - 1; j++)
            {
                int value2 = gg[j];
                if (value1 < value2)
                {
                    summ += 1;
                }
                summ += 3;
            }
        }
        if (summ % 2 == 0)
        {
            return true;
        }
        return false;
    } 

    private int[] Shuffle(int[] gg) // Shuffle array
    {
        for (int i = 0; i< 15; i++)
        {
            int index1 = UnityEngine.Random.Range(0,8);
            int index2 = UnityEngine.Random.Range(0,8);
            var tmp = gg[index1];
            gg[index1] = gg[index2];
            gg[index2] = tmp;
        }
        return gg;
    }

}
