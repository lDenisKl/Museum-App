using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

public class SightMenu : MonoBehaviour
{
    public Button button;
    public Transform place;

    private void Awake()
    {
        int sightAmount = Article.sightArticles.Count;
        for (int i = 0; i < sightAmount; i++)
        {
            var go = Instantiate(button, place, false);
            go.GetComponent<SightMenuButton>()._sightNumber = i+1;
            go.GetComponent<SightMenuButton>()._buttonText.text = Article.sightArticles[i].Name;
        }
        
    }
}
