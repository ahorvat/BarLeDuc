using UnityEngine;
using System.Collections;

public class OutOfScreen : MonoBehaviour {
    private float minPosition = -25.595f;
    private float maxPosition = 132.398f;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x < minPosition)
        {
            transform.position = new Vector3(minPosition, transform.position.y, transform.position.z);
        }

        if (transform.position.x > maxPosition)
        {
            transform.position = new Vector3(maxPosition, transform.position.y, transform.position.z);
        }
	}
}
