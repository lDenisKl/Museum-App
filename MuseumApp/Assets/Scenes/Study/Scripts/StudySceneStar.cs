using UnityEngine;

public class StudySceneStar : MonoBehaviour
{
    private void Start()
    {
        var load = Instantiate(StudyPrefabChanger.allPrefabs[1], StudyPrefabChanger.prefabPlace.transform, false);  // Instantiate loading image
        Destroy(load, 1f);                                                                                          // Destroy loading image

    }
}
