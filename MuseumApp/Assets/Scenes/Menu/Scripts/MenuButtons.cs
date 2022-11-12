using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour // ������ � ��������, ������� ����� ����������� �������� ������ ����� Menu
{
    public void MoveToPlay() // ����������� �� ������� �����
    {
        MenuPrefabChanger.ChangePrefab(MenuPrefabChanger.allPrefabs[0]);
        SceneChanger.MoveToAnotherScene(1, 0);
        
    }

    public void MoveToStudy() // ����������� �� ������� �����
    {
        SceneChanger.MoveToAnotherScene(2, 0);
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
