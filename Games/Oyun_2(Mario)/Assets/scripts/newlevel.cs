using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newlevel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);  //bir sonraki sahneyi  yukle.


        }
    }
    public void next()//buton için
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
