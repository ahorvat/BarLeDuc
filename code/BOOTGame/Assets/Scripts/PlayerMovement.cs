using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    // Use this for initialization
    public float speed;
    private Rigidbody2D rb;
    private bool inputboxmiddle;
    public float inputBoxLeft;
    public float inputBoxRight;
    private Camera camera;
    public bool canMove;

    void Start()
    {
        camera = FindObjectOfType<Camera>();
        inputBoxRight = camera.pixelWidth - 300;
        inputBoxLeft = 300;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.mousePosition.x >= inputBoxLeft && Input.mousePosition.x <= inputBoxRight)
        {
            inputboxmiddle = true;
        } else
        {
            inputboxmiddle = false;
        }
        if (SceneManager.GetActiveScene().name == "sc_menu")
        {
            return;
		}
        else if (!canMove)
        { 
			return;
		}

        // op linker mouseclick
        if (Input.GetMouseButton(0))
        {
            if (Input.mousePosition.x > inputBoxRight)
            {
                transform.position += new Vector3(speed, 0, 0);
            }
            if (Input.mousePosition.x < inputBoxLeft)
            {
                transform.position -= new Vector3(speed, 0, 0);
            }
        }     
    }

    //Collision
    void OnTriggerStay2D(Collider2D col)
    {
        if (Input.GetMouseButtonDown(0) && Input.mousePosition.x >= inputBoxLeft && Input.mousePosition.x <= inputBoxRight)
        {
            if (col.gameObject.tag == "Letter")
                {
                    SceneManager.LoadScene("sc_brief_closeup");
                }
        }
    }

    public void DestroyPlayer()
    {
        Destroy(gameObject);
    }
}
