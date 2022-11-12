using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{


    private void Awake()
    {
    }
    
    public static void MoveToAnotherScene(int sceneNum)
    {
        GamePrefabChanger.SetLoadingPicture();
        SceneManager.LoadScene(sceneNum);
    }
}
