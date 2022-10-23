using System;
using UnityEngine;
using UnityEngine.UI;

public class Puzzle15Controller : MonoBehaviour
{
    private int index;
    System.Random rnd = new System.Random();

    private void Start()
    {
        for (int i = 0; i < 80; i++)
        {
            ToShuffle();
        }
        gameObject.GetComponent<AudioSource>().clip = Resources.Load("Sounds/PuzzleAudio") as AudioClip;
    }
    private void GameLogic()
    {
        if (index > 0 && AddPuzzles.puzzleButtons[index - 1].GetComponent<Image>().sprite == null &&
            index != 12 && index != 8 && index != 4)
        {
            AddPuzzles.puzzleButtons[index - 1].GetComponent<Image>().sprite = AddPuzzles.puzzleButtons[index].GetComponent<Image>().sprite;
            AddPuzzles.puzzleButtons[index].GetComponent<Image>().sprite = null;
            gameObject.GetComponent<AudioSource>().Play();
        }
        else if (index < 15 && AddPuzzles.puzzleButtons[index + 1].GetComponent<Image>().sprite == null &&
            index != 11 && index != 3 && index != 7)
        {
            AddPuzzles.puzzleButtons[index + 1].GetComponent<Image>().sprite = AddPuzzles.puzzleButtons[index].GetComponent<Image>().sprite;
            AddPuzzles.puzzleButtons[index].GetComponent<Image>().sprite = null;
            gameObject.GetComponent<AudioSource>().Play();
        }
        else if (index > 3 && AddPuzzles.puzzleButtons[index - 4].GetComponent<Image>().sprite == null)
        {
            AddPuzzles.puzzleButtons[index - 4].GetComponent<Image>().sprite = AddPuzzles.puzzleButtons[index].GetComponent<Image>().sprite;
            AddPuzzles.puzzleButtons[index].GetComponent<Image>().sprite = null;
            gameObject.GetComponent<AudioSource>().Play();
        }
        else if (index < 12 && AddPuzzles.puzzleButtons[index + 4].GetComponent<Image>().sprite == null)
        {
            AddPuzzles.puzzleButtons[index + 4].GetComponent<Image>().sprite = AddPuzzles.puzzleButtons[index].GetComponent<Image>().sprite;
            AddPuzzles.puzzleButtons[index].GetComponent<Image>().sprite = null;
            gameObject.GetComponent<AudioSource>().Play();
        }
    }
    public void OnClickButton()
    {
        
        index = FindIndex();
        GameLogic();
        
        if (IsWin())
        {
            gameObject.GetComponent<AudioSource>().clip = AddPuzzles.winAudio;
            gameObject.GetComponent<AudioSource>().Play();
            var go = Instantiate(GamePrefabChanger.allPrefabs[4], GamePrefabChanger.prefabPlace.transform);
            Destroy(go, 6f);
            GamePrefabChanger.ChangePrefab(GamePrefabChanger.winPrefabs[0]);
        }
    }
    public void ToShuffle()
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
        return Array.IndexOf(AddPuzzles.puzzleButtons, AddPuzzles.puzzleButtons[rnd.Next(0,16)]);
    }

    private bool IsWin()
    {
        int counter = 0;
        for (int i = 0; i < 16; i++)
        {
            if (AddPuzzles.puzzleButtons[i].GetComponent<Image>().sprite == AddPuzzles.puzzlePiecesSprites[i])
            {
                counter++;
            }
            else { break; }
        }
        if (counter == 15)
        {
            return true;
        }
        else { return false; }
    }

}
