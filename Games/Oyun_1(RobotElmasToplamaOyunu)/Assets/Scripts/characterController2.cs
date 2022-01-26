using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController2 : MonoBehaviour
{
    public float jumpForce=150.0f;
    public float speed=1.0f;
    float moveDirection;//y�nlenme de�i�keni

    bool moving;
    bool jump;
    bool grounded=true;
    Rigidbody2D rigitbody2;
    Animator anim;
    SpriteRenderer spriteRenderer;

    private void Awake()
    {
        anim = GetComponent<Animator>();//caching animator.
    }


    void Start()
    {
        rigitbody2 = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>(); 
    }

    private void FixedUpdate()
    {
        //karakterimizin hareket edip etmedi�ini rigitbody n�n velocity sinden anlayabiliriz.
        if (rigitbody2.velocity != Vector2.zero)//eger velocity s�f�r de�ilse 
        {
            moving = true;//hareket ediyorum.
        }
        else
        {
            moving = false;
        }
        rigitbody2.velocity = new Vector2(speed * moveDirection, rigitbody2.velocity.y);
        if (jump == true)
        {
            rigitbody2.velocity = new Vector2(rigitbody2.velocity.x, jumpForce);
            jump = false;
        }
    }

    void Update()
    {
        //karakter yerde ise saga sola hareket edebilir.
        if (grounded == true && Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)){//hareket sa�lamal�y�m
            if (Input.GetKey(KeyCode.A))//h�z�m ters tarafa gitmeli.
            {
                moveDirection = -1.0f;
                spriteRenderer.flipX = true;
                anim.SetFloat("speed", speed);
            }
            else if(Input.GetKey(KeyCode.D))
            {
                moveDirection = 1.0f;
                spriteRenderer.flipX = false;
                anim.SetFloat("speed", speed);
            }
        }else if (grounded == true)//sadece yerdeysem yani bir tusa basm�yorsam
        {
            moveDirection = 0.0f;
            anim.SetFloat("speed", 0.0f);
        }

        if (grounded == true && Input.GetKey(KeyCode.W))
        {
            jump = true;
            grounded = false;
            anim.SetTrigger("jump");
            anim.SetBool("grounded", false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "zemin")
        {
            anim.SetBool("grounded", true);
            grounded = true;
        }
        
    }
}
