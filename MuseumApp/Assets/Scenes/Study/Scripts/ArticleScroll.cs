
using UnityEngine;
using UnityEngine.UI;

public class ArticleScroll : MonoBehaviour
{
    [SerializeField]
    private Scrollbar bar;
    private void Start()
    {
        bar.value = 1;
    }
}
