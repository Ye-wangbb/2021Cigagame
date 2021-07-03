using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{

    public void LoadScene(GameObject buttonThis)
    {

        if (buttonThis.GetComponentInChildren<Text>())
        {
            string levelName = buttonThis.GetComponentInChildren<Text>().text;
            if (SceneManager.GetSceneByName(levelName)!= null)
            {
                SceneManager.LoadScene(levelName);

            }
            else
            {
                Debug.LogError("��û�ж�Ӧ�ĳ���");

            }
        }
        else
        {
            Debug.LogError("��ť����û�ж�Ӧ��text���");
        }
    }
}
