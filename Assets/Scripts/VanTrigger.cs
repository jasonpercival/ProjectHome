using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanTrigger : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip normalMusic;
    public AudioClip fearMusic;
    public GameObject fearMeter;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameObject.Find("Van").GetComponent<Van>().enabled = true;
            collision.GetComponent<CountDown>().enabled = true;
            fearMeter.SetActive(true);

            // trigger fear music
            if (audioSource)
            {
                audioSource = collision.GetComponent<AudioSource>();
                audioSource.Stop();
                audioSource.clip = fearMusic;
                audioSource.Play();
            }
        }
    }
}
