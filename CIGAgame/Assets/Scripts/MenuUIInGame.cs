using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUIInGame : MonoBehaviour
{
    public GameObject PauseUI;
    public GameObject PassUI;

    public void GamePause()//�������л���Ϸ��ͣUI����ʾ״̬
    {
        if (PauseUI.activeInHierarchy || PassUI.activeInHierarchy)
            PauseUI.SetActive(false);
        else
            PauseUI.SetActive(true);
    }
    public void GamePass()//�������л���Ϸ���غ�UI����ʾ״̬
    {
        if (PassUI.activeInHierarchy || PauseUI.activeInHierarchy)
            PassUI.SetActive(false);
        else
            PassUI.SetActive(true);
    }
    public void BackToMainMenu()
    {

    }
    public void RePlay()
    {

    }
    public void NextLeavel()
    {

    }
}
