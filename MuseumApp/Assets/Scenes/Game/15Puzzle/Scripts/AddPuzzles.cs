using System;
using UnityEngine;
using UnityEngine.UI;

public class AddPuzzles : MonoBehaviour
{
    public GameObject[] _puzzleButtons; // Массив для деталек
    public static GameObject[] puzzleButtons;
    Sprite[] _puzzlePiecesSprites; // Массив для спрайтов деталек фотографии
    public static Sprite[] puzzlePiecesSprites;
    public static GameObject[] puzzleButtonsSolved;
    public Transform puzzlePlace;
    public GameObject button;
    public GameObject tipImage;


    private void Awake()
    {
        tipImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Photos/1000");
        _puzzlePiecesSprites = Resources.LoadAll<Sprite>("100"); // Наполнение массива спрайтами случайного изображения из папки Resources
        puzzlePiecesSprites = _puzzlePiecesSprites;
        puzzleButtons = _puzzleButtons;
        puzzleButtonsSolved = puzzleButtons;

        for (int j = 0; j < 16; j++)
        {
            var go = Instantiate(button, puzzlePlace, false);
            puzzleButtons[j] = go;
            go.GetComponent<Image>().sprite = puzzlePiecesSprites[j];
        }
        puzzleButtons[15].GetComponent<Image>().sprite = null;

    }
}
