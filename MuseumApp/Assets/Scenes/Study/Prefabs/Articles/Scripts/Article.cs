using UnityEngine;

public class Article
{
    public string Name;
    public string Description;
    public string Location;
    public Sprite Photo;

    public Article(string Name, string Description, string Location, Sprite Photo)
    {
        this.Name = Name;
        this.Description = Description;
        this.Location = Location;
        this.Photo = Photo;
    }

}
