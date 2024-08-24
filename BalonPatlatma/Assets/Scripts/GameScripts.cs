using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScripts : MonoBehaviour
{
    public GameObject pauseButton, menuButton, resumeButton;
    public GameObject firstStage, secondStage;
    public static bool pauseController = false;
    // Start is called before the first frame update
    public void PauseButton()
    {
        firstStage.SetActive(false);
        secondStage.SetActive(true);
        pauseController = true;
        GameObject[] go = (GameObject.FindGameObjectsWithTag("balon"));
        for(int i=0; i<go.Length; i++)
            Destroy(go[i]);
        GameObject[] goes = (GameObject.FindGameObjectsWithTag("bombaBalon"));
        for (int i = 0; i < goes.Length; i++)
            Destroy(goes[i]);
    }
    public void ResumeButton()
    {
        Time.timeScale = 1;
        firstStage.SetActive(true);
        secondStage.SetActive(false);
        pauseController = false;
    }
    public void MenuButton()
    {
        SceneManager.LoadScene(0);
        pauseController = false;
    }
}
