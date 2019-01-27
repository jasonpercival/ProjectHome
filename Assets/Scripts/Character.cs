using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    public float speed = 5.0f;
    public float fear = 0.0f;
    public GameObject fearSlider;
    public GameObject map;

    Animator animator;
    Rigidbody2D rb;
    SpriteRenderer spriteRenderer;
    bool facingRight = true;

    public FloatingTextManager ftm;
    bool isMapActive = false;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        ftm = GameObject.Find("FloatingTextManager").GetComponent<FloatingTextManager>();
        Vector3 offset = new Vector3(0, 0.25f, 0);
        //ftm.Show("I better get to the store...", 25, Color.green, transform.position+offset, Vector3.up * 25, 3.0f);
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

        if (Input.GetButtonUp("Jump"))
        {
            isMapActive = !isMapActive;
            map.SetActive(isMapActive);
        }

        spriteRenderer.flipX = !facingRight;

        Vector2 movement = new Vector2(horizontalMovement * speed , verticalMovement * speed );
        rb.velocity = movement;

        animator.SetFloat("movement", Mathf.Abs(horizontalMovement));
        animator.SetFloat("verticalmovement", verticalMovement);

        if (fearSlider)
        {
            var slider = fearSlider.GetComponent<Slider>();
            slider.value = fear;
        }

        Color ambient = new Vector4(1.0f - fear, 1.0f - fear, 1.0f - fear, 1.0f);
        RenderSettings.ambientLight = ambient;
        //spotLight.SetActive(true);

    }
}
