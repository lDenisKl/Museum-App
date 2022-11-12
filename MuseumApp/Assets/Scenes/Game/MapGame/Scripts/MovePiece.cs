using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePiece : MonoBehaviour
{
    bool isMoving; // ���������� �� ��������
    bool isPieceFinished; // ��������� �� ���������� ����������� �����
    Vector2 mousePosition; // ������� ����
    Vector3 startPos; // ������� ����
    float startPosX, startPosY;
    public GameObject form; // ���������� ����� �����

    // Start is called before the first frame update
    void Start()
    {
        startPos = new Vector3(transform.position.x, transform.position.y, 40); 
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Input.mousePosition;

        if (isMoving)
        {
            
            this.gameObject.transform.localPosition = new Vector2(mousePosition.x - startPosX, mousePosition.y - startPosY); // ���������� �����������
        }
    }
    private void OnMouseDown()// ������������� ��������, ����� ������ ����� ���� ������ ����
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.SetSiblingIndex(-1);
            isMoving = true;
            mousePosition = Input.mousePosition;

            startPosX = mousePosition.x - this.transform.localPosition.x;
            startPosY = mousePosition.y - this.transform.localPosition.y;
        }
    }

    void OnMouseUp() // ������������� ��������, ����� ������ ����� ���� ������ ����
    {
        isMoving = false;

        if (Mathf.Abs(transform.localPosition.x - form.transform.localPosition.x) <= 60f &&
           Mathf.Abs(transform.localPosition.y - form.transform.localPosition.y) <= 60f) // ��������� ��������� �� ���� ��� ������ ������
        {

            transform.position = new Vector3(form.transform.position.x, form.transform.position.y, 40);
            form.GetComponent<Image>().sprite = gameObject.GetComponent<Image>().sprite;
            Destroy(gameObject);
        }
        else
        {
            gameObject.transform.position = startPos;
        }
    }
}
