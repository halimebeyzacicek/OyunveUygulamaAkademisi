using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    [SerializeField] AudioClip clicksound;
    int count=0;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("collectible"))
        {
            count++;
            Debug.Log(count);
            AudioSource.PlayClipAtPoint(clicksound, collision.transform.position);//ne �alacak, nerede �alacak.
            Destroy(collision.gameObject);//�arpt�g�m�z obje silindi
        }
    }
}
