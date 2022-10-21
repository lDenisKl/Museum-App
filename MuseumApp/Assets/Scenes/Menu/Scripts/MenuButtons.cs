using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour // ������ � ��������, ������� ����� ����������� �������� ������ ����� Menu
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
    
    public void Quit()
    {
        Application.Quit();
    }
}
