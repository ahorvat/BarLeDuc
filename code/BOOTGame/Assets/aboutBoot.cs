using UnityEngine;
using System.Collections;

public class aboutBoot : MonoBehaviour {
    public GameObject CanvasAbout;
 
	// Use this for initialization
	void Start () {
        CanvasAbout.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void isPressed()
    {
        CanvasAbout.SetActive(true);
    }
    
    public void gaVerder()
    {
        CanvasAbout.SetActive(false);
    }
}
