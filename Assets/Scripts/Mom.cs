using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mom : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            FloatingTextManager ftm = GameObject.Find("FloatingTextManager").GetComponent<FloatingTextManager>();

            if (GameObject.Find("Van").GetComponent<Van>().enabled)
            {
                ftm.Show("You're the best son. I'm glad you made it home safe.", 15, Color.green, transform.position, Vector3.up * 25, 6.0f);
                StartCoroutine(RestartGame());
            }
            else
            {
                ftm.Show("Hey boy, can you stop by the market and pickup some groceries. Don't be late!", 14, Color.green, transform.position, Vector3.up * 25, 8.0f);
            }
        }
    }

    IEnumerator RestartGame()
    {
        yield return new WaitForSeconds(8.0f);
        SceneManager.LoadScene(0);
    }
}
