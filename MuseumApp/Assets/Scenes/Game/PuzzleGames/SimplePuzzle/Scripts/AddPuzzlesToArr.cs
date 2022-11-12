using System;
using UnityEngine;
using UnityEngine.UI;


public class AddPuzzlesToArr : MonoBehaviour
{

   
    public GameObject[] puzzlePiecesunsolved; // Массив несобранных пазлов, которые находятся вне формы
    Sprite[] _puzzlePiecesSprites; // Начальный массив спрайтов деталек фотографии
    public static Sprite[] puzzlePiecesSprites = new Sprite[9];  // Массив спрайтов деталек фотографий для использования
    public static AudioClip winAudio; // Звук победы


    private void Awake()
    {
        winAudio = Resources.Load("Sounds/WinAudio") as AudioClip; // Загрузка звука победы из папки Resources
        _puzzlePiecesSprites = Resources.LoadAll<Sprite>("7");//Convert.ToString(UnityEngine.Random.Range(1, 11))); // Наполнение массива спрайтами случайного изображения из папки Resources
        for(int i = 0; i < _puzzlePiecesSprites.Length - 1; i++) // Наполнение статического массива деталями фотографии для пазлов без последнего(полностью фотография)
        {
            puzzlePiecesSprites[i] = _puzzlePiecesSprites[i];
        }
        

        for (int i = 0; i < puzzlePiecesSprites.Length; i++)
        {
            puzzlePiecesunsolved[i].GetComponent<Image>().sprite = puzzlePiecesSprites[i]; // Присваивание каждому пазлу нужную картинку
        }

    }

}
