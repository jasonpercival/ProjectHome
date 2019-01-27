using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Market : MonoBehaviour
{
    public GameObject blockade;
    public GameObject vanTrigger;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            FloatingTextManager ftm = GameObject.Find("FloatingTextManager").GetComponent<FloatingTextManager>();
            ftm.Show("Got the stuff! ... better head home now.", 25, Color.green, transform.position, Vector3.up * 25, 5.0f);

            // activate barrier
            //if (blockade)
            //{
                blockade.SetActive(true);
            //}
            // activate van trigger
            if (vanTrigger)
            {
                vanTrigger.SetActive(true);
            }

        }
    }
}
