using UnityEngine;
using System.Collections;

public class bouncingTest : MonoBehaviour {
    public float xPos, zPos;

	// Update is called once per frame
	void Update () {

        transform.position = new Vector3(xPos, Mathf.PingPong(Time.time, 1f) - 3, zPos);
    }
}
