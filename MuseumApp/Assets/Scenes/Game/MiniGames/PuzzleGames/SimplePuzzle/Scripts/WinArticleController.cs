using UnityEngine;
using UnityEngine.UI;

public class WinArticleController : MonoBehaviour
{
    private static Text nameText;
    [SerializeField] private Text _nameText;
    private static Text descriptionText;
    [SerializeField] private Text _descriptionText;

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
    }
}
