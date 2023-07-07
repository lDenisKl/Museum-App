using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.MemoryProfiler;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    private const string _connectionProperties = "server=rc1b-n4kvp3yklxkjhnvz.mdb.yandexcloud.net;port=3306;user=Kvantorianec;database=SmartBusinessDB;password=uzer1pass;CharSet=utf8";
    public static List<string> lol = new List<string>();
    private void Awake()
    {
        lol.Append("out");
        lol.Append("in");
    }
    public static void DestroyAll() // Method for destroying all objects on the scene
    {
        for (int i = 0; i < MenuPrefabChanger.prefabPlace.transform.childCount; i++)
        {
            Destroy(MenuPrefabChanger.prefabPlace.transform.GetChild(i).gameObject);
        }
    }

    public static void Time()
    {
        lol.Add("out");
        lol.Add("in");
        MySqlConnection _connection = new MySqlConnection(_connectionProperties);
        for (int j = 11; j < 26; j++)
        {
            for (int i = 7; i < 23; i+=2)
            {
                _connection.Open();
                string g = $"INSERT INTO machineWorkPull(idMachine, dateStart, dateEnd, state) VALUES(\"26\", \"2023-05-{j}T{i}:{Random.Range(1, 55)}:18\", \"2023-05-{j}T{i+1}:{Random.Range(1,55)}:32\", \"var\")";
                var command1 = new MySqlCommand(g, _connection);
                var read11 = command1.ExecuteReader();
                _connection.Close();
                
            }
        }
        
    }
    public void MoveToPlay() // Move to Play scene
    {
        MenuPrefabChanger.ChangePrefab(MenuPrefabChanger.allPrefabs[0]);
        SceneChanger.MoveToAnotherScene(1, 0);
    }

    public void MoveToAnotherPrefab(int number) // Set another prefab
    {
        DestroyAll();
        MenuPrefabChanger.ChangePrefab(MenuPrefabChanger.allPrefabs[number]);
    }

    public void MoveToStudy() // Move to Study scene
    {
        MenuPrefabChanger.ChangePrefab(MenuPrefabChanger.allPrefabs[0]);
        SceneChanger.MoveToAnotherScene(2, 0);
    }
    
    public void SwitchTips() // Method for swiching tips with toggle
    {
        if (SettingsController.tipToggle1.isOn)
        {
            SettingsController.isTipOn = false;
            PlayerPrefs.SetInt("tip", 0);
        }
        else
        {
            SettingsController.isTipOn = true;
            PlayerPrefs.SetInt("tip", 1);
        }
    }

    public void ControllVolume() // Method, controlling volume
    {
        SettingsController.volume = SettingsController.volumeSlider.value; // Getting value from toogle and setting it in volume variable
        AudioListener.volume = SettingsController.volume;                  // Setting audiolistener volume
        PlayerPrefs.SetFloat("volume", SettingsController.volume);         // Saving volume variable
    }

    public void Quit()
    {
        Application.Quit();
    }
}
