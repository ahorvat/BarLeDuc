using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

    // Update is called once per frame
	void Update () {
        //adjust the rotation of the object on the Z-axis and multiply this with the time passed between 2 frames each frame.
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
    }
}
