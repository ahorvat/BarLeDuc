using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
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
            if (Application.loadedLevelName == "sc_staatsloterijBrief_closeup")
            {
                SceneManager.LoadScene("sc_brief_closeup");
            }
            if (Application.loadedLevelName == "sc_gemeenteBrief_closeup")
            {
                SceneManager.LoadScene("sc_street");
            }
            if (Application.loadedLevelName == "sc_ABNBrief_closeup")
            {
                SceneManager.LoadScene("sc_brief_closeup");
            }
        }
        else if (gameObject.name == "incorrectButton")
        {
            Debug.Log("qwerqwerqwer");
            if (Application.loadedLevelName == "sc_staatsloterijBrief_closeup")
            {
                SceneManager.LoadScene("sc_brief_closeup");
            }
            if (Application.loadedLevelName == "sc_gemeenteBrief_closeup")
            {
                SceneManager.LoadScene("sc_brief_closeup");
            }
            if (Application.loadedLevelName == "sc_ABNBrief_closeup")
            {
                SceneManager.LoadScene("sc_brief_closeup");
            }
        }
    }
}

