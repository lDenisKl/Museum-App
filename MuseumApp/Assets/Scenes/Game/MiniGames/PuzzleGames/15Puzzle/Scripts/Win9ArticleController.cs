using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Win9ArticleController : MonoBehaviour
{
    public static Text nameText;
    [SerializeField] private Text _nameText;
    public static TextMeshProUGUI descriptionText;
    [SerializeField] private TextMeshProUGUI _descriptionText;

    private void Awake()
    {
        nameText = _nameText;
        descriptionText = _descriptionText;
        SetWinArticle(Article.sightArticles.IndexOf(AddPuzzles.activePuzzle));

    }

    public static void SetWinArticle(int number)
    {
        nameText.text = Article.sightArticles[number].Name;
        descriptionText.text = Article.sightArticles[number].Description;
        descriptionText.text = descriptionText.text.Replace("NEWLINE", "\n\n").Replace("TAB", "\t");
    }
}
