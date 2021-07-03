using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        SceneManager.LoadScene("StartMenu");

    }
    public void RePlay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void NextLeavel()
    {
        string nextLevelName = SceneManager.GetActiveScene().name;
        nextLevelName = nextLevelName.Replace(nextLevelName[nextLevelName.Length - 1], (char)(nextLevelName[nextLevelName.Length - 1] + 1));
        if (SceneManager.GetSceneByName(nextLevelName) != null)
        {
            SceneManager.LoadScene(nextLevelName);

        }
        else
        {

            Debug.LogError("��û�ж�Ӧ�ĳ���");

        }
    }
}
