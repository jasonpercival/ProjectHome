using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Van : MonoBehaviour
{

    public float fearIncrease = 0.0005f;

    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {

        Character ps = player.GetComponent<Character>();

        var target = player.transform.position - transform.position;
        if (target.magnitude < 6.0f)
        {
            transform.Translate(target * Time.deltaTime * 0.5f);
            ps.fear += fearIncrease;
            if (ps.fear > 1.0f)
            {
                ps.fear = 1.0f;
            }
        }
        else
        {
            ps.fear -= fearIncrease;
            if (ps.fear < 0)
            {
                ps.fear = 0;
            }
        }
    }
}
