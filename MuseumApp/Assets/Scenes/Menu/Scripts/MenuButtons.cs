using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    public void MoveToPlay() // ����������� �� ������� �����
    {
        SceneChanger.MoveToAnotherScene(1);
    }

    public void MoveToStudy() // ����������� �� ������� �����
    {
        SceneChanger.MoveToAnotherScene(2);
    }

    public void MoveToSettings()
    {
        // ������������� ������� ��������
    }
}
