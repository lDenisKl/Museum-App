using UnityEngine;
using UnityEngine.UI;

public class AddPictureTip : MonoBehaviour
{
    public GameObject tipPic;
    private void Awake()
    {
        if (SettingsController.isTipOn)
        {
            tipPic.SetActive(true);
            tipPic.GetComponent<Image>().sprite = AddPuzzles.puzzlePiecesSprites[9];
        }
        else
        {
            tipPic.SetActive(false);
        }
    }
}
