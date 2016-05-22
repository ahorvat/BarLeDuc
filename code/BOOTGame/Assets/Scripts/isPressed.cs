using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEditor.SceneManagement;

public class isPressed : MonoBehaviour
{

    public DeleteBrief deleteBrief;

    void Start()
    {
        deleteBrief = FindObjectOfType<DeleteBrief>();
    }


    //use the OnMouseDown method of Unity to check whether the mouseposition is on the object and the mouse is clicked while its on the object.
    void OnMouseDown()
    {
        // check if the gameobject that the mouse clicks on is the correctbutton.
        if (gameObject.tag == "correctButton")
        {
            //switching scenes between different letters.
            if (SceneManager.GetActiveScene().name == "sc_staatsloterijBrief_closeup")
            {
                SceneManager.LoadScene("sc_incorrectletterchoice");
            }
            if (SceneManager.GetActiveScene().name == "sc_gemeenteBrief_closeup")
            {
                deleteBrief.gemeenteBrief = true;
                SceneManager.LoadScene("sc_correctletterchoice");
            }
			if (SceneManager.GetActiveScene().name == "sc_ABNBrief_closeup")
            {
                deleteBrief.abnBrief = true;
                SceneManager.LoadScene("sc_correctletterchoice");
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
                SceneManager.LoadScene("sc_incorrectletterchoice1");
            }
            if (SceneManager.GetActiveScene().name == "sc_ABNBrief_closeup")
            {
                SceneManager.LoadScene("sc_incorrectletterchoice1");
            }
            if (SceneManager.GetActiveScene().name == "sc_google_closeup")
            {
                SceneManager.LoadScene("sc_brief_home_google");
            }
        }

        if (gameObject.tag == "yesButton")
        {
            SceneManager.LoadScene("sc_brief_closeup");
        }
    }
}

//
//Scene scene = SceneManager.GetActiveScene();
//scene.name; // name of scene
