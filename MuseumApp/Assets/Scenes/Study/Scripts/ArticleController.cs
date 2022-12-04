using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArticleController : MonoBehaviour
{
    public static Text nameText;
    public Text _nameText;
    public static Text descriptionText;
    public Text _descriptionText;
    public static Text locationText;
    public Text _locationText;
    public static GameObject sightPhoto;
    public GameObject _sightPhoto;

    private static List<Article> sightArticles = new List<Article>();

    private void Awake()
    {
        nameText = _nameText;
        descriptionText = _descriptionText;
        locationText = _locationText;
        sightPhoto = _sightPhoto;
        Article article1 = new(Data.sightNames[0], Data.sightDescriptions[0], Data.sightLocations[0], Data.sightPhotos[0]);
        sightArticles.Add(article1);
    }

    public static void SetArticle(int number)
    {
        nameText.text = sightArticles[0].Name;
        descriptionText.text = sightArticles[0].Description;
        locationText.text = sightArticles[0].Location;
        sightPhoto.GetComponent<Image>().sprite = sightArticles[0].Photo;
    }
}
