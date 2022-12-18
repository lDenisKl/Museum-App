using System;
using UnityEngine;
using UnityEngine.UI;

public class Puzzle15Controller : MonoBehaviour
{
    private int index;
    System.Random rnd = new System.Random();

    private void Start()
    {
        gameObject.GetComponent<AudioSource>().clip = Resources.Load("Sounds/Games/PuzzleAudio") as AudioClip; // Getting puzzle audio
    }
    private void GameLogic() // Method with Nines logic
    {
        if (index > 0 && AddPuzzles.puzzleButtons[index - 1].GetComponent<Image>().sprite == null &&
            index != 3 && index != 6)
        {
            AddPuzzles.puzzleButtons[index - 1].GetComponent<Image>().sprite = AddPuzzles.puzzleButtons[index].GetComponent<Image>().sprite;
            AddPuzzles.puzzleButtons[index].GetComponent<Image>().sprite = null;
            gameObject.GetComponent<AudioSource>().Play();
        }
        else if (index < 8 && AddPuzzles.puzzleButtons[index + 1].GetComponent<Image>().sprite == null &&
            index != 2 && index != 5)
        {
            AddPuzzles.puzzleButtons[index + 1].GetComponent<Image>().sprite = AddPuzzles.puzzleButtons[index].GetComponent<Image>().sprite;
            AddPuzzles.puzzleButtons[index].GetComponent<Image>().sprite = null;
            gameObject.GetComponent<AudioSource>().Play();
        }
        else if (index > 2 && AddPuzzles.puzzleButtons[index - 3].GetComponent<Image>().sprite == null)
        {
            AddPuzzles.puzzleButtons[index - 3].GetComponent<Image>().sprite = AddPuzzles.puzzleButtons[index].GetComponent<Image>().sprite;
            AddPuzzles.puzzleButtons[index].GetComponent<Image>().sprite = null;
            gameObject.GetComponent<AudioSource>().Play();
        }
        else if (index < 6 && AddPuzzles.puzzleButtons[index + 3].GetComponent<Image>().sprite == null)
        {
            AddPuzzles.puzzleButtons[index + 3].GetComponent<Image>().sprite = AddPuzzles.puzzleButtons[index].GetComponent<Image>().sprite;
            AddPuzzles.puzzleButtons[index].GetComponent<Image>().sprite = null;
            gameObject.GetComponent<AudioSource>().Play();
        }
    }
    public void OnClickButton() // OnClick
    {
        index = FindIndex();
        GameLogic();
        
        if (IsWin()) Win();
    }
    public void ToShuffle() // Shuffle method
    {
        index = FindIndexRand();
        GameLogic();
    }

    private int FindIndex()
    {
        return Array.IndexOf(AddPuzzles.puzzleButtons, gameObject);
    }
    private int FindIndexRand()
    {
        return Array.IndexOf(AddPuzzles.puzzleButtons, AddPuzzles.puzzleButtons[rnd.Next(0,9)]);
    }

    private bool IsWin() // Check if win
    {
        int counter = 0;
        for (int i = 0; i < 8; i++)
        {
            if (AddPuzzles.puzzleButtons[i].GetComponent<Image>().sprite == AddPuzzles.puzzlePiecesSprites[i])
            {
                counter++;
                
            }
            else { break; }
        }
        if (counter == 8)
        {
            return true;
        }
        else { return false; }
    }

    private void Win() // Actions on win
    {
        gameObject.GetComponent<AudioSource>().clip = AddPuzzles.winAudio;
        gameObject.GetComponent<AudioSource>().Play();
        GamePrefabChanger.ChangePrefab(GamePrefabChanger.winPrefabs[2]);
    }

}
