using UnityEngine;

public class StudySceneStar : MonoBehaviour
{
    private void Start()
    {
        
        var load = Instantiate(StudyPrefabChanger.allPrefabs[1], StudyPrefabChanger.prefabPlace.transform, false);
        Destroy(load, 1f);
    }
}
