using UnityEngine;

public class IsMapWin : MonoBehaviour
{
    public static int solvedMapPuzzles;

    private void Awake()
    {
        solvedMapPuzzles = 0;
    }
    private void Update()
    {
        if (MapPuzzleController.IsGameWin())
        {
            MapPuzzleController.Win();
        }
    }
}
