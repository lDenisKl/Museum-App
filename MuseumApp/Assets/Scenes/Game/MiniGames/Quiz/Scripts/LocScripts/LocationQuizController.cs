using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LocationQuizController : MonoBehaviour
{
    private static int rightLocationId;
    public static List<int> usedIds = new List<int>();
    public static List<int> usedIdsOnce = new List<int>();
    public static int lifes;
    public static int wins;
    public static GameObject ansImage;
    public GameObject _ansImage;
    public static GameObject questionImage;
    public GameObject _questionImage;
    public static Text questionText;
    public Text _questionText;
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
        questionText = _questionText;
        answersCount.text = "0/10";
        lifesCount.text = "3";
        answers = _answers;
        ansImage = _ansImage;
        questionImage = _questionImage;
        SetQuiz();
    }
    public static void SetQuiz()
    {
        usedIdsOnce.Clear();
        Debug.Log("inSet");
        rightSightId = Random.Range(0, Article.sightArticles.Count);
        while (usedIds.Contains(rightSightId))
        {
            rightSightId = Random.Range(0, Article.sightArticles.Count);
        }
        usedIds.Add(rightSightId);
        usedIdsOnce.Add(rightSightId);
        rightLocationId = Random.Range(0, 4);
        questionImage.GetComponent<Image>().sprite = Resources.LoadAll<Sprite>(Article.sightArticles[rightSightId].PhotoPath)[9];
        questionText.text = Article.sightArticles[rightSightId].Name;
        answers[rightLocationId].GetComponentInChildren<TextMeshProUGUI>().text = Article.sightArticles[rightSightId].ExtraInf.Replace("Расположение:", "");
        answers[rightLocationId].GetComponent<Button>().enabled = true;
        answers[rightLocationId].GetComponent<LocationQuizButtons>().id = rightSightId;
        for (int i = 0; i < 4; i++)
        {
            if (i == rightLocationId)
            {
                answers[i].GetComponentInChildren<TextMeshProUGUI>().color = Color.white;
                continue;
            }
            int answerId = Random.Range(0, Article.sightArticles.Count);
            while (usedIdsOnce.Contains(answerId))
            {
                answerId = Random.Range(0, Article.sightArticles.Count);
            }
            TextMeshProUGUI s = answers[i].GetComponentInChildren<TextMeshProUGUI>();
            s.text = Article.sightArticles[answerId].ExtraInf.Replace("Расположение:", "");
            answers[i].GetComponentInChildren<TextMeshProUGUI>().color = Color.white;
            answers[i].GetComponent<Button>().enabled = true;
            answers[i].GetComponent<LocationQuizButtons>().id = answerId;
            usedIdsOnce.Add(answerId);
        }
        usedIdsOnce.Clear();
    }
}
