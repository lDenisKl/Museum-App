using UnityEngine;
using UnityEngine.UI;

public class QuizButton : MonoBehaviour
{
    public int id;
    public void ClickAnswer()
    {
        if (id == PhotoQuizStart.rightSightId)
        {
            PhotoQuizStart.ansImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Icons/yes");
            PhotoQuizStart.wins++;
            PhotoQuizStart.answersCount.text = $"{PhotoQuizStart.wins}/10";
            if (PhotoQuizStart.wins==10)
            {
                PhotoQuizStart.usedIds.Clear();
                PhotoQuizStart.a.Clear();
                GamePrefabChanger.ChangePrefab(GamePrefabChanger.winPrefabs[3]);
            }
            PhotoQuizStart.a.Clear();
            PhotoQuizStart.SetQuiz();
        }
        else 
        {
            PhotoQuizStart.ansImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Icons/no");
            PhotoQuizStart.lifes--;
            PhotoQuizStart.lifesCount.text = $"{PhotoQuizStart.lifes}";
            if (PhotoQuizStart.lifes == 0)
            {
                GamePrefabChanger.ChangePrefab(GamePrefabChanger.winPrefabs[3]);
            }
            gameObject.GetComponent<Image>().color = Color.grey;
            gameObject.GetComponent<Button>().enabled = false;
        }
    }
}
