using UnityEngine;
using UnityEngine.UI;

public class WinArticleController : MonoBehaviour
{
    public static Text nameText;
    [SerializeField] private Text _nameText;
    public static Text descriptionText;
    [SerializeField] private Text _descriptionText;

    private void Awake()
    {
        nameText = _nameText;
        descriptionText = _descriptionText;
        SetWinArticle(AddPuzzlesToArr.activePuzzle-1);
    }

    public static void SetWinArticle(int number)
    {
        nameText.text = Article.sightArticles[number].Name;
        descriptionText.text = Article.sightArticles[number].Description;
    }
}
