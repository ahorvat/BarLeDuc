using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour
{

    public GameObject PauseUI;

    private bool paused = false;

    void Start()
    {
        
        PauseUI.SetActive(false);
    }

    void Update()
    {
    }

    public void PausedClicked() { 
        //if (Input.GetButtonDown("Pause"))
        //{
        paused = true;
        //}
        if (paused)
        {
            PauseUI.SetActive(true);
            Time.timeScale = 0;
        }
        if (!paused)
        {
            PauseUI.SetActive(false);
            Time.timeScale = 1;
        }
    }
    public void GaVerder()
    {
        if (paused)
        {
            PauseUI.SetActive(false);
        }
    }

    public void HoofdMenu()
    {
        Application.LoadLevel(0);
    }

    public void VerlaatSpel()
    {
        Application.Quit();
    }
}
