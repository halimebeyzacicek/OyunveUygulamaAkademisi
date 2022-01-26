using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
    public float speed = 1.0f;
    private Rigidbody2D r2d;
    private Animator animator;
    private Vector3 charPos;//karakter pozisyon
    [SerializeField] private GameObject camera;
    private int sayi;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        r2d = GetComponent<Rigidbody2D>();//caching//bu bilgiyi memoriye atmanýzý saðlar.
        animator = GetComponent<Animator>();
        charPos = transform.position;
        sayi = 1;

    }
    private void FixedUpdate()//fizik hesaplamalarým frame baþýna deðil FixedUpdate baþýna yapýlacak.
    {
        //Debug.Log("Fixed" + sayi);
        //r2d.velocity = new Vector2(speed, 0f);//y ekseninde hareket etmeyeceðim, x eksenine hýzým kadar hareket edeceðim. 
        sayi = 2;
    }

    private void Update()//per frame
    {
        /*if (Input.GetKey(KeyCode.Space))//eger basýlý tutuyorsam
        {
            speed = 1f;
            //Debug.Log("Hiz 1f");
        }
        else
        {
            speed = 0f;
            //Debug.Log("Hiz 0f");
        }*/


        charPos = new Vector3(charPos.x + (Input.GetAxis("Horizontal")*speed * Time.deltaTime), charPos.y); //karakter pozisyonumu hýza baðlý olarak deðiþmesini saðlayacaðým.
        transform.position = charPos;//hesapladýðým pozisyon karakterime eþitlensin. //burada bir fizk elemaný kullanmýyorum sadece pozisyon deðiþikliði yapýyorum.
        if (Input.GetAxis("Horizontal") == 0.0f)//hareket etmiyosam hýz sýfýr olsun.
        {
            animator.SetFloat("speed", 0.0f);
        }
        else
        {
            animator.SetFloat("speed", 1.0f);//hareket ediyosam 
        }


        //sýfýr oldugu zaman da hangi tarafa donduysek o tarafta kalmýþ olacak.
        if (Input.GetAxis("Horizontal") > 0.01f)//pozitifse saga dogru gidiyor, negatifse sola dogru gidiyor.
        {
            spriteRenderer.flipX = false;
        }
        else if(Input.GetAxis("Horizontal") < -0.01f)
        {
            spriteRenderer.flipX = true;
        }



        sayi = 3;
    }
    private void LateUpdate()
    {
        camera.transform.position = new Vector3(charPos.x, charPos.y, charPos.z - 1.0f);//karakterin bulunduðu yerden bir metre geri gelmesin istiyorum çünkü kamera ile üst üste olsunlar istemiyorum.
        sayi = 4;
    } 

}
