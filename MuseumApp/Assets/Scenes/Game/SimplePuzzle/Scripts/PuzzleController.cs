
using System;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleController : MonoBehaviour
{
    bool isMoving; // Происходит ли движение
    bool isPieceFinished; // Закончена ли постановка конкретного пазла
    Vector2 mousePosition; // Позиция мыши
    float startPosX, startPosY; 
    public GameObject form; // Правильное место пазла

    void OnMouseDown() // Автоматически делается, когда нажата какая либо кнопка мыши
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            isMoving = true;
            mousePosition = Input.mousePosition;

            startPosX = mousePosition.x - this.transform.localPosition.x;
            startPosY = mousePosition.y - this.transform.localPosition.y;
        }
    }

    void OnMouseUp() // Автоматически делается, когда отжата какая либо кнопка мыши
    {
        isMoving = false;

        
        if (Mathf.Abs(this.transform.localPosition.x - form.transform.localPosition.x) <= 40f &&
           Mathf.Abs(this.transform.localPosition.y - form.transform.localPosition.y) <= 40f && isPieceFinished == false) // Проверяем находится ли пазл над нужным местом
        {
            this.transform.position = new Vector3(form.transform.position.x, form.transform.position.y, 40);
            isPieceFinished = true;
            this.gameObject.GetComponent<Image>().raycastTarget = false;
            this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            this.transform.SetSiblingIndex(0);
            IsWin.solvedPuzzles++;
        }
    }

    bool IsGameWin()
    {
        if (IsWin.solvedPuzzles == 9)
        {
            IsWin.solvedPuzzles = 0;
            return true;
        }
        else { return false; }
    }

    private void Update() // Делается всегда
    {
        mousePosition = Input.mousePosition;

        if (isMoving && isPieceFinished == false && mousePosition.x>30 && mousePosition.y>30 && mousePosition.x<1890 && mousePosition.y<1050)
        {
            this.gameObject.transform.localPosition = new Vector2(mousePosition.x - startPosX, mousePosition.y - startPosY); // Реализация перемещения
        }

        if (IsGameWin())
        {
            Win();
        }
    }

    private void Win()
    {
        
        Debug.Log("Красавчик!");
        var go = Instantiate(GamePrefabChanger.winPuzzleGameParticle, GamePrefabChanger.prefabPlace.transform);
        //Destroy(go, 6f);
        GamePrefabChanger.ChangePrefab(GamePrefabChanger.winDescription1);
    }
}
