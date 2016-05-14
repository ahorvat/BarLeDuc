using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEditor;
using System.Collections;
using UnityEditor.SceneManagement;

public class isPressed : MonoBehaviour
{
    //TODO QUESTMANAGER
    // public QuestManager questManager;

    void OnMouseDown()
    {
        // voor de correct button
        if (gameObject.name == "correctButton")
        {
            //als de scnene x gelijk is aan de juise scene, ga naar de volgende scene. anders ga terug naar vorige scene.
            if (SceneManager.GetActiveScene().name == "sc_staatsloterijBrief_closeup")
            {
                SceneManager.LoadScene("sc_brief_closeup");
            }
            if (SceneManager.GetActiveScene().name == "sc_gemeenteBrief_closeup")
            {
                SceneManager.LoadScene("sc_street");
            }

			if (SceneManager.GetActiveScene().name == "sc_ABNBrief_closeup")
            {
                SceneManager.LoadScene("sc_brief_closeup");
            }

        }
        //script voor incorrect button
        else if (gameObject.name == "incorrectButton")
        {
            //ga terug naar de vorige scnene als je op kruihjse drukt
            if (SceneManager.GetActiveScene().name == "sc_staatsloterijBrief_closeup")
            {
                SceneManager.LoadScene("sc_brief_closeup");
            }
            if (SceneManager.GetActiveScene().name == "sc_gemeenteBrief_closeup")
            {
                SceneManager.LoadScene("sc_brief_closeup");
            }
            if (SceneManager.GetActiveScene().name == "sc_ABNBrief_closeup")
            {
                SceneManager.LoadScene("sc_brief_closeup");
            }
        }
    }
}

//
//Scene scene = SceneManager.GetActiveScene();
//scene.name; // name of scene
