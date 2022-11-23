using System;
using UnityEngine;
using UnityEngine.UI;


public class AddPuzzlesToArr : MonoBehaviour
{
    [Header("Массив форм пазлов")]
    public GameObject[] puzzlePiecessolved;     // Массив собранных пазлов, которые находятся в форме
    [Header("Массив пазлов")]
    public GameObject[] puzzlePiecesunsolved;   // Массив несобранных пазлов, которые находятся вне формы

    private Sprite[] _puzzlePiecesSprites;                        // Начальный массив спрайтов деталек фотографии
    private static Sprite[] puzzlePiecesSprites = new Sprite[9];  // Массив спрайтов деталек фотографий для использования
    public static int activePuzzle;
   

    private void Awake()
    {
        activePuzzle = UnityEngine.Random.Range(1, 14);
        _puzzlePiecesSprites = Resources.LoadAll<Sprite>("ForSimplePuzzles/" + Convert.ToString(activePuzzle)); // Наполнение массива спрайтами случайного изображения из папки Resources

        for(int i = 0; i < _puzzlePiecesSprites.Length - 1; i++) // Наполнение статического массива деталями фотографии для пазлов без последнего(полностью фотография)
        {
            puzzlePiecesSprites[i] = _puzzlePiecesSprites[i];
        }
        

        for (int i = 0; i < puzzlePiecesSprites.Length; i++)
        {
            if (SettingsController.isTipOn)
            {
                puzzlePiecessolved[i].GetComponent<Image>().sprite = puzzlePiecesSprites[i]; // Присваивание каждому пазлу нужной картинку(Подсказки)
            }

            puzzlePiecesunsolved[i].GetComponent<Image>().sprite = puzzlePiecesSprites[i]; // Присваивание каждому пазлу нужной картинку
        }

    }

}
