using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotoQuizStart : MonoBehaviour
{
    public static Text questionText;
    public Text _questionText;
    public static Image[] answers;
    public Image[] _answers;

    void Awake()
    {
        answers = _answers;
        questionText = _questionText;
        SetQuiz();
    }
    private void SetQuiz()
    {
        List<int> a = new List<int>();
        int rightSightId = Random.Range(0, Article.sightArticles.Count);
        int rightImageId = Random.Range(0, 4);
        string question = Article.sightArticles[rightSightId].ExtraInf;
        questionText.text = question;
        answers[rightImageId].sprite = (Sprite)Resources.LoadAll(Article.sightArticles[rightSightId].PhotoPath)[10];
        for(int i = 0; i<4; i++)
        {
            if (i == rightImageId)
            {
                continue;
            }
            int photoId = Random.Range(0, Article.sightArticles.Count);
            while(a.Contains(photoId) || a.Contains(rightSightId))
            {
                photoId = Random.Range(0, Article.sightArticles.Count);
            }
            answers[i].sprite = (Sprite)Resources.LoadAll(Article.sightArticles[photoId].PhotoPath)[10];
            Debug.Log("set");
            a.Add(photoId);
        }
    }
}
