
using System;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleController : MonoBehaviour
{
    bool isMoving; // ���������� �� ��������
    bool isPieceFinished; // ��������� �� ���������� ����������� �����
    Vector2 mousePosition; // ������� ����
    float startPosX, startPosY; 
    public GameObject form; // ���������� ����� �����

    void OnMouseDown() // ������������� ��������, ����� ������ ����� ���� ������ ����
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            isMoving = true;
            mousePosition = Input.mousePosition;

            startPosX = mousePosition.x - this.transform.localPosition.x;
            startPosY = mousePosition.y - this.transform.localPosition.y;
        }
    }

    void OnMouseUp() // ������������� ��������, ����� ������ ����� ���� ������ ����
    {
        isMoving = false;

        
        if (Mathf.Abs(this.transform.localPosition.x - form.transform.localPosition.x) <= 40f &&
           Mathf.Abs(this.transform.localPosition.y - form.transform.localPosition.y) <= 40f && isPieceFinished == false) // ��������� ��������� �� ���� ��� ������ ������
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

    private void Update() // �������� ������
    {
        mousePosition = Input.mousePosition;

        if (isMoving && isPieceFinished == false && mousePosition.x>30 && mousePosition.y>30 && mousePosition.x<1890 && mousePosition.y<1050)
        {
            this.gameObject.transform.localPosition = new Vector2(mousePosition.x - startPosX, mousePosition.y - startPosY); // ���������� �����������
        }

        if (IsGameWin())
        {
            Win();
        }
    }

    private void Win()
    {
        
        Debug.Log("���������!");
        var go = Instantiate(GamePrefabChanger.winPuzzleGameParticle, GamePrefabChanger.prefabPlace.transform);
        //Destroy(go, 6f);
        GamePrefabChanger.ChangePrefab(GamePrefabChanger.winDescription1);
    }
}
