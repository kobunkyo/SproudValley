using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public string changeScene;

    public static GameManager Instance;
    public int maxCorn;
    public int maxTomato;
    public int currCorn;
    public int currTomato;
    public int totalMax;
    public int currMax;

    private void Awake()
    {
        Instance = this;
        currCorn = 0;
        currTomato = 0;
        totalMax = maxCorn + maxTomato;
    }

    void Start()
    {
        
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
