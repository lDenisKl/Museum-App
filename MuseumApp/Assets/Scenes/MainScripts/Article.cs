using System.Collections.Generic;

public class Article // Class with sights' information
{
    public static List<Article> sightArticles = new List<Article>(); // Array for all sight
    public string Name; // Sight's name
    public string Description; // Sight's description
    public string ExtraInf; // Sight's location
    public string PhotoPath; // Path for sight's photo
    public bool   Squared; // Is photo - square (for puzzle logic)
    public Article(string name, string description, string extraInf, string photoPath)
    {
        this.Name = name;
        this.Description = description;
        this.ExtraInf = extraInf;
        this.PhotoPath = photoPath;
    }
}
