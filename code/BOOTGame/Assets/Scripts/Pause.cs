using UnityEngine;
using UnityEngine.SceneManagement;
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
        
        // PauseUI = GameObject.FindGameObjectWithTag("PauseUI");
    }

    void Update()
    {
        //Als de game op pause staat komt de PauseUI tevoorschijn, player kan niet bewegen dan.
        if (paused)
        {
            PauseUI.SetActive(true);

        }

        //Als de niet game gepauzeerd is staat het paue menu uit, player kan bewegen.
        if (!paused)
        {
            PauseUI.SetActive(false);

        }
    }

    //Als de homebutton wordt gedrukt is de game paused.
    public void PausedClicked()
    {
		if (paused) {
            if (Player != null)
            {
                Player.canMove = true;
            }
            paused = false;	
		}
		else if (!paused) {
			
			paused = true;
            if (Player != null)
            {
                Player.canMove = false;
            }
        }


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
        SceneManager.LoadScene(1);
        paused = false;
    }
    
    //
    public void KiesScenario()
    {
        paused = false;
        ScenarioUI.SetActive(true);
    }

    //
    public void ScenarioOne()
    {
        SceneManager.LoadScene("sc_brief_home");
        ScenarioUI.SetActive(false);
    }

    //
    public void ScenarioTwo()
    {
        SceneManager.LoadScene("sc_digiD_home");
        ScenarioUI.SetActive(false);
    }

	public void ScenarioTerug()
	{
		ScenarioUI.SetActive(false);
		paused = true;
	
	}

}
