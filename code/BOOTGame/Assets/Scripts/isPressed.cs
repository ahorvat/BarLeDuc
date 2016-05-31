using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEditor.SceneManagement;

public class isPressed : MonoBehaviour
{

    public DeleteBrief deleteBrief;
    private TextBoxManager textBoxManager;
    private GameObject dialogueBox;

    void Start()
    {
        textBoxManager =  FindObjectOfType<TextBoxManager>();
        deleteBrief = FindObjectOfType<DeleteBrief>();
        dialogueBox = GameObject.FindGameObjectWithTag("DialogueBox");

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
				deleteBrief.abnBrief = true;
				AudioSource audio = GetComponent<AudioSource>();
				audio.Play();
				audio.Play(44100);
                SceneManager.LoadScene("sc_correctletterchoice");
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
                SceneManager.LoadScene("_sc_initalize_persistence");
            }
        }

        else if (gameObject.tag == "addressBar")
        {

        }

        else if (gameObject.tag == "InternetIcon")
        {
            SceneManager.LoadScene("sc_internet_start");
        }
    }
}

//
//Scene scene = SceneManager.GetActiveScene();
//scene.name; // name of scene
