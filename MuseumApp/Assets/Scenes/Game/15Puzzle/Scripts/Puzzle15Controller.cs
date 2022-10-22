using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puzzle15Controller : MonoBehaviour
{
   public void OnClick()
    {
        gameObject.GetComponent<Image>().sprite = null;
    }
}
