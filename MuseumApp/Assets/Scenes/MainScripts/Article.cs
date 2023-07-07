using System.Collections.Generic;
using UnityEngine;

public class Article // Class with sights' information
{
    public static List<Article> sightArticles = new List<Article>(); // Array for all sight
    public static List<GameObject> sightMaps = new List<GameObject>(); // Array for all maps
    public string Name; // Sight's name
    public string Description; // Sight's description
    public string ExtraInf; // Sight's location
    public string PhotoPath; // Path for sight's photo
    public Article(string name, string description, string extraInf, string photoPath)
    {
        this.Name = name;
        this.Description = description;
        this.ExtraInf = extraInf;
        this.PhotoPath = photoPath;
    }
}
