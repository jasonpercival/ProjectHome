﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{

    public float speed = 5.0f;

    Animator animator;
    Rigidbody2D rb;
    SpriteRenderer spriteRenderer;
    bool facingRight = true;

    public FloatingTextManager ftm;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        ftm = GameObject.Find("FloatingTextManager").GetComponent<FloatingTextManager>();
        Vector3 offset = new Vector3(0, 0.25f, 0);
        ftm.Show("I better get to the store...", 20, Color.green, transform.position+offset, Vector3.up * 25, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxisRaw("Horizontal");
        float verticalMovement = Input.GetAxisRaw("Vertical");

        if (horizontalMovement != 0)
        {
            facingRight = (horizontalMovement > 0);
        }

        spriteRenderer.flipX = !facingRight;

        Vector2 movement = new Vector2(horizontalMovement * speed , verticalMovement * speed );
        rb.velocity = movement;

        animator.SetFloat("movement", Mathf.Abs(horizontalMovement));
        animator.SetFloat("verticalmovement", verticalMovement);
        
    }
}
