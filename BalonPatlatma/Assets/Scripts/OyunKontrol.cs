using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OyunKontrol : MonoBehaviour
{
    public GameObject patlama;
    public UnityEngine.UI.Text zamanText, balonText;
    int patlayanBalon = 0;
    // Start is called before the first frame update
    void Start()
    {
        balonText.text = "Balon: " + patlayanBalon;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameDiffuculty.zaman>0)
        {
            GameDiffuculty.zaman -= Time.deltaTime;
            zamanText.text = "Süre: " + (int)GameDiffuculty.zaman;
        }
        else
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag("balon");
            GameObject[] goes = GameObject.FindGameObjectsWithTag("bombaBalon");
            for(int i=0; i<go.Length; i++)
            {
                GameObject patlamaKalýntýsý = (Instantiate(patlama, go[i].transform.position, go[i].transform.rotation)) as GameObject;
                Destroy(go[i]);
                Destroy(patlamaKalýntýsý, 0.267f);
            }
            for(int i=0;i<goes.Length; i++)
            {
                GameObject patlamaKalýntýsý = (Instantiate(patlama, goes[i].transform.position, goes[i].transform.rotation)) as GameObject;
                Destroy(goes[i]);
                Destroy(patlamaKalýntýsý, 0.267f);
            }
            Invoke("OyunBitti", 1f);
        }
    }
    public void OyunBitti()
    {
        SceneManager.LoadScene(0);
    }
    public void PatlayanBalon(GameObject obje)
    {
        if(obje.CompareTag("balon"))
        {
            for(int i=0;i<(GameDiffuculty.katsayi/2);i++)
                patlayanBalon += 1;
            balonText.text = "Balon: " + patlayanBalon;
        }
        else if(obje.CompareTag("bombaBalon"))
        {
            for (int i = 0; i < (GameDiffuculty.katsayi / 2); i++)
                patlayanBalon -= 1;
            balonText.text = "Balon: " + patlayanBalon;
        }
    }
}
