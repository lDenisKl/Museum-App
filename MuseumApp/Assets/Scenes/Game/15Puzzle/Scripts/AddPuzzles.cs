using System;
using UnityEngine;
using UnityEngine.UI;

public class AddPuzzles : MonoBehaviour
{
    public GameObject[] puzzleButtons; // Массив для деталек
    Sprite[] _puzzlePiecesSprites; // Массив для спрайтов деталек фотографии
    public static Sprite[] puzzlePiecesSprites;
    public Transform puzzlePlace;
    public GameObject button;

    private void Awake()
    {
        _puzzlePiecesSprites = Resources.LoadAll<Sprite>("100"); // Наполнение массива спрайтами случайного изображения из папки Resources
        puzzlePiecesSprites = _puzzlePiecesSprites;

        for (int j = 0; j<16; j++)
        {
            var go = Instantiate(button, puzzlePlace, false);
            puzzleButtons[j] = go;
            go.GetComponent<Image>().sprite = puzzlePiecesSprites[j];
        }
        puzzleButtons[15].GetComponent<Image>().sprite = null;

    }
}
