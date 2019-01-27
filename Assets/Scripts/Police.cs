using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Police : MonoBehaviour
{
    GameObject player;
    bool policeActivated = false;

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

        if (target.magnitude < 2.0f && !policeActivated)
        {
            policeActivated = true;
            FloatingTextManager ftm = GameObject.Find("FloatingTextManager").GetComponent<FloatingTextManager>();
            ftm.Show("It's way past your curfew kid!", 20, Color.red, transform.position, Vector3.up * 25, 5.0f);
            StartCoroutine(RestartGame());
        }
    }

    IEnumerator RestartGame()
    {
        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadScene(0);
    }
}
