using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour
{

    public GameObject PauseUI;
    public GameObject ScenarioUI;
    public PlayerMovement Player;
    public bool paused = false;


    void Start()
    {
        PauseUI.SetActive(false);
        ScenarioUI.SetActive(false);
        Player = FindObjectOfType<PlayerMovement>();
    }

    void Update()
    {
        if (paused)
        {
            PauseUI.SetActive(true);
            Player.canMove = false;
        }
        if (!paused)
        {
            PauseUI.SetActive(false);
            Player.canMove = true;
        }
        Debug.Log(paused);
    }

    public void PausedClicked() {
        //if (Input.GetButtonDown("Pause"))
        //{
        paused = true;
        //}

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
        
        Player.DestroyPlayer();
       
        Application.LoadLevel(0);
        paused = false;

    }

    public void VerlaatSpel()
    {
        Application.Quit();
    }

    public void KiesScenario()
    {
        if (paused)
        {
            PauseUI.SetActive(false);
        }
        ScenarioUI.SetActive(true);
    }

    public void ScenarioOne()
    {
        Application.LoadLevel(1);
        ScenarioUI.SetActive(false);
    }
    public void ScenarioTwo()
    {
        Application.LoadLevel(2);
        ScenarioUI.SetActive(false);
    }
}
