using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
    [SerializeField] float speed=10f;
    [SerializeField] float jumpForce = 5f;
    Rigidbody2D rb;
    Animator anim;

    bool grounded;
    bool started;
    bool jumping;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();//caching:ram de h�zl�ca bulabilmek i�in.
        anim = GetComponent<Animator>();
        grounded = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (started && grounded)//yerdeysek ve oyun ba�lad�ysa z�plama olsun.
            {
                anim.SetTrigger("Jump");
                grounded = false;
                jumping = true;
            }
            else
            {
                anim.SetBool("GameStarted", true);
                started = true;
            }
        }
        anim.SetBool("Grounded", grounded);
    }
    private void FixedUpdate()
    {
        //oyun ba�lad�ysa karaktere h�z vermeliyiz.
        if (started)
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);//rigidbody ye bir h�z verisi girece�iz.//y=h�z ne ise ayn� kals�n.
        }
        if (jumping)//yukaru g�� uygulanmal�.
        {
            rb.AddForce(new Vector2(0f, jumpForce));
            jumping = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)//e�er bir yere �ap�yorsa run metoduna geri d�n. yere d���nce z�plama durmal�.
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            grounded = true;
        }
    }
}
