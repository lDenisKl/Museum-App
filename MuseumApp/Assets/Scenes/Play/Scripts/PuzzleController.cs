
using UnityEngine;

public class PuzzleController : MonoBehaviour
{
    bool isMoving;
    bool isPieceFinished;
    Vector2 mousePosition1;
    float startPosX, startPosY;
    public GameObject form;

    void OnMouseDown()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            isMoving = true;
            mousePosition1 = Input.mousePosition;

            startPosX = mousePosition1.x - this.transform.localPosition.x;
            startPosY = mousePosition1.y - this.transform.localPosition.y;
        }
    }

    void OnMouseUp()
    {
        isMoving = false;

        
        if (Mathf.Abs(this.transform.localPosition.x - form.transform.localPosition.x) <= 15f &&
           Mathf.Abs(this.transform.localPosition.y - form.transform.localPosition.y) <= 15f && isPieceFinished != true)
        {
            this.transform.position = new Vector2(form.transform.position.x, form.transform.position.y);
            isPieceFinished = true;
            //WinScript.AddElement();
        }
    }

    private void Update()
    {
        if (isMoving == true && isPieceFinished == false)
        {
            mousePosition1 = Input.mousePosition;
            this.gameObject.transform.localPosition = new Vector2(mousePosition1.x - startPosX, mousePosition1.y - startPosY);
        }
    }
}
