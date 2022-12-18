using System.IO;
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

    public static Article activePuzzle;
    public int puzzlePhotosAmount;
   

    private void Awake()
    {
        puzzlePhotosAmount = (new DirectoryInfo("Assets/Resources/ForSimplePuzzles").GetFiles("*.jpg")).Length; // Getting amount of pictures for simple puzzles
        activePuzzle = Article.sightArticles[Random.Range(0, Article.sightArticles.Count)]; // Getting active sight object
        while (activePuzzle.Squared == true) // Checking if photo is square
        {
            activePuzzle = Article.sightArticles[Random.Range(0, Article.sightArticles.Count)];
        }
        _puzzlePiecesSprites = Resources.LoadAll<Sprite>(activePuzzle.PhotoPath); // Getting sprites from Resources folder

        for(int i = 0; i < _puzzlePiecesSprites.Length - 1; i++)  // Adding to static array only necessary
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
