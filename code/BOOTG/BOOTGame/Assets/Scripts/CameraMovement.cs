using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

    public float screenWidthMax = 40f;
    public float screenWidthMin = -52.68014f;

    public bool bounds;


    public Vector3 minCameraPos;
    public Vector3 maxCameraPos;

    // Use this for initialization
    void Start() {
        if (bounds)
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, minCameraPos.x, maxCameraPos.x),
                Mathf.Clamp(transform.position.y, minCameraPos.y, maxCameraPos.y),
                Mathf.Clamp(transform.position.z, minCameraPos.z, maxCameraPos.z));

        }
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

