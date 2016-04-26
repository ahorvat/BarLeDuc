using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

    public float screenWidthMax = 40f;
    public float screenWidthMin = -52.68014f;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //if (transform.position.x > screenWidthMax)
        //{
        //    transform.position = new Vector3(screenWidthMax, transform.position.y ,transform.position.z);
        //}

        //if (transform.position.x < screenWidthMin)
        //{
        //    transform.position = new Vector3(screenWidthMin, transform.position.y, transform.position.z);
        //}
    }
}
