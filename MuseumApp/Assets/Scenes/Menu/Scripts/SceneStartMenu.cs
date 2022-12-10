using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SceneStartMenu : MonoBehaviour
{
    private void Awake()
    {
        // Get settings values from PlayerPrefs
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
        // Instantiate default menu form
        MenuPrefabChanger.ChangePrefab(MenuPrefabChanger.allPrefabs[2]);
        FileInfo[] fileAmount = new DirectoryInfo(Application.streamingAssetsPath + "/").GetFiles("*.json");                     // Getting all JSON files
        String[] jsonFiles = new String[fileAmount.Length];
        for(int i = 0; i < fileAmount.Length; i++)
        {
            jsonFiles[i] = fileAmount[i].Name;
        }
        Array.Sort(jsonFiles);

        foreach (var item in jsonFiles)
        {
            
            string json = File.ReadAllText(Application.streamingAssetsPath + "/" + item);                 // Read JSON file
            Article go = JsonUtility.FromJson<Article>(json);                                                       // Converting from JSON into class
            Article.sightArticles.Add(go);                                                                          // Adding to array
        }
        var loading = Instantiate(MenuPrefabChanger.allPrefabs[0], MenuPrefabChanger.prefabPlace.transform, false); // Instantiate loading image
        Destroy(loading, 1f);                                                                                       // Destroy loading image
    }
}
