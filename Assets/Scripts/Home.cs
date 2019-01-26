using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Home : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            FloatingTextManager ftm = GameObject.Find("FloatingTextManager").GetComponent<FloatingTextManager>();
            ftm.Show("The door is locked.", 20, Color.red, transform.position, Vector3.up * 25, 3.0f);
        }
    }
}
