using UnityEngine;

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
    public void ToDescrp(int number)
    {
        StudyPrefabChanger.ChangePrefab(StudyPrefabChanger.allPrefabs[4]);
        DescriptionController.SetDescription(number);
    }
    
    public void Hide()
    {
        AnimationController.HideMenu();
        Destroy(gameObject, 1f);
    }
    public void HideDescription()
    {
        AnimationController.HideDescription();
        Destroy(gameObject, 1f);
    }

    public void MoveToSights()
    {
        DestroyAll();
        StudyPrefabChanger.ChangePrefab(StudyPrefabChanger.sightsPrefabs[0]);
        ArticleController.SetArticle(gameObject.GetComponent<SightMenuButton>()._sightNumber-1);
    }
}
