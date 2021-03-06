﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class isPressed : MonoBehaviour
{

    public DeleteBrief deleteBrief;
    private TextBoxManager textBoxManager;
    private GameObject dialogueBox;
    private GameObject player;
  

    void Start()
    {
        textBoxManager =  FindObjectOfType<TextBoxManager>();
        deleteBrief = FindObjectOfType<DeleteBrief>();
        dialogueBox = GameObject.FindGameObjectWithTag("DialogueBox");
        player = GameObject.FindGameObjectWithTag("Player");

    }


    //use the OnMouseDown method of Unity to check whether the mouseposition is on the object and the mouse is clicked while its on the object.
    void OnMouseUp()
    {
        // check if the gameobject that the mouse clicks on is the correctbutton.
        if (gameObject.tag == "correctButton")
        {
			
            //switching scenes between different letters.
            if (SceneManager.GetActiveScene().name == "sc_staatsloterijBrief_closeup")
            {
                SceneManager.LoadScene("sc_incorrectletterchoice1");
            }
            if (SceneManager.GetActiveScene().name == "sc_gemeenteBrief_closeup")
            {
                deleteBrief.gemeenteBrief = true;
                SceneManager.LoadScene("sc_correctletterchoice");
            }
			if (SceneManager.GetActiveScene().name == "sc_ABNBrief_closeup")
            {
                
                SceneManager.LoadScene("sc_correctletterchoice");
				deleteBrief.abnBrief = true;

            }
            if (SceneManager.GetActiveScene().name == "sc_google_closeup")
            {
                SceneManager.LoadScene("sc_googleFeedback");
            }

        }
        //same goes for the incorrectbutton
        else if (gameObject.tag == "incorrectButton")
        {
            //back to the previous scene if the incorrectbutton is clicked.
            if (SceneManager.GetActiveScene().name == "sc_staatsloterijBrief_closeup")
            {
                deleteBrief.staatsloterijLetter = true;
                SceneManager.LoadScene("sc_correctletterchoice1");
            }
            if (SceneManager.GetActiveScene().name == "sc_gemeenteBrief_closeup")
            {
                SceneManager.LoadScene("sc_incorrectletterchoice");
            }
            if (SceneManager.GetActiveScene().name == "sc_ABNBrief_closeup")
            {
                SceneManager.LoadScene("sc_incorrectletterchoice");
            }
            if (SceneManager.GetActiveScene().name == "sc_google_closeup")
            {
                SceneManager.LoadScene("sc_brief_home_google");
            }
        }

        else if (gameObject.tag == "yesButton")
        {
            if (SceneManager.GetActiveScene().name == "sc_incorrectletterchoice" || SceneManager.GetActiveScene().name == "sc_incorrectletterchoice1"|| 
                SceneManager.GetActiveScene().name == "sc_correctletterchoice" || SceneManager.GetActiveScene().name == "sc_correctletterchoice1")
            {
                SceneManager.LoadScene("sc_brief_closeup");
            }

            if (SceneManager.GetActiveScene().name == "sc_google_incorrect")
            {
                SceneManager.LoadScene("sc_gemeentebrief_choices");
            }

            if (SceneManager.GetActiveScene().name == "sc_street")
            {
                dialogueBox.SetActive(false);
                textBoxManager.EnableTekstBox();
            }
            if (SceneManager.GetActiveScene().name == "sc_incorrectchoice_dialogue")
            {
                SceneManager.LoadScene("sc_street");
                player.transform.position = new Vector3(-10, player.transform.position.y, player.transform.position.z);
            }
            if (SceneManager.GetActiveScene().name == "sc_phonecallFeedback")
            {
                SceneManager.LoadScene("sc_gemeentebrief_choices");
            }
            if (SceneManager.GetActiveScene().name == "sc_googleFeedback")
            {
                SceneManager.LoadScene("sc_gemeentebrief_choices");
            }
            if (SceneManager.GetActiveScene().name == "sc_buurvrouwFeedback")
            {
                SceneManager.LoadScene("sc_menu");
            }
            if (SceneManager.GetActiveScene().name == "sc_BSN_correct")
            {
                SceneManager.LoadScene("sc_DigiDStap3");
            }
            if (SceneManager.GetActiveScene().name == "sc_BSN_incorrect")
            {
                SceneManager.LoadScene("sc_BSN_zoeken");
            }
            if (SceneManager.GetActiveScene().name == "sc_FeedBack_Scene")
            {
                SceneManager.LoadScene("sc_menu");
            }
            if (SceneManager.GetActiveScene().name == "sc_DigiDBrief")
            {
                SceneManager.LoadScene("sc_activate_code");
            }
            if (SceneManager.GetActiveScene().name == "sc_emailGoogleCorrect")
            {
                SceneManager.LoadScene("sc_email_stap2");
            }
            if (SceneManager.GetActiveScene().name == "sc_emailGoogleIncorrect")
            {
                SceneManager.LoadScene("sc_email_google");
            }
            if (SceneManager.GetActiveScene().name == "sc_emailnaam_correct")
            {
                SceneManager.LoadScene("sc_email_stap5");
            }
            if (SceneManager.GetActiveScene().name == "sc_emailnaam_incorrect")
            {
                SceneManager.LoadScene("sc_email_stap4");
            }
            if(SceneManager.GetActiveScene().name == "sc_email_feedback")
            {
                SceneManager.LoadScene("sc_menu");
            }
        }


        // When all else fails, go back to the main menu
        else
        {
            SceneManager.LoadScene("sc_menu");
        }
    }
}
