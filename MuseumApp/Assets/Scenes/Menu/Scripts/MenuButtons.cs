using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour // ������ � ��������, ������� ����� ����������� �������� ������ ����� Menu
{
    public static void DestroyAll()
    {
        for (int i = 0; i < MenuPrefabChanger.prefabPlace.transform.childCount; i++)
        {
            Destroy(MenuPrefabChanger.prefabPlace.transform.GetChild(i).gameObject);
        }
    }
    public void MoveToPlay() // ����������� �� ������� �����
    {
        MenuPrefabChanger.ChangePrefab(MenuPrefabChanger.allPrefabs[0]);
        SceneChanger.MoveToAnotherScene(1, 0);
        
    }

    public void MoveToAnotherPrefab(int number)
    {
        DestroyAll();
        MenuPrefabChanger.ChangePrefab(MenuPrefabChanger.allPrefabs[number]);
    }

    public void MoveToStudy() // ����������� �� ������� �����
    {
        SceneChanger.MoveToAnotherScene(2, 0);
    }

    public void MoveToSettings()
    {
        DestroyAll();
        MenuPrefabChanger.ChangePrefab(MenuPrefabChanger.allPrefabs[1]);
    }
    
    public void Quit()
    {
        Application.Quit();
    }
}
