using System;
using UnityEngine;
using UnityEngine.UI;


public class AddPuzzlesToArr : MonoBehaviour
{

   
    public GameObject[] puzzlePiecesunsolved; // Массив несобранных пазлов, которые находятся вне формы
    Sprite[] _puzzlePiecesSprites; // Массив для спрайтов деталек фотографии
    public static Sprite[] puzzlePiecesSprites; 

    private void Awake()
    {
        _puzzlePiecesSprites = Resources.LoadAll<Sprite>(Convert.ToString(UnityEngine.Random.Range(1, 11))); // Наполнение массива спрайтами случайного изображения из папки Resources
        puzzlePiecesSprites = _puzzlePiecesSprites;

        for (int i = 0; i < puzzlePiecesSprites.Length; i++)
        {
            puzzlePiecesunsolved[i].GetComponent<Image>().sprite = puzzlePiecesSprites[i]; // Присваивание каждому пазлу нужную картинку
        }

    }

}
