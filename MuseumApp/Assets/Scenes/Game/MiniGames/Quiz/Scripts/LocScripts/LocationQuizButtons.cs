using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LocationQuizButtons : MonoBehaviour
{
    public int id;
    public void ClickAnswer()
    {
        if (id == LocationQuizController.rightSightId)
        {
            LocationQuizController.ansImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Icons/yes");
            LocationQuizController.wins++;
            LocationQuizController.answersCount.text = $"{LocationQuizController.wins}/10";
            if (LocationQuizController.wins == 10)
            {
                LocationQuizController.usedIds.Clear();
                LocationQuizController.usedIdsOnce.Clear();
                GamePrefabChanger.ChangePrefab(GamePrefabChanger.winPrefabs[3]);
            }
            LocationQuizController.usedIdsOnce.Clear();
            LocationQuizController.SetQuiz();
        }
        else
        {
            LocationQuizController.ansImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Icons/no");
            LocationQuizController.lifes--;
            LocationQuizController.lifesCount.text = $"{LocationQuizController.lifes}";
            if (LocationQuizController.lifes == 0)
            {
                GamePrefabChanger.ChangePrefab(GamePrefabChanger.winPrefabs[3]);
            }
            gameObject.GetComponentInChildren<TextMeshProUGUI>().color = Color.grey;
            gameObject.GetComponent<Button>().enabled = false;
        }
    }
}
