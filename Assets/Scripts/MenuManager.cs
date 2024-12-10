using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public void SaveGame()
    {
        MainSceneManager.Instance.SaveGame();
    }

    public void LoadGame()
    {
        MainSceneManager.Instance.LoadGame();
    }
}
