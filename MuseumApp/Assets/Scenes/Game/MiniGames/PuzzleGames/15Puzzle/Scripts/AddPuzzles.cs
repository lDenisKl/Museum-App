using System;
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

    public static int activePuzzle;
    public int puzzlePhotosAmount;
    private int[] gg = new int[] { 1,2,3,4,5, 6, 7,8,0};

    private void Awake()
    {
        ShowGG(gg, "init");
        // Reference and object connection
        tipImage = _tipImage;
        puzzleButtons = _puzzleButtons;
        puzzleButtonsSolved = puzzleButtons;
        winAudio = Resources.Load("Sounds/WinAudio") as AudioClip;    // Geting win audioclip from Resources folder
        activePuzzle = UnityEngine.Random.Range(1, puzzlePhotosAmount + 1);
        puzzlePiecesSprites = Resources.LoadAll<Sprite>("For9Puzzle/" + Convert.ToString(activePuzzle));

        ShowGG(gg, "init");
        int[] newArr = new int[9];
        while (true)
        {
            newArr = Shuffle(gg);
            if (isSolvable(newArr))
            {
                break;
            }
        }
        ShowGG(newArr, "shuffled correctly");
        GgToPics(newArr);



        for (int j = 0; j < 9; j++)                                   // Adding puzzles to game place
        {
            var go = Instantiate(button, puzzlePlace, false);         // Puzzle piece creation
            puzzleButtons[j] = go;                                    // Adding piece to array
            go.GetComponent<Image>().sprite = _puzzlePiecesSprites[j]; // Put sprite on piece
        }

        //puzzleButtons[8].GetComponent<Image>().sprite = null;         // Making one piece empty
        tipImage.GetComponent<Image>().preserveAspect = true;

    }

    private void GgToPics(int[] gg)
    {
        for (int i = 0; i < _puzzlePiecesSprites.Length-1; i++)
        {
            _puzzlePiecesSprites[i] = puzzlePiecesSprites[gg[i]-1];
        }
    }

    private bool isSolvable(int[] gg)
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
        ShowGG(gg, "Checking...");
        if (summ % 2 == 0)
        {
            return true;
        }
        return false;
    } 

    private int[] Shuffle(int[] gg)
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

    private void ShowGG(int[] gg, string str)
    {
        string array = "";
        for (int i = 0; i < gg.Length; i++)
        {
            array += gg[i];
            array += " ";
        }
        Debug.Log(str + " " + array);
    }

}
