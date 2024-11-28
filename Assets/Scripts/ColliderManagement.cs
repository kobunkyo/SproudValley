using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderManagement : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log($"Tag {collision.gameObject.tag}");
        if (collision.gameObject.CompareTag("Player"))
        {
            if (gameObject.CompareTag("Corn"))
            {
                GameManager.Instance.currCorn++;
                GameManager.Instance.currMax++;
                Debug.Log($"Current Corn: {GameManager.Instance.currCorn}, Max Corn: {GameManager.Instance.maxCorn}");
                Destroy(gameObject);
                CounterManager.Instance.CornPlus();
            }
            else if (gameObject.CompareTag("Tomato"))
            {
                GameManager.Instance.currTomato++;
                GameManager.Instance.currMax++;
                Debug.Log($"Current Tomato: {GameManager.Instance.currTomato}, Max Tomato: {GameManager.Instance.maxTomato}");
                Destroy(gameObject);
                CounterManager.Instance.TomatoPlus();
            }
            if(GameManager.Instance.currMax == GameManager.Instance.totalMax)
            {
                GameManager.Instance.ChangeScene(GameManager.Instance.changeScene.ToString());
            }
            
            
            
        }
    }
}
