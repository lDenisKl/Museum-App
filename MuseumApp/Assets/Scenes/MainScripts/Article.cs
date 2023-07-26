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
    public string MapPath; // Path for map's image
    public Article(string name, string description, string extraInf, string photoPath, string mapPath)
    {
        Name = name;
        Description = description;
        ExtraInf = extraInf;
        PhotoPath = photoPath;
        MapPath = mapPath;
    }
}
