using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterManager : MonoBehaviour
{

    public static CounterManager Instance;
    [SerializeField]
    Text corn;

    [SerializeField]
    Text tomato;

    [SerializeField]
    Text life;

    private int maxCorn, maxTomato;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        maxCorn = GameManager.Instance.maxCorn;
        maxTomato = GameManager.Instance.maxTomato;
    }

    // Update is called once per frame
    void Update()
    {
        corn.text = maxCorn.ToString();
        tomato.text = maxTomato.ToString();
        life.text = PlayerLife.Instances.maxAnnoyanceHit.ToString();
    }

    public void CornPlus()
    {
        maxCorn--;
    }

    public void TomatoPlus()
    {
        maxTomato--;
    }


}
