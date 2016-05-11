using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class BackToBrievencloseupScene : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("sc_brieven_closeup");
        }
	}
}
