using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AddPuzzlesToArr : MonoBehaviour
{

    public GameObject[] places;
    public GameObject[] puzzlePiecesunsolved;
    Sprite[] puzzlePieces;

    private void Awake()
    {
        puzzlePieces = Resources.LoadAll<Sprite>(Convert.ToString(UnityEngine.Random.Range(1, 3)));

        for (int i = 0; i < puzzlePieces.Length; i++)
        {
            places[i].GetComponent<Image>().sprite = puzzlePieces[i]; 
            Image tmp = places[i].GetComponent<Image>();
            Color newColor = tmp.color;
            newColor.a = 0;
            tmp.color = newColor;
        }
        for (int i = 0; i < puzzlePieces.Length; i++)
        {
            puzzlePiecesunsolved[i].GetComponent<Image>().sprite = puzzlePieces[i];
        }

    }

}
