using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour
{
    //[SerializeField] int SceneIndex;(3.Y�NTEM)

    private Scene _scene;//suan ki sahne

    private void Awake()
    {
        _scene = SceneManager.GetActiveScene();//caching
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))//eger obje player ise seviyeyi yeniden ba�latmak istiyorum.
        {
            //SceneManager.LoadScene("2");//sahnenin ad�n� yazarak yapt�k.(1.Y�NTEM)
            SceneManager.LoadScene(_scene.buildIndex+1);//bir sonraki sahneyi �a��rm�� olacak.(2.Y�NTEM)
            //SceneManager.LoadScene(SceneIndex);//(3.Y�NTEM)//El ile hangi sahneye gidece�imi doldurmam gerekiyor.
        }
    }
    public void StartLevel()//baslang�� butonunun i�ine koyaca��z
    {
        SceneManager.LoadScene(_scene.buildIndex + 1);
    }
}
