using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioScript : MonoBehaviour
{
    [SerializeField]
    AudioSource backgroundSound;
    private AudioSource audioSource;
    private bool radioIsPlay = false;
    private bool interact = false;
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if(audioSource == null)
        {
            Debug.Log("Audio is NULL");
        }
    }

    private void Update()
    {
        RadioInteract();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            interact = true;

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            interact = false;
        }
    }

    private void RadioInteract()
    {
        Debug.Log(Input.GetKey(KeyCode.F));
        if (interact)
        {
            if (Input.GetKey(KeyCode.F) && !radioIsPlay)
            {

                radioIsPlay = !radioIsPlay;
                audioSource.Play();
                backgroundSound.Stop();
            }
            else if (Input.GetKey(KeyCode.F) && radioIsPlay)
            {
                radioIsPlay = !radioIsPlay;
                audioSource.Stop();
                backgroundSound.Play();
            }
        }
    }

}
