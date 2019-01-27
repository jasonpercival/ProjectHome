using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameObject.Find("Van").GetComponent<Van>().enabled = true;
        }
    }
}
