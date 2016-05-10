using UnityEngine;
using System.Collections;

public class mouseClick : MonoBehaviour {

	// Use this for initialization
	void OnMouseDown () {
        Debug.Log("clicked");
        Destroy(gameObject);
	}
    
}
