using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class EditorController : MonoBehaviour
{
    public static Transform ArticleArea;
    public Transform articleArea;

    public static GameObject ArticleCellPrefab;
    public GameObject articleCellPrefab;
    private void Start()
    {
        ArticleCellPrefab = articleCellPrefab;
        ArticleArea = articleArea;
        int fileAmount = new DirectoryInfo(Application.streamingAssetsPath + "/").GetFiles("*.json").Length;
        for (int i = 0; i < fileAmount; i++)
        {
            var go = Instantiate(ArticleCellPrefab, ArticleArea, false);
            go.GetComponent<SightMenuButton>()._sightNumber = i + 1;
            go.GetComponent<SightMenuButton>()._buttonText.text = Article.sightArticles[i].Name;
        }
    }
}
