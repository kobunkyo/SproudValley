using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSceneManager : MonoBehaviour
{
    public LoadGameUIManager loadGameUIManager;

    void StartGame()
    {
        if (GameManager.Instance != null)
        {

        }
        else
        {
            GameManager.Instance.ChangeScene("MainMenu");
        }
    }

    public void LoadGame()
    {
        loadGameUIManager.ActivateCanvas();
    }

}
