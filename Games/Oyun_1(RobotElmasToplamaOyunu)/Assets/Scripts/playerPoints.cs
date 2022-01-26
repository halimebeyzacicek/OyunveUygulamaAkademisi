using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class playerPoints : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    AudioSource audio;

    private void Awake()
    {
        audio = GetComponent<AudioSource>();
        text.text = score.totalScore.ToString();//yeni sahne açýldýgýnda(baslangýc için de gecerli) bir kere çalýþacak. new yazýsý cýkmayacak score yine yazacak.
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("elmas"))
        {
            audio.Play();
            Destroy(collision.gameObject);//elmasý silicez.dokundugumuz.
            score.totalScore++;
            text.text = score.totalScore.ToString();
        }
    }
}
