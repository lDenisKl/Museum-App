
using UnityEngine;
using UnityEngine.UI;

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

        
        if (Mathf.Abs(this.transform.localPosition.x - form.transform.localPosition.x) <= 40f &&
           Mathf.Abs(this.transform.localPosition.y - form.transform.localPosition.y) <= 40f && isPieceFinished == false)
        {
            this.transform.position = new Vector2(form.transform.position.x, form.transform.position.y);
            isPieceFinished = true;
            this.gameObject.GetComponent<Image>().raycastTarget = false;
            this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            this.transform.SetSiblingIndex(0);
            //WinScript.AddElement();
        }
    }

    private void Update()
    {
        if (isMoving && isPieceFinished == false)
        {
            mousePosition1 = Input.mousePosition;
            this.gameObject.transform.localPosition = new Vector2(mousePosition1.x - startPosX, mousePosition1.y - startPosY);
        }
    }
}
