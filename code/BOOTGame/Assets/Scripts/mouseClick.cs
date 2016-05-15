using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class mouseClick : MonoBehaviour {

    //use the OnMouseDown method of Unity to check whether the mouseposition is on the object and the mouse is clicked while its on the object.
    void OnMouseDown() {
        //check which letter is clicked and load scenes of the closeup of the clicked letter.
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
