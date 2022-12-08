using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SightMenuButton : MonoBehaviour
{
    public static int sightNumber;
    public int _sightNumber;

    public Button button;
    public static Text buttonText;
    public Text _buttonText;

    private void Awake()
    {
        buttonText = _buttonText;
    }
}
