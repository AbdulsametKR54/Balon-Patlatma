using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDiffuculty : MonoBehaviour
{
    public GameObject firstStage, secondStage;
    public GameObject easyButton, normalButton, hardButton, menuButton;
    public static float katsayi = 1f;
    public static float zaman = 90f;
    public static float balonOlusturmaSüresi = 0.75f;
    public static float bombaZamanKapsam = 5f;
    // Start is called before the first frame update
    public void EasyButton()
    {
        katsayi = 2f;
        zaman = 90f;
        balonOlusturmaSüresi = 3f;
        bombaZamanKapsam = 5f;
        SceneManager.LoadScene(Random.Range(1, 4));
    }
    public void NormalButton() 
    {
        katsayi = 4f;
        zaman = 55f;
        balonOlusturmaSüresi = 1.5f;
        bombaZamanKapsam = 5f;
        SceneManager.LoadScene(Random.Range(1, 4));
    }
    public void HardButton()
    {
        katsayi = 6f;
        zaman = 35f;
        balonOlusturmaSüresi = 0.75f;
        bombaZamanKapsam = 3.5f;
    SceneManager.LoadScene(Random.Range(1, 4));
    }
    public void MenuButton()
    {
        firstStage.SetActive(true);
        secondStage.SetActive(false);
    }
}
