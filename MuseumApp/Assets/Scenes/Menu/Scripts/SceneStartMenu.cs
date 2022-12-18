using System;
using System.IO;
using UnityEngine;
using static MenuPrefabChanger; // Connecting prefab changing script

public class SceneStartMenu : MonoBehaviour
{
    private void Awake()
    {
        // Check settings values from PlayerPrefs and set needed values
        if (PlayerPrefs.HasKey("tip") && PlayerPrefs.GetInt("tip") == 1) 
        {
            SettingsController.isTipOn = true;
        }
        else if (PlayerPrefs.HasKey("tip") && PlayerPrefs.GetInt("tip") == 0)
        {
            SettingsController.isTipOn = false;
        }
        if (PlayerPrefs.HasKey("volume"))
        {
            SettingsController.volume = PlayerPrefs.GetFloat("volume");
            AudioListener.volume = PlayerPrefs.GetFloat("volume");
        }
        
        ChangePrefab(allPrefabs[2]); // Instantiate default menu form
        FileInfo[] fileAmount = new DirectoryInfo(Application.streamingAssetsPath + "/").GetFiles("*.json"); // Getting all article JSON files
        string[] jsonFiles = new string[fileAmount.Length]; // Creating array for file names
        for(int i = 0; i < fileAmount.Length; i++)
        {
            jsonFiles[i] = fileAmount[i].Name; // Setting JSON files' names
        }
        Array.Sort(jsonFiles); // Sorting array with names

        foreach (var item in jsonFiles)
        {
            string json = File.ReadAllText(Application.streamingAssetsPath + "/" + item);                 // Read JSON file
            Article go = JsonUtility.FromJson<Article>(json);                                             // Converting from JSON into class
            Article.sightArticles.Add(go);                                                                // Adding to article array
        }
        var loading = Instantiate(allPrefabs[0], prefabPlace.transform, false); // Instantiate loading image
    }
}
