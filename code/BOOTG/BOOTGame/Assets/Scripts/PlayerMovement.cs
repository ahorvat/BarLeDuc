using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    // Use this for initialization
    private Rigidbody2D rb;
    public GameObject TestText;
    public float speed = 1.5f;
    public float maxspeed = 4.0f;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        // Movement

        // We store the GetAxis Input which is premade by unity in MoveHorizontal and Vertical
        // As we dont move vertical moveVertical becomes irrelevant
        float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");

        //in movement we store a new vector made of moveHorizontal and for vertical 0.0f as we dont move vertical
        Vector2 movement = new Vector2(moveHorizontal, 0.0f);

        //movement gets multipited by speed. Because this happenes evry frame we scale te movement up.
        movement = movement * speed;

        //Movement Max
        if (movement.x > maxspeed)
        {
            movement.x = maxspeed;
        }

        //This is were we actually apply the movement onto the object.
        rb.AddForce(movement);
        
    }

    //Collision
    void OnTriggerStay2D(Collider2D col)
    {
        //if this object collides with object Door, Scene2 will be loaded.
        if(col.gameObject.tag == "Door")
        {
            if (Input.GetKey("up"))
            {
                SceneManager.LoadScene("Scene2");
            }
            
        }

        //if this object collides with object TestPerson, the method with the name "move" will be executed.
        if(col.gameObject.name == "TestPerson")
        {
            TestText.SendMessage("Move");
        }
    }

    void OnCollisionExit2D(Collision2D col)
    {
        //if the object stops colliding with objec called TestPerson, the method with the name "remove" will be executed.
        if (col.gameObject.name == "TestPerson")
        {
            TestText.SendMessage("ReMove");
        }
    }
}
