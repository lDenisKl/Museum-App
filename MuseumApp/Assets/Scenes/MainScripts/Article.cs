using System.Collections.Generic;

public class Article // Class with sights' information
{
    public static List<Article> sightArticles = new List<Article>(); // Array for all sight
    public string Name; // Sight's name
    public string Description; // Sight's description
    public string Location; // Sight's location
    public string PhotoPath; // Path for sight's photo
    public bool   Squared; // Is photo - square (for puzzle logic)
}
