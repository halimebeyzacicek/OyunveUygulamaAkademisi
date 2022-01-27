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
        rb = GetComponent<Rigidbody2D>();//caching:ram de hýzlýca bulabilmek için.
        anim = GetComponent<Animator>();
        grounded = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (started && grounded)//yerdeysek ve oyun baþladýysa zýplama olsun.
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
        //oyun baþladýysa karaktere hýz vermeliyiz.
        if (started)
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);//rigidbody ye bir hýz verisi gireceðiz.//y=hýz ne ise ayný kalsýn.
        }
        if (jumping)//yukaru güç uygulanmalý.
        {
            rb.AddForce(new Vector2(0f, jumpForce));
            jumping = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)//eðer bir yere çapýyorsa run metoduna geri dön. yere düþünce zýplama durmalý.
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            grounded = true;
        }
    }
}
