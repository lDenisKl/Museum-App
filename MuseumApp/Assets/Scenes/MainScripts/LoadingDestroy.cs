using UnityEngine;

public class LoadingDestroy : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 1f); // Destroy loading picture after 0.5 seconds
    }
}
