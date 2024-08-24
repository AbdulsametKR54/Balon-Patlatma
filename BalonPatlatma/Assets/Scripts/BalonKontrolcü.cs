using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonKontrolcü : MonoBehaviour
{
    public GameObject patlama;
    OyunKontrol oyunKontrolScripti;
    public void Start()
    {
        oyunKontrolScripti=GameObject.Find("_Scripts").GetComponent<OyunKontrol>();        
    }
    private void OnMouseDown()
    {
        GameObject patlamaKalıntısı=(Instantiate(patlama, transform.position, transform.rotation))as GameObject;
        Destroy(gameObject);
        Destroy(patlamaKalıntısı, 0.267f);
        oyunKontrolScripti.PatlayanBalon(this.gameObject);
        
    }
}
