
using UnityEngine;
using static UnityEngine.UI.Button;

public class StudyButtons : MonoBehaviour
{
    public static void DestroyAll()
    {
        for (int i = 0; i < StudyPrefabChanger.prefabPlace.transform.childCount; i++)
        {
            Destroy(StudyPrefabChanger.prefabPlace.transform.GetChild(i).gameObject);
        }
    }
    public void MoveToMenu()
    {
        StudyPrefabChanger.ChangePrefab(StudyPrefabChanger.allPrefabs[1]);
        SceneChanger.MoveToAnotherScene(0, 2);
    }

    public void MoveToAnotherPrefab(int number)
    {
        DestroyAll();
        StudyPrefabChanger.ChangePrefab(StudyPrefabChanger.allPrefabs[number]);
    }

    public void MoveToAnotherPrefabNoDestr(int number)
    {
        StudyPrefabChanger.ChangePrefab(StudyPrefabChanger.allPrefabs[number]);
    }
    
    public void Hide()
    {
        AnimationController.HideMenu();
        Destroy(gameObject, 1.3f);
    }

    public void MoveToArticle(int number)
    {
        DestroyAll();
        StudyPrefabChanger.ChangePrefab(StudyPrefabChanger.articlePrefabs[number]);
    }

    public void MoveToSights()
    {
        DestroyAll();
        StudyPrefabChanger.ChangePrefab(StudyPrefabChanger.sightsPrefabs[0]);
        ArticleController.SetArticle(gameObject.GetComponent<SightMenuButton>()._sightNumber+1);
    }
}
