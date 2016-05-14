using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SwitchingScenes : MonoBehaviour {
    public GameObject player;

    // Use this for initialization
    void Start () {
        player = new GameObject();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0) || Input.anyKeyDown)
        {
            player.active = true;
            SceneManager.LoadScene("sc_street");
        }
	}
}
