using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour
{
    //[SerializeField] int SceneIndex;(3.YÖNTEM)

    private Scene _scene;//suan ki sahne

    private void Awake()
    {
        _scene = SceneManager.GetActiveScene();//caching
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))//eger obje player ise seviyeyi yeniden baþlatmak istiyorum.
        {
            //SceneManager.LoadScene("2");//sahnenin adýný yazarak yaptýk.(1.YÖNTEM)
            SceneManager.LoadScene(_scene.buildIndex+1);//bir sonraki sahneyi çaðýrmýþ olacak.(2.YÖNTEM)
            //SceneManager.LoadScene(SceneIndex);//(3.YÖNTEM)//El ile hangi sahneye gideceðimi doldurmam gerekiyor.
        }
    }
    public void StartLevel()//baslangýç butonunun içine koyacaðýz
    {
        SceneManager.LoadScene(_scene.buildIndex + 1);
    }
}
