using UnityEngine;
using UnityEngine.UI;

public class QuizButton : MonoBehaviour
{
    public int id;
    public AnimationClip ansAnim;
    public void ClickAnswer()
    {
        if (id == PhotoQuizStart.rightSightId)
        {
            PhotoQuizStart.ansImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Icons/yes");
            //PhotoQuizStart.ansImage.GetComponent<Animator>().Play("ansAnim");
            PhotoQuizStart.SetQuiz();
        }
        else 
        {
            PhotoQuizStart.ansImage.GetComponent<Image>().sprite = Resources.Load<Sprite>("Icons/no");
            //PhotoQuizStart.ansImage.GetComponent<Animator>().Play("ansAnim");
        }
    }
}
