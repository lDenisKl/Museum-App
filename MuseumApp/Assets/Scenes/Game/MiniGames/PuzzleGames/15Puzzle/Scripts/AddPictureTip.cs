using UnityEngine;
using UnityEngine.UI;

public class AddPictureTip : MonoBehaviour
{
    public GameObject tipPic;
    private void Awake()
    {
        if (SettingsController.isTipOn)
        {
            tipPic.active = true;
            tipPic.GetComponent<Image>().sprite = AddPuzzles.puzzlePiecesSprites[16];
        }
        else
        {
            tipPic.active = false;
        }
        
    }
}
