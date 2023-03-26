using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ArticleController : MonoBehaviour
{
    public static Text nameText;
    [SerializeField] private Text _nameText;
    public static TextMeshProUGUI descriptionText;
    [SerializeField] private TextMeshProUGUI _descriptionText;
    public static Text locationText;
    [SerializeField] private Text _locationText;
    public static GameObject sightPhoto;
    [SerializeField] private GameObject _sightPhoto;


    private void Awake()
    {
        nameText = _nameText;
        descriptionText = _descriptionText;
        locationText = _locationText;
        sightPhoto = _sightPhoto;
    }

    public static void SetArticle(int number)
    {
        nameText.text = Article.sightArticles[number].Name;
        descriptionText.text = Article.sightArticles[number].Description;
        locationText.text = Article.sightArticles[number].ExtraInf;
        sightPhoto.GetComponent<Image>().sprite = Resources.Load<Sprite>(Article.sightArticles[number].PhotoPath);
    }
}


