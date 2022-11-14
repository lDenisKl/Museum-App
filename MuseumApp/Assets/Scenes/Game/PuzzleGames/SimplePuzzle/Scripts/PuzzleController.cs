
using System;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleController : MonoBehaviour
{
    [Header("���������� ����� �����")]
    public GameObject form;                   // ���������� ����� �����

    private bool isMoving;                    // ���������� �� ��������
    private bool isPieceFinished;             // ��������� �� ���������� ����������� �����
    private Vector2 offset;
    Vector2 mousePosition;                    // ������� ����

    static AudioClip winAudio; // ���� ������

    /* VVV ��������� ��������� ������� � �������� ����������� VVV */
    Vector2 GetMousePos() { return Camera.main.ScreenToWorldPoint(Input.mousePosition); }

    private void Awake()
    {
        winAudio = Resources.Load("Sounds/WinAudio") as AudioClip; // �������� ����� ������ �� ����� Resources
    }

    /* VVV ����������� ������ VVV */
    private void Update() 
    {
        if (IsGameWin()) Win();                          // �������� �� �������
        if (!isMoving) return;

        mousePosition = GetMousePos();                   // �������� ���������� �������

        if (isMoving && isPieceFinished == false )
        {
            transform.position = mousePosition - offset; // ���������� �����������
        }
    }

    /* VVV ������������� �����������, ����� ������ ����� ���� ������ ���� VVV */
    void OnMouseDown()
    {
        isMoving = true;
        offset = GetMousePos() - (Vector2)transform.position;
    }

    /* VVV ������������� �����������, ����� ������ ����� ���� ������ ���� VVV */
    void OnMouseUp() 
    {
        isMoving = false;

        if (Mathf.Abs(transform.localPosition.x - form.transform.localPosition.x) <= 40f &&
           Mathf.Abs(transform.localPosition.y - form.transform.localPosition.y) <= 40f && isPieceFinished == false) // ��������� ��������� �� ���� ��� ������ ������
        {
            if(IsWin.solvedPuzzles == 8) // 9 ���� �������� �� ������ ������ 
            {
                gameObject.GetComponent<AudioSource>().clip = winAudio;
                gameObject.GetComponent<AudioSource>().Play();
            }
            else // ������ 8 ������ ��� ���������� ����������� ���� ����������
            {
                gameObject.GetComponent<AudioSource>().Play();
            }

            isPieceFinished = true;
            transform.position = new Vector3(form.transform.position.x, form.transform.position.y, 40); // "��������������" ���� �� ��� �����
            gameObject.GetComponent<Image>().raycastTarget = false;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            transform.SetSiblingIndex(0);
            IsWin.solvedPuzzles++; // �������� ������� ��������� ������
        }
    }

    /* VVV �������, ����������� ������ �� ���� VVV */
    bool IsGameWin()
    {
        if (IsWin.solvedPuzzles == 9)
        {
            IsWin.solvedPuzzles = 0;
            return true;
        }
        else { return false; }
    }


    /* VVV �������, ������������ ��� �������� VVV */
    private void Win()
    {
        var go = Instantiate(GamePrefabChanger.allPrefabs[4], GamePrefabChanger.prefabPlace.transform); // ������������� ��������� �������
        Destroy(go, 3f);                                                                                // ����������� ��������� ������ 3 �������
        GamePrefabChanger.ChangePrefab(GamePrefabChanger.winPrefabs[0]);                                // ������������� ��������� ��������
    }
}
