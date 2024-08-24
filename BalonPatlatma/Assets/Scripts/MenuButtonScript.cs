using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonScript : MonoBehaviour
{
    public GameObject firstStage, secondStage;
    // Start is called before the first frame update
    public void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartButon()
    {
        SettingsButon();
    }
    public void SettingsButon()
    {
        secondStage.SetActive(true);
        firstStage.SetActive(false);
    }
    public void QuitAppicationButon()
    {
        Application.Quit();
    }
}
