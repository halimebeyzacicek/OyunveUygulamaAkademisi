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
        r2d = GetComponent<Rigidbody2D>();//caching//bu bilgiyi memoriye atman�z� sa�lar.
        animator = GetComponent<Animator>();
        charPos = transform.position;
        sayi = 1;

    }
    private void FixedUpdate()//fizik hesaplamalar�m frame ba��na de�il FixedUpdate ba��na yap�lacak.
    {
        //Debug.Log("Fixed" + sayi);
        //r2d.velocity = new Vector2(speed, 0f);//y ekseninde hareket etmeyece�im, x eksenine h�z�m kadar hareket edece�im. 
        sayi = 2;
    }

    private void Update()//per frame
    {
        /*if (Input.GetKey(KeyCode.Space))//eger bas�l� tutuyorsam
        {
            speed = 1f;
            //Debug.Log("Hiz 1f");
        }
        else
        {
            speed = 0f;
            //Debug.Log("Hiz 0f");
        }*/


        charPos = new Vector3(charPos.x + (Input.GetAxis("Horizontal")*speed * Time.deltaTime), charPos.y); //karakter pozisyonumu h�za ba�l� olarak de�i�mesini sa�layaca��m.
        transform.position = charPos;//hesaplad���m pozisyon karakterime e�itlensin. //burada bir fizk eleman� kullanm�yorum sadece pozisyon de�i�ikli�i yap�yorum.
        if (Input.GetAxis("Horizontal") == 0.0f)//hareket etmiyosam h�z s�f�r olsun.
        {
            animator.SetFloat("speed", 0.0f);
        }
        else
        {
            animator.SetFloat("speed", 1.0f);//hareket ediyosam 
        }


        //s�f�r oldugu zaman da hangi tarafa donduysek o tarafta kalm�� olacak.
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
        camera.transform.position = new Vector3(charPos.x, charPos.y, charPos.z - 1.0f);//karakterin bulundu�u yerden bir metre geri gelmesin istiyorum ��nk� kamera ile �st �ste olsunlar istemiyorum.
        sayi = 4;
    } 

}
