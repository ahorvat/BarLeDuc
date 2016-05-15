using UnityEngine;

using System.Collections;

public class Pause : MonoBehaviour
{

    public GameObject PauseUI;
    public GameObject ScenarioUI;
    public PlayerMovement Player;
    public bool paused = false;
    public Canvas MenuCan;
    

    void Start()
    {
        //De pauze menu en het scenariokiezen menu staan uit zodra de game start.
        PauseUI.SetActive(false);
        ScenarioUI.SetActive(false);
        Player = FindObjectOfType<PlayerMovement>();
        MenuCan = FindObjectOfType<Canvas>();
    }

    void Update()
    {
        //Als de game op pause staat komt de PauseUI tevoorschijn, player kan niet bewegen dan.
        if (paused)
        {
            PauseUI.SetActive(true);
            Player.canMove = false;
        }
        //Als de niet game gepauzeerd is staat het paue menu uit, player kan bewegen.
        if (!paused)
        {
            PauseUI.SetActive(false);
            Player.canMove = true;
        }
    }

    //Als de homebutton wordt gedrukt is de game paused.
    public void PausedClicked() {
     
        paused = true;
        
    }

    //Als de ga verder button wordt gedrukt is de game niet paused.
    public void GaVerder()
    {
        paused = false;
    }

    //
    public void HoofdMenu()
    {
        MenuCan.gameObject.SetActive(false);
        //Player.DestroyPlayer();
        Application.LoadLevel(0);
        paused = false;


    }

    public void KiesScenario()
    {
       
        paused = false;
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
