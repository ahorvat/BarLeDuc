using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    // Use this for initialization
    public GameObject TestText;
    public float speed = 1.5f;
    public float maxspeed = 4.0f;
    private Vector2 targetPos;
    private Vector2 trajectory;

    private Rigidbody2D rb;

    public bool canMove;

    void Start()
    {   
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!canMove)
        {
            return;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            
            transform.position = transform.position - new Vector3(speed,0,0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = transform.position + new Vector3(speed, 0, 0);
        }

        // op linker mouseclick
        if (Input.GetMouseButton(0))
        {

            if (Input.mousePosition.x > transform.position.x + Screen.width/2)
                transform.position = transform.position + new Vector3(speed, 0, 0);
            if (Input.mousePosition.x < transform.position.x + Screen.width/2)
                transform.position = transform.position - new Vector3(speed, 0, 0);

        }
       
    }

    //Collision
    void OnTriggerStay2D(Collider2D col)
    {
        //if this object collides with object Door, Scene2 will be loaded.
        if(col.gameObject.tag == "Door")
        {
			if (Input.GetMouseButton (1)) {
				SceneManager.LoadScene ("sc_brief_home");
			}

			if(Input.GetMouseButtonDown(0))
			{
				SceneManager.LoadScene ("sc_brief_home");
			}



            if (Input.GetKey("up"))
            {
                SceneManager.LoadScene("sc_brief_home");
            }
            
        }

        if (col.gameObject.tag == "Letter")
        {
            if (Input.GetKey(KeyCode.Return))
            {
                GameObject.Destroy(gameObject);
            }

        }

        if (col.gameObject)
        {

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
