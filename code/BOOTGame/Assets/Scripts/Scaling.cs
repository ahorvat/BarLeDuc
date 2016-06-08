using UnityEngine;
using System.Collections;

public class Scaling : MonoBehaviour
{

    // Time that it takes to scale.
    public float duration = 1.5f;
    public float minXpos;
    public float maxXpos;
    public float scaleAmount;

    // Boolean to check if its scaling so the method doesnt overlap.
    public bool isScaling = false;

    private GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    // Call the method for scaling each frame. StartCorountine is used to call the scaling method. We cant just call it like we usually do since it's a IEnumerator method.
    void Update()
    {
        //StartCorountine is used to call the scaling method.We cant just call it like we usually do since it's a IEnumerator method.
        StartCoroutine(DoScaleThing());
    }
    //Method for scaling.
    public IEnumerator DoScaleThing()
    {

        // Check if scaling is true, if so, quit the method so it doesnt overlap.
        if (isScaling)
        {
            yield break;
        }

        if (player) {
            if (player.transform.position.x < minXpos || player.transform.position.x > maxXpos)
            {
                yield break;
            }   
        }
        Debug.Log("JAJAJAJAJA");
        //Set scaling on true so the scaling starts.
        isScaling = true;

        // Get the current time and store it in a float. We do this by getting the time in seconds from the start of this frame.
        float startTime = Time.time;

        //loop as long as the time - startTime is less then the duration, so we can scale it as long as we set the duration.
        while (Time.time - startTime < duration)
        {
            //set the amount to lerp the scale with the amount. 
            float amount = (Time.time - startTime) / duration;
            //lerp to calculate the interpollation of 2 vectors and amount to set the amount that it scales with each frame.
            gameObject.transform.localScale = Vector3.Lerp(Vector3.one, Vector3.one * scaleAmount, amount);
            //yield to return on this frame and go on next frame with the loop with the same variables it had last frame.
            yield return null;
        }

        // Scale down part, works the same as the scaling part.
        startTime = Time.time;

        while (Time.time - startTime < duration)
        {
            float amount = (Time.time - startTime) / duration;
            transform.localScale = Vector3.Lerp(Vector3.one * scaleAmount, Vector3.one, amount);
            yield return null;
        }

        //Set the scale to one if it isnt scaling up/down
        transform.localScale = Vector3.one;

        // Set scaling to false at the end of this method.
        isScaling = false;
    }
}