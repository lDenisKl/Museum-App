using UnityEngine;
using UnityEngine.UI;

public class ArticleMap : MonoBehaviour
{
    private GameObject Map;
    
    public static void InitializeMap(int sightMapNumber)
    {
        ArticleController.MapImage.sprite = Resources.Load<Sprite>(Article.sightArticles[sightMapNumber].MapPath);
    }
    public void Open()
    {
        gameObject.SetActive(true);
    }
    public void Close()
    {
        gameObject.SetActive(false);
    }
}
