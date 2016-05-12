using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    // Use this for initialization
    public GameObject TestText;
    public float speed = 1.5f;
    public float maxspeed = 4.0f;
    public GameObject player;
    private Rigidbody2D rb;
    public float inputBoxLeft = 400;
    public float inputBoxRight = 1136; 

    public bool canMove;

    void Start()
    {
       
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Screen.width);
        if (Application.loadedLevelName == "sc_menu") {
            return;
		} else
        if (!canMove) { 
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

            if (Input.mousePosition.x > inputBoxRight)
                transform.position = transform.position + new Vector3(speed, 0, 0);
            if (Input.mousePosition.x < inputBoxLeft)
                transform.position = transform.position - new Vector3(speed, 0, 0);

        }


        if (Application.loadedLevelName == "sc_brief_closeup")
        {
            Destroy(gameObject);
        }

    }

    //Collision
    void OnTriggerStay2D(Collider2D col)
    {

        if (Input.GetMouseButtonDown(0)) {

            if (Input.mousePosition.x >= inputBoxLeft && Input.mousePosition.x <= inputBoxRight)
            {
                if (col.gameObject.tag == "Letter")
                {
                    SceneManager.LoadScene("sc_brieven_closeup");
                }
            }
        }

        //if this object collides with object Door, Scene2 will be loaded.
        if (col.gameObject.tag == "Door")
        {
            if (Input.GetMouseButton(1)) {
                SceneManager.LoadScene("sc_brief_home");
            }

        }

            if (Input.GetKey("up"))
            {
                SceneManager.LoadScene("sc_brief_home");

            }



        if (col.gameObject.tag == "Letter")
        {
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("sc_brief_closeup");
             
            }

        }


        //if this object collides with object TestPerson, the method with the name "move" will be executed.
        if (col.gameObject.name == "TestPerson")
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
