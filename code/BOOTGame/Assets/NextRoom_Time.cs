using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextRoom_Time : MonoBehaviour {

    float timeleft = 5.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timeleft -= Time.deltaTime;
        if(timeleft < 0)
        {
            SceneManager.LoadScene("sc_ontvang_code");
        }
	
	}
}
