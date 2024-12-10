using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainSceneManager : MonoBehaviour
{
    public static MainSceneManager Instance;
    public GameData gameDataGlobal;
    public bool loadRequested;
    public bool shouldLoadPlayerTransform = false;
    public bool shouldLoadTime = false;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        
    }

    public void SaveGame()
    {
        string savePath;

        GameObject player = GameObject.FindGameObjectWithTag("Player");
        string clockUI = "6.00"; // ini gak dibuat uinya jdnya gini aja

        float playerPosX = player.gameObject.transform.position.x;
        float playerPosY = player.gameObject.transform.position.y;
        float playerPosZ = player.gameObject.transform.position.z;
        string timeGame = clockUI;
        string playerName = player.gameObject.name;
        string saveTime = DateTime.Now.ToString();
        string sceneName = SceneManager.GetActiveScene().name;

        GameData gameData = new GameData(playerName, timeGame, saveTime, playerPosX, playerPosY, playerPosZ, sceneName);
        savePath = Path.Combine(Application.persistentDataPath, "savedata.json");

        string jsonData = JsonUtility.ToJson(gameData, true);
        try
        {
            File.WriteAllText(savePath, jsonData);
            Debug.Log("Save berhasil dan berada di " + savePath);
        }
        catch (Exception e)
        {
            Debug.LogError(e.Message);
        }

    }

    public void LoadGame()
    {
        string savePath;
        savePath = Path.Combine(Application.persistentDataPath, "savedata.json");
        if (File.Exists(savePath))
        {
            string jsonData = File.ReadAllText(savePath);
            gameDataGlobal = JsonUtility.FromJson<GameData>(jsonData);

            SceneManager.LoadScene(gameDataGlobal.sceneName);

            loadRequested = true;
            shouldLoadPlayerTransform = true;
            shouldLoadTime = true;
        }
        else
        {
            Debug.LogError("ERROR save not found");
        }
    }

    public void ResetLoadFlags()
    {
        loadRequested = false;
        shouldLoadPlayerTransform = false;
        shouldLoadTime = false;
    }
}
