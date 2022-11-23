using UnityEngine;
using UnityEngine.UI;

public class SettingsController : MonoBehaviour
{
    public static Toggle tipToggle;
    public Toggle _tipToggle;

    public static bool isTipOn;
    public static int volume;

    private void Awake()
    {
        tipToggle = _tipToggle;
    }
}
