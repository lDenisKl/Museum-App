using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PhotoQuizStart : MonoBehaviour
{
    private static int rightImageId;
    private static string question;
    public static List<int> usedIds = new List<int>();
    public static List<int> a = new List<int>();
    public static int lifes;
    public static int wins;
    public static GameObject ansImage;
    public GameObject _ansImage;
    public static TextMeshProUGUI questionText;
    public TextMeshProUGUI _questionText;
    public static Text answersCount;
    public Text _answersCount;
    public static Text lifesCount;
    public Text _lifesCount;
    public static GameObject[] answers;
    public GameObject[] _answers;
    public static int rightSightId;

    void Awake()
    {
        wins = 0;
        lifes = 3;
        lifesCount = _lifesCount;
        answersCount = _answersCount;
        answersCount.text = "0/10";
        lifesCount.text = "3";
        ansImage = _ansImage;
        answers = _answers;
        questionText = _questionText;
        SetQuiz();
    }
    public static void SetQuiz()
    {
        a.Clear();
        Debug.Log("inSet");
        rightSightId = Random.Range(0, Article.sightArticles.Count);
        while (usedIds.Contains(rightSightId))
        {
            rightSightId = Random.Range(0, Article.sightArticles.Count);
        }
        usedIds.Add(rightSightId);
        a.Add(rightSightId);
        rightImageId = Random.Range(0, 4);
        question = Article.sightArticles[rightSightId].ExtraInf;
        questionText.text = question;
        answers[rightImageId].GetComponent<Image>().sprite = (Sprite)Resources.LoadAll(Article.sightArticles[rightSightId].PhotoPath)[10];
        answers[rightImageId].GetComponent<QuizButton>().id = rightSightId;
        for (int i = 0; i<4; i++)
        {
            if (i == rightImageId)
            {
                continue;
            }
            int photoId = Random.Range(0, Article.sightArticles.Count);
            while (a.Contains(photoId))
            {
                photoId = Random.Range(0, Article.sightArticles.Count);
            }
            Image s = answers[i].GetComponent<Image>();
            s.sprite = (Sprite)Resources.LoadAll(Article.sightArticles[photoId].PhotoPath)[10];
            s.color = Color.white;
            answers[i].GetComponent<Button>().enabled = true;
            answers[i].GetComponent<QuizButton>().id = photoId;
            a.Add(photoId);
        }
        a.Clear();
    }
}
