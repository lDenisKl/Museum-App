using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class SightMenu : MonoBehaviour
{
    public Button button;
    public Transform place;

    private void Awake()
    {
        int fileAmount = new DirectoryInfo("Assets/").GetFiles("*.json").Length;
        for (int i = 0; i < fileAmount; i++)
        {
            var go = Instantiate(button, place, false);
            go.GetComponent<SightMenuButton>()._sightNumber = i+1;
            go.GetComponent<SightMenuButton>()._buttonText.text = ArticleController.sightArticles[i].Name;
            //Debug.Log(ArticleController.sightArticles[i].Name);
            
        }
        
    }
}