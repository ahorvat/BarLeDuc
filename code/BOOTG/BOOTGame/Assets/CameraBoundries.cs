using UnityEngine;
using System.Collections;

public class CameraBoundries : MonoBehaviour
{
    private float minPosition = -11.20f;
    private float maxPosition = 118f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
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