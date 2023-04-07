using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PhotoQuizStart : MonoBehaviour
{
    private static int prevId;
    public static GameObject ansImage;
    public GameObject _ansImage;
    public static TextMeshProUGUI questionText;
    public TextMeshProUGUI _questionText;
    public static GameObject[] answers;
    public GameObject[] _answers;
    public static int rightSightId;

    void Awake()
    {
        ansImage = _ansImage;
        answers = _answers;
        questionText = _questionText;
        SetQuiz();
    }
    public static void SetQuiz()
    {
        List<int> a = new List<int>();
        rightSightId = Random.Range(0, Article.sightArticles.Count);
        while (rightSightId == prevId)
        {
            rightSightId = Random.Range(0, Article.sightArticles.Count);
        }
        prevId = rightSightId;
        int rightImageId = Random.Range(0, 4);
        string question = Article.sightArticles[rightSightId].ExtraInf;
        questionText.text = question;
        answers[rightImageId].GetComponent<Image>().sprite = (Sprite)Resources.LoadAll(Article.sightArticles[rightSightId].PhotoPath)[10];
        answers[rightImageId].GetComponent<QuizButton>().id = rightSightId;
        a.Add(rightSightId);
        for (int i = 0; i<4; i++)
        {
            if (i == rightImageId)
            {
                continue;
            }
            int photoId = Random.Range(0, Article.sightArticles.Count);
            while(a.Contains(photoId))
            {
                photoId = Random.Range(0, Article.sightArticles.Count);
            }
            answers[i].GetComponent<Image>().sprite = (Sprite)Resources.LoadAll(Article.sightArticles[photoId].PhotoPath)[10];
            answers[i].GetComponent<QuizButton>().id = photoId;
            a.Add(photoId);
        }
    }
}
