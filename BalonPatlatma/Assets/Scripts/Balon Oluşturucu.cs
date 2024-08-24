using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonOluşturucu : MonoBehaviour
{
    public GameObject balon, bombaBalon;
    float balonZamanKontrolü = 0;
    float bombaZaman = 4f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(!GameScripts.pauseController)
        {
            balonOluşturma();
            bombaBalonOluştur();
        }
    }
    void balonOluşturma()
    {
        balonZamanKontrolü -= Time.deltaTime;
        if (balonZamanKontrolü < 0 && GameDiffuculty.zaman > 0)
        {
            GameObject ucanBalon = Instantiate(balon, new Vector3(Random.Range(-1.92f, 1.92f), -6f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            ucanBalon.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(55f*(GameDiffuculty.katsayi), 65f*(GameDiffuculty.katsayi)), 0));
            balonZamanKontrolü = GameDiffuculty.balonOlusturmaSüresi;
        }
    }
    void bombaBalonOluştur()
    {
        bombaZaman -= Time.deltaTime;
        if (bombaZaman < 0 && GameDiffuculty.zaman > 0)
        {
            GameObject ucanBalon1 = Instantiate(bombaBalon, new Vector3(Random.Range(-1.92f, 1.92f), -6f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            ucanBalon1.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(55f * (GameDiffuculty.katsayi), 65f * (GameDiffuculty.katsayi)), 0));
            bombaZaman = GameDiffuculty.bombaZamanKapsam;
        }
    }
}
