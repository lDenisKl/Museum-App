using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapPuzzleController : MonoBehaviour
{


    [Header("���������� ����� �����")]
    public GameObject form;                   // ���������� ����� �����


    private bool isMoving;                     // ���������� �� ��������
              // ��������� �� ���������� ����������� �����
    private Vector2 offset;
    Vector2 mousePosition;                    // ������� ����

    static AudioClip winAudio; // ���� ������

    /* VVV ��������� ��������� ������� � �������� ����������� VVV */
    Vector2 GetMousePos() { return Camera.main.ScreenToWorldPoint(Input.mousePosition); }

    private void Awake()
    {
        winAudio = Resources.Load("Sounds/WinAudio") as AudioClip; // �������� ����� ������ �� ����� Resources
    }

    /* VVV ����������� ������ frame VVV */
    private void Update()
    {

        //if (IsGameWin()) 
        //{ 
        //    Win(); 
        //}                          // �������� �� �������
        if (!isMoving) return;

        mousePosition = GetMousePos();                   // �������� ���������� �������

        if (isMoving)
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

        if (Mathf.Abs(transform.localPosition.x - form.transform.localPosition.x) <= 60f &&
           Mathf.Abs(transform.localPosition.y - form.transform.localPosition.y) <= 60f) // ��������� ��������� �� ���� ��� ������ ������
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

    /* VVV �������, ����������� ������ �� ���� VVV */
    public static bool IsGameWin()
    {
        if (IsMapWin.solvedMapPuzzles == 4)
        {
            IsMapWin.solvedMapPuzzles = 0;
            return true;
        }
        else { return false; }
    }


    /* VVV �������, ������������ ��� �������� VVV */
    public static void Win()
    {                                                                             // ����������� ��������� ������ 3 �������
        GamePrefabChanger.ChangePrefab(GamePrefabChanger.mapWinPrefabs[0]);     // ������������� ��������� ��������
    }
}
