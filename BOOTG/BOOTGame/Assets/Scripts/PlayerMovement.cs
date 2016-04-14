using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    // Use this for initialization
    private Rigidbody2D rb;
    public float speed = 1.5f;
    public float maxspeed = 4.0f;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {


        float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector3(moveHorizontal, 0.0f);

        movement = movement * speed;

        if (movement.x > maxspeed)
        {
            movement.x = maxspeed;
        }

        rb.AddForce(movement);
    }
}
