using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class GameData
{
    public string playerName;
    public string timeGame;
    public string saveTime;
    public float playerPosX;
    public float playerPosY;
    public float playerPosZ;
    public string sceneName;

    public GameData(string playerName, string timeGame, string saveTime, float playerPosX, float playerPosY, float playerPosZ, string sceneName)
    {
        this.playerName = playerName;
        this.timeGame = timeGame;
        this.saveTime = saveTime;
        this.playerPosX = playerPosX;
        this.playerPosY = playerPosY;
        this.playerPosZ = playerPosZ;
        this.sceneName = sceneName;
    }

    public override string ToString()
    {
        return $"Name: {playerName}, PlayerPosX: {playerPosX}, PlayerPosY: {playerPosY}, PlayerPosZ: {playerPosZ}, sceneName: {sceneName}";
    }

}
