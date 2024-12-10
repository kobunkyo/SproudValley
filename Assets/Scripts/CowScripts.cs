using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowScripts : MonoBehaviour
{
    private AudioSource audioSource;
    private bool isTrigger = false;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        CowInteract();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isTrigger = true;

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isTrigger = false;
        }
    }

    private void CowInteract()
    {
        Debug.Log(Input.GetKey(KeyCode.F));
        Debug.Log($"isTrigger: {isTrigger}");
        if (isTrigger)
        {
            if (Input.GetKey(KeyCode.F))
            {
                audioSource.Play();
            }
        }
    }
}
