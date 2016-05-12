using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEditor;
using System.Collections;

public class isPressed : MonoBehaviour {

    void OnMouseDown()
    {
        if (gameObject.tag == "correctButton")
        {
			if (SceneManager.GetActiveScene().name == "sc_ABNBrief")
            {
                SceneManager.LoadScene("sc_street");
            }
            else if (gameObject.tag == "incorrectButton")
            {
                SceneManager.LoadScene("sc_brief_closeup");
            }
        } 
    }
}
//
//Scene scene = SceneManager.GetActiveScene();
//scene.name; // name of scene