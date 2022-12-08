
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public AnimationClip hideMenu;
    public static GameObject telo;
    public GameObject _telo;

    private void Awake()
    {
        telo = _telo;
    }
    public static void HideMenu()
    {
        telo.GetComponent<Animator>().Play("HideMenu");
    }
    public static void HideDescription()
    {
        telo.GetComponent<Animator>().Play("HideDescription");
    }
}
