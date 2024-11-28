using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public static PlayerLife Instances;
    public int maxAnnoyanceHit;

    private void Awake()
    {
        Instances = this;
        maxAnnoyanceHit = 3;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(maxAnnoyanceHit <= 0)
        {
            SceneManager.LoadSceneAsync("Game Over");
        }
    }

    public void AnnoyanceHit()
    {
        maxAnnoyanceHit--;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Chicken") || collision.gameObject.CompareTag("Cow"))
        {
            AnnoyanceHit();
        }
    }
}
