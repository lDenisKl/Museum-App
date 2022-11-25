
using System;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleController : MonoBehaviour
{
    [Header("Правильное место пазла")]
    public GameObject form;                   // Правильное место пазла

    private bool isMoving;                    // Происходит ли движение
    private bool isPieceFinished;             // Закончена ли постановка конкретного пазла
    private Vector2 offset;
    Vector2 mousePosition;                    // Позиция мыши

    static AudioClip winAudio; // Звук победы

    /* VVV Получение координат курсора в камерных координатах VVV */
    Vector2 GetMousePos() { return Camera.main.ScreenToWorldPoint(Input.mousePosition); }

    private void Awake()
    {
        winAudio = Resources.Load("Sounds/WinAudio") as AudioClip; // Загрузка звука победы из папки Resources
    }

    /* VVV Выполняется каждый frame VVV */
    private void Update() 
    {
        if (IsGameWin()) Win();                          // Проверка на выигрыш
        if (!isMoving) return;

        mousePosition = GetMousePos();                   // Получаем координаты курсорв

        if (isMoving && isPieceFinished == false )
        {
            transform.position = mousePosition - offset; // Реализация перемещения
        }
    }

    /* VVV Автоматически выполняется, когда нажата какая либо кнопка мыши VVV */
    void OnMouseDown()
    {
        isMoving = true;
        offset = GetMousePos() - (Vector2)transform.position;
    }

    /* VVV Автоматически выполняется, когда отжата какая либо кнопка мыши VVV */
    void OnMouseUp() 
    {
        isMoving = false;

        if (Mathf.Abs(transform.localPosition.x - form.transform.localPosition.x) <= 60f &&
           Mathf.Abs(transform.localPosition.y - form.transform.localPosition.y) <= 60f && isPieceFinished == false) // Проверяем находится ли пазл над нужным местом
        {
            if(IsWin.solvedPuzzles == 8) // 9 пазл ставится со звуком победы 
            {
                gameObject.GetComponent<AudioSource>().clip = winAudio;
                gameObject.GetComponent<AudioSource>().Play();
            }
            else // Первые 8 пазлов при постановке проигрывают звук постановки
            {
                gameObject.GetComponent<AudioSource>().Play();
            }

            isPieceFinished = true;
            transform.position = new Vector3(form.transform.position.x, form.transform.position.y, 40); // "Примагничиваем" пазл на своё место
            gameObject.GetComponent<Image>().raycastTarget = false;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            transform.SetSiblingIndex(0);
            IsWin.solvedPuzzles++; // Изменяем счётчик собранных пазлов
        }
    }

    /* VVV Функция, проверяющая собран ли пазл VVV */
    private bool IsGameWin()
    {
        if (IsWin.solvedPuzzles == 9)
        {
            IsWin.solvedPuzzles = 0;
            return true;
        }
        else { return false; }
    }


    /* VVV Функция, используемая при выигрыше VVV */
    private void Win()
    {
        var go = Instantiate(GamePrefabChanger.allPrefabs[4], GamePrefabChanger.prefabPlace.transform); // Инизиализация победного эффекта
        Destroy(go, 3f);                                                                                // Уничтожение партиклов спустя 3 секунды
        GamePrefabChanger.ChangePrefab(GamePrefabChanger.winPrefabs[AddPuzzlesToArr.activePuzzle - 1]);     // Инизиализация победного описания
    }
}
