using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class BackToBrievencloseupScene : MonoBehaviour {

	// Update is called once per frame
	void OnMouseDown () {
        SceneManager.LoadScene("sc_brief_closeup");
	}
}
