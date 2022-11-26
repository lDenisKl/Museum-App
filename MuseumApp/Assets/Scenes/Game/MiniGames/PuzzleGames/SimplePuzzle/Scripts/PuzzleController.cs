using UnityEngine;
using UnityEngine.UI;

public class PuzzleController : MonoBehaviour
{
    [Header("Puzzle place")]
    public GameObject form;

    private bool isMoving;
    private bool isPieceFinished;
    private Vector2 offset;
    Vector2 mousePosition;

    static AudioClip winAudio;

    /* VVV Getting coordinates of mouse position VVV */
    Vector2 GetMousePos() { return Camera.main.ScreenToWorldPoint(Input.mousePosition); }

    private void Awake()
    {
        winAudio = Resources.Load("Sounds/WinAudio") as AudioClip; // Getting audio from Resources folder
    }

    private void Update() 
    {
        if (IsGameWin()) Win();                          // Check if win
        if (!isMoving) return;

        mousePosition = GetMousePos();                   // Getting mouse coordinates

        if (isMoving && isPieceFinished == false )
        {
            transform.position = mousePosition - offset; // Moving realisation
        }
    }

    void OnMouseDown()
    {
        isMoving = true;
        offset = GetMousePos() - (Vector2)transform.position;
    }

    void OnMouseUp() 
    {
        isMoving = false;

        if (Mathf.Abs(transform.localPosition.x - form.transform.localPosition.x) <= 60f &&
           Mathf.Abs(transform.localPosition.y - form.transform.localPosition.y) <= 60f && isPieceFinished == false) // Checking if puzzle piece is up to right place
        {
            if(IsWin.solvedPuzzles == 8)
            {
                gameObject.GetComponent<AudioSource>().clip = winAudio;
                gameObject.GetComponent<AudioSource>().Play();
            }
            else
            {
                gameObject.GetComponent<AudioSource>().Play();
            }

            isPieceFinished = true;
            transform.position = new Vector3(form.transform.position.x, form.transform.position.y, 40);              // Put on right place
            gameObject.GetComponent<Image>().raycastTarget = false;                                                  // Turn off raycast target
            gameObject.GetComponent<BoxCollider2D>().enabled = false;                                                // Turn off collider
            transform.SetSiblingIndex(0);                                                                            // Put higher in Hierarchy
            IsWin.solvedPuzzles++;                                                                                   // How many puzzles solved
        }
    }

    /* VVV Check if puzzle solved VVV */
    private bool IsGameWin()
    {
        if (IsWin.solvedPuzzles == 9)
        {
            IsWin.solvedPuzzles = 0;
            return true;
        }
        else { return false; }
    }

    /* VVV Win actions VVV */
    private void Win()
    {
        var go = Instantiate(GamePrefabChanger.allPrefabs[4], GamePrefabChanger.prefabPlace.transform);     // Particle initialization
        Destroy(go, 3f);                                                                                    // Particle destroying after 3 sec 
        GamePrefabChanger.ChangePrefab(GamePrefabChanger.winPrefabs[AddPuzzlesToArr.activePuzzle - 1]);     // Win description initialization
    }
}
