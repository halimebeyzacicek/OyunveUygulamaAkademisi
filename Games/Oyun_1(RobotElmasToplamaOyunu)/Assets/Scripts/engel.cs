using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//sahne ile alakalý fonksiyonlarým mevcut.

public class engel : MonoBehaviour
{
    private Scene _scene;//suanki sahnem.

    private void Awake()
    {
        _scene = SceneManager.GetActiveScene();
        Debug.Log(_scene.name); 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))//eger obje player ise seviyeyi yeniden baþlatmak istiyorum.
        {
            score.lives--;
            SceneManager.LoadScene(_scene.name);
        }
    }
}
