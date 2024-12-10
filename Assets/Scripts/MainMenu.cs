using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private AudioSource audioSource;
    private bool isPlay = false;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void PlayGame()
    {
        //if (MainSceneManager.Instance.shouldLoadPlayerTransform)
        //{
        //    transform.position = new Vector3(MainSceneManager.Instance.gameDataGlobal.playerPosX, MainSceneManager.Instance.gameDataGlobal.playerPosY, MainSceneManager.Instance.gameDataGlobal.playerPosZ);
        //    MainSceneManager.Instance.shouldLoadPlayerTransform = false;
        //}

        if (MainSceneManager.Instance != null)
        {
            MainSceneManager.Instance.ResetLoadFlags();
        }
        SceneManager.LoadSceneAsync("Level1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadSceneAsync("Main Menu");
    }

    public void PlaySound()
    {
        audioSource.Play();
    }
}
