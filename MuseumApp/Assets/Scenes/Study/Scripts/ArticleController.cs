using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class ArticleController : MonoBehaviour
{
    public static Text nameText;
    [SerializeField] private Text _nameText;
    public static Text descriptionText;
    [SerializeField] private Text _descriptionText;
    public static Text locationText;
    [SerializeField] private Text _locationText;
    public static GameObject sightPhoto;
    [SerializeField] private GameObject _sightPhoto;

    public static List<Article> sightArticles = new List<Article>();

    private void Awake()
    {
        nameText = _nameText;
        descriptionText = _descriptionText;
        locationText = _locationText;
        sightPhoto = _sightPhoto;

        FileInfo[] fileAmount = new DirectoryInfo("Assets/").GetFiles("*.json");
        foreach (var item in fileAmount)
        {
            string json = File.ReadAllText("Assets/" + Convert.ToString(item.Name));
            Debug.Log(json);
            Article go = JsonUtility.FromJson<Article>(json);
            sightArticles.Add(go);

        }


       
    }

    public static void SetArticle(int number)
    {
        nameText.text = sightArticles[number].Name;
        descriptionText.text = sightArticles[number].Description;
        locationText.text = sightArticles[number].Location;
        sightPhoto.GetComponent<Image>().sprite = Resources.LoadAll<Sprite>(sightArticles[number].PhotoPath)[9];
    }
}


