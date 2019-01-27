using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wait : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadGame());

    }
    IEnumerator LoadGame()
    {
        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadScene("Game");
    }
}
