using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapPuzzleController : MonoBehaviour
{


    [Header("Правильное место пазла")]
    public GameObject form;                   // Правильное место пазла


    private bool isMoving;                     // Происходит ли движение
              // Закончена ли постановка конкретного пазла
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

        //if (IsGameWin()) 
        //{ 
        //    Win(); 
        //}                          // Проверка на выигрыш
        if (!isMoving) return;

        mousePosition = GetMousePos();                   // Получаем координаты курсорв

        if (isMoving)
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
           Mathf.Abs(transform.localPosition.y - form.transform.localPosition.y) <= 60f) // Проверяем находится ли пазл над нужным местом
        {
            if (IsMapWin.solvedMapPuzzles == 4)
            {
                gameObject.GetComponent<AudioSource>().clip = winAudio;
                gameObject.GetComponent<AudioSource>().Play();
            }
            else
            {
                gameObject.GetComponent<AudioSource>().Play();
            }

            AddPuzzlesToArray.puzzlePiecessolved[Array.IndexOf(AddPuzzlesToArray.puzzlePiecesunsolved, gameObject)].GetComponent<Image>().sprite = gameObject.GetComponent<Image>().sprite;
            
            transform.position = new Vector2(-999, -999);
            IsMapWin.solvedMapPuzzles++;
        }
    }

    /* VVV Функция, проверяющая собран ли пазл VVV */
    public static bool IsGameWin()
    {
        if (IsMapWin.solvedMapPuzzles == 4)
        {
            IsMapWin.solvedMapPuzzles = 0;
            return true;
        }
        else { return false; }
    }


    /* VVV Функция, используемая при выигрыше VVV */
    public static void Win()
    {                                                                             // Уничтожение партиклов спустя 3 секунды
        GamePrefabChanger.ChangePrefab(GamePrefabChanger.mapWinPrefabs[0]);     // Инизиализация победного описания
    }
}
