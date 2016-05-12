using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class mouseClick : MonoBehaviour {

    // Use this for initialization
    void OnMouseDown() {

        if (gameObject.tag == "gemeenteLetter")
        {
            SceneManager.LoadScene("sc_gemeenteBrief_closeup");
        }
        else if (gameObject.tag == "ABNLetter")
        {
            SceneManager.LoadScene("sc_ABNBrief_closeup");
        }
        else if (gameObject.tag == "staatsloterijLetter")
        {
            SceneManager.LoadScene("sc_staatsloterijBrief_closeup");
        }
	}
    
}
