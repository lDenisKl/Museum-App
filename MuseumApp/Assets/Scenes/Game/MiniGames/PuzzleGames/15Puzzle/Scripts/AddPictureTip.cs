using UnityEngine;
using UnityEngine.UI;

public class AddPictureTip : MonoBehaviour
{
    public GameObject pic;
    private void Awake()
    {
        for (int j = 0; j < 16; j++)
        {
            var go = Instantiate(pic, AddPuzzles.tipImage.transform, false);
            go.GetComponent<Image>().sprite = AddPuzzles.puzzlePiecesSprites[j];
        }
    }
}
