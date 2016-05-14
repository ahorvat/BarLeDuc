using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEditor;
using System.Collections;
using UnityEditor.SceneManagement;

public class isPressed : MonoBehaviour
{

    // public QuestManager questManager;

    void OnMouseDown()
    {
        if (gameObject.name == "correctButton")
        {

            Debug.Log("asdfasdf");
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
        else if (gameObject.name == "incorrectButton")
        {
            Debug.Log("qwerqwerqwer");
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
