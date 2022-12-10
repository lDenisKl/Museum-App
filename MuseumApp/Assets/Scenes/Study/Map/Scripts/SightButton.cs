using UnityEngine;
using UnityEngine.UI;

public class SightButton : MonoBehaviour
{
    public int sightNumber;
    public static Button btn;
    public Button _btn;

    private void Awake()
    {
        btn = _btn;
    }
}
