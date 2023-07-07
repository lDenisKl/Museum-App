using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SightMapController : MonoBehaviour
{
    public static Transform PrefabPlace;
    public Transform prefabPlace;
    public static GameObject SightMap;
    public GameObject sightMap;

    private void Awake()
    {
        prefabPlace = PrefabPlace;
        sightMap = SightMap;
    }
}
