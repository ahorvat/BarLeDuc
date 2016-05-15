using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEditor.SceneManagement;

public class isPressed : MonoBehaviour
{
    //TODO QUESTMANAGER
    // public QuestManager questManager;

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
                SceneManager.LoadScene("sc_correctletterchoice");
            }
			if (SceneManager.GetActiveScene().name == "sc_ABNBrief_closeup")
            {
                SceneManager.LoadScene("sc_correctletterchoice");
            }

        }
        //same goes for the incorrectbutton
        else if (gameObject.tag == "incorrectButton")
        {
            //back to the previous scene if the incorrectbutton is clicked.
            if (SceneManager.GetActiveScene().name == "sc_staatsloterijBrief_closeup")
            {
                SceneManager.LoadScene("sc_correctletterchoice");
            }
            if (SceneManager.GetActiveScene().name == "sc_gemeenteBrief_closeup")
            {
                SceneManager.LoadScene("sc_incorrectletterchoice");
            }
            if (SceneManager.GetActiveScene().name == "sc_ABNBrief_closeup")
            {
                SceneManager.LoadScene("sc_incorrectletterchoice");
            }
        }
    }
}

//
//Scene scene = SceneManager.GetActiveScene();
//scene.name; // name of scene
