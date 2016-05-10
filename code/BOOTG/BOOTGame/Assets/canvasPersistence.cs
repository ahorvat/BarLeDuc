using UnityEngine;
using System.Collections;

public class canvasPersistence : MonoBehaviour {
    public Canvas pause;

	// Use this for initialization
	void Start () {
        pause = FindObjectOfType<Canvas>();
	}
	
	// Update is called once per frame
	void Update () {
        
	}
}
