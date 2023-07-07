using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Data;
using Mono.Data;
using Mono.Data.Sqlite;

public class DBManager : MonoBehaviour
{
    private static string connectionString;
    void Start()
    {
        Article.sightArticles.Clear();
        connectionString = "Data Source="+Application.streamingAssetsPath+"/sqlite(1).db";//"Data Source="+ Application.dataPath + "/sql.db";
        Debug.Log(connectionString);
        GetSights();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void InsertSight(string name, string description, string extraInf, string photoPath)
    {
        using (IDbConnection dbConnection = new SqliteConnection(connectionString))
        {
            dbConnection.Open();
            using (IDbCommand dbCommand = dbConnection.CreateCommand())
            {
                string sqlQuery = String.Format("INSERT INTO sights(name, description, extraInf, photoPath) VALUES(\"{0}\", \"{1}\", \"{2}\", \"{3}\")", name, description, extraInf, photoPath);
                dbCommand.CommandText = sqlQuery;
                dbCommand.ExecuteScalar();
                dbConnection.Close();
            }
        }
    }
    public static void GetSights() 
    {
        using (IDbConnection dbConnection = new SqliteConnection(connectionString))
        {
            dbConnection.Open();
            using (IDbCommand dbCommand = dbConnection.CreateCommand())
            {
                string sqlQuery = "SELECT * FROM sights";
                dbCommand.CommandText = sqlQuery;
                using (IDataReader reader = dbCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Article.sightArticles.Add(new Article(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4)));
                    }
                    dbConnection.Close();
                    reader.Close();
                }
            }
        }
    }
}
