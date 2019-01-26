using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTest : MonoBehaviour
{
    FloatingTextManager ftm;

    // Start is called before the first frame update
    void Start()
    {
        ftm = GameObject.Find("FloatingTextManager").GetComponent<FloatingTextManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            ftm.Show("I wonder what's inside that box...", 20, Color.yellow, transform.position, Vector3.up * 25, 2.0f);
        }
    }
}
