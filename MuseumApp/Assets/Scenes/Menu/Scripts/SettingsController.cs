using UnityEngine;
using UnityEngine.UI;
using System.Drawing;

public class SettingsController : MonoBehaviour
{
    public static Toggle tipToggle1;
    public Toggle _tipToggle1;
    
    public static Toggle tipToggle2;
    public Toggle _tipToggle2;

    public static Slider volumeSlider;
    public Slider _volumeSlider;

    public static bool isTipOn;
    public static float volume;

    private void Awake()
    {
        volumeSlider = _volumeSlider;
        tipToggle1 = _tipToggle1;
        tipToggle2 = _tipToggle2;
        if (isTipOn)
        {
            tipToggle1.isOn = false;
            tipToggle2.isOn = true;
        }
        else if (isTipOn == false)
        {
            tipToggle1.isOn = true;
            tipToggle2.isOn = false;
        }
        if (PlayerPrefs.HasKey("volume"))
        {
            volumeSlider.value = PlayerPrefs.GetFloat("volume");
        }
       
    }
}
