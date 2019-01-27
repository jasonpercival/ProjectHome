using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTest : MonoBehaviour
{
    public GameObject spotLight;
    public FloatingTextManager ftm;
    
    // Start is called before the first frame update
    void Start()
    {
        if (!ftm)
        {
            ftm = GameObject.Find("FloatingTextManager").GetComponent<FloatingTextManager>();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            ftm.Show("Hmmm... is this the right way?", 25, Color.green, transform.position, Vector3.up * 25, 4.0f);

            ///RenderSettings.ambientLight = Color.black;
            //spotLight.SetActive(true);

        }
    }
}
