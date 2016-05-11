using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {
    float endPos;
    void Start()
    {
        endPos = -3.15f;
    }

    // Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
        
    }
}
