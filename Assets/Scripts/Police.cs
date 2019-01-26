using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Police : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {
        var target = player.transform.position - transform.position;
        target.y += 1.0f;
 
        transform.Translate(target * Time.deltaTime);
    }
}
