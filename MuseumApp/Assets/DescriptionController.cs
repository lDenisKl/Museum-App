using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DescriptionController : MonoBehaviour
{
    public static Text nameText;
    [SerializeField] private Text _nameText;
    public static TextMeshProUGUI descriptionText;
    [SerializeField] private TextMeshProUGUI _descriptionText;

    private void Awake()
    {
        nameText = _nameText;
        descriptionText = _descriptionText;
    }

    public static void SetDescription(int number)
    {
        nameText.text = Article.sightArticles[number].Name;
        descriptionText.text = Article.sightArticles[number].Description;
    }
}
