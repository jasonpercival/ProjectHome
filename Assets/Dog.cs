using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            FloatingTextManager ftm = GameObject.Find("FloatingTextManager").GetComponent<FloatingTextManager>();
            ftm.Show("*WOOF* *WOOF*", 25, Color.green, transform.position, Vector3.up * 25, 2.0f);
        }
    }
}
