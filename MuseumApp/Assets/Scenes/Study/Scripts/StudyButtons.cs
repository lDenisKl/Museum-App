using UnityEngine;

public class StudyButtons : MonoBehaviour
{
    public static void DestroyAll() // Method for destroying all objects on the scene
    {
        for (int i = 0; i < StudyPrefabChanger.prefabPlace.transform.childCount; i++)
        {
            Destroy(StudyPrefabChanger.prefabPlace.transform.GetChild(i).gameObject);
        }
    }

    public void MoveToMenu() // Moving to Menu
    {
        StudyPrefabChanger.ChangePrefab(StudyPrefabChanger.allPrefabs[1]);
        SceneChanger.MoveToAnotherScene(0, 2);
    }

    public void MoveToAnotherPrefab(int number) // Set another prefab
    {
        DestroyAll();
        StudyPrefabChanger.ChangePrefab(StudyPrefabChanger.allPrefabs[number]);
    }

    public void MoveToAnotherPrefabNoDestr(int number) // Set another prefab without destroying active prefab
    {
        StudyPrefabChanger.ChangePrefab(StudyPrefabChanger.allPrefabs[number]);
        
    }

    public void ToDescrp(int number) // Set sight description prefab
    {
        StudyPrefabChanger.ChangePrefab(StudyPrefabChanger.allPrefabs[4]);
        DescriptionController.SetDescription(number);
    }
    
    public void Hide() // Close sight menu
    {
        AnimationController.HideMenu();
        Destroy(gameObject, 1f);
    }

    public void HideDescription() // Close sight description
    {
        AnimationController.HideDescription();
        Destroy(gameObject, 1f);
    }

    public void MoveToSights() // Set article prefab
    {
        DestroyAll();
        StudyPrefabChanger.ChangePrefab(StudyPrefabChanger.articlePrefab);
        ArticleController.SetArticle(gameObject.GetComponent<SightMenuButton>()._sightNumber-1);

        ArticleController.descriptionText.text = ArticleController.descriptionText.text.Replace("NEWLINE","\n\n").Replace("TAB","\t");
    }
}
