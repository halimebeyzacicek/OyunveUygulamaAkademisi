using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour
{
    GameObject camera;
    GameObject karakter;
    Vector3 hedef;
    float fark;//kamera ve cakaraktae rarasýndaki fark hep korunmalý. x ekseninde.

    void Start()
    {
        camera = this.gameObject;
        karakter = GameObject.FindWithTag("Player");
        fark = camera.transform.position.x - karakter.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        hedef.x = karakter.transform.position.x+fark;
        hedef.y = camera.transform.position.y;
        hedef.z = camera.transform.position.z;

        camera.transform.position=Vector3.Lerp(camera.transform.position,hedef,1f);
    }
}
