using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class WinArticleController : MonoBehaviour
{
    private static Text nameText;
    [SerializeField] private Text _nameText;
    private static TextMeshProUGUI descriptionText;
    [SerializeField] private TextMeshProUGUI _descriptionText;

    private void Awake()
    {
        nameText = _nameText;
        descriptionText = _descriptionText;
        SetWinArticle(Article.sightArticles.IndexOf(AddPuzzlesToArr.activePuzzle));
    }

    public static void SetWinArticle(int number)
    {
        nameText.text = Article.sightArticles[number].Name;
        descriptionText.text = Article.sightArticles[number].Description;
        descriptionText.text = descriptionText.text.Replace("NEWLINE", "\n\n").Replace("TAB", "\t");
    }
}
