using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    //public float for speed so we can change it in the unity editor.
    public float speed;
    //rigidbody so we can get the component and change the position of the rigidbody(player).
    private Rigidbody2D rb;
    private GameObject dialogueBox;
    private GameObject leftArrow;
    private GameObject rightArrow;
    private GameObject textButtons;

    public bool inputboxmiddle;

    //inputboxes for detecting input at the right and left side of the screen.

    public float inputBoxLeft;
    public float inputBoxRight;
    public float inputBoxY;

    //we use the camera to calculate the inputboxes so they stay the same even when we change the camera size.
    private Camera camera;
    //boolean that we set on false in scenes where the player isnt allowed to move and true when he is allowed to move.
    public bool canMove;

    void Start()
    {
        //set the camera to the gameobject camera so we can change its fields.
        camera = FindObjectOfType<Camera>();
        //set the rb(rigidbody) to the rigidbody component of this gameobject(player) so we can change its fields.
        rb = GetComponent<Rigidbody2D>();
        textButtons = GameObject.FindGameObjectWithTag("textButtons");
        leftArrow = GameObject.FindGameObjectWithTag("leftArrow");
        rightArrow = GameObject.FindGameObjectWithTag("rightArrow");
        dialogueBox = GameObject.FindGameObjectWithTag("DialogueBox");
        //calculate the inputboxes on the left and right side of the screen/camera.
        inputBoxRight = camera.pixelWidth - camera.pixelWidth / 4;
        inputBoxLeft = camera.pixelWidth / 4;
        inputBoxY = camera.pixelHeight - camera.pixelHeight / 2;


        if (leftArrow != null)
        {
            leftArrow.SetActive(true);
        }
        if (rightArrow != null)
        {
            rightArrow.SetActive(true);
        }
        
        if (dialogueBox != null)
        {
            dialogueBox.SetActive(false);
        }

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

        /* check if the player is in the menu screen, if yes, return and dont continue running the update method. 
        We don't want to update anything in the player at the menu screen so we can stop running it. Next we check if we set the boolean
        of canMove at false, if so, we return just like the menu screen if statement. We set the canMove boolean at false when the player is talking to a NPC for example. 
        */
        if (SceneManager.GetActiveScene().name == "sc_menu")
        {
            return;
		}
        else if (!canMove)
        { 
			return;
		}

        /*Check for user input on the left mousebutton or if the player touches the screen. If he touches the screen on the right inputbox,
        increase the position with the speed variable that we set in the editor to the position if the player touches the inputbox on the right.
        If the player touches or clicks the left inputbox, decrease the x position of the player with the speed variable. 
        Player sprite flips on when left or right inputbox is clicked.
        */
        if (Input.GetMouseButton(0))
        {
            if (Input.mousePosition.x > inputBoxRight && Input.mousePosition.y < inputBoxY)
            {
                transform.position += new Vector3(speed, 0, 0);
                GetComponent<SpriteRenderer>().flipX = false;
            }
            if (Input.mousePosition.x < inputBoxLeft && Input.mousePosition.y < inputBoxY)
            {
                transform.position -= new Vector3(speed, 0, 0);
                GetComponent<SpriteRenderer>().flipX = true;      
            }
        }
        while (speed < 0.2f)
        {
            speed += 0.0001f;
        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Woman")
        {
            dialogueBox.SetActive(true);
            leftArrow.SetActive(false);
            rightArrow.SetActive(false);
            textButtons.SetActive(false);
            canMove = false;
        }

    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Woman")
        {
            dialogueBox.SetActive(false);
            leftArrow.SetActive(true);
            rightArrow.SetActive(true);
            textButtons.SetActive(true);
            canMove = true;
        }

    }

    //OnTriggerStay checks if the gameobject(player) is standing on a trigger and isnt moving.
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "leftCamBorder")
        {
            speed = 0;
            transform.position = new Vector3(transform.position.x + 0.1f, transform.position.y, transform.position.z);
        }
        if (col.gameObject.tag == "rightCamBorder")
        {
            speed = 0;
            transform.position = new Vector3(transform.position.x - 0.1f, transform.position.y, transform.position.z);
        }

        // Debug.Log("Collide");
        //for interaction with object, we check if the player touches in the middle of the screen, or touches right of the left inputbox and left of the right inputbox.
        if (Input.GetMouseButtonDown(0) && inputboxmiddle)
        {
            //check which gameobject the player is colliding with at the moment he clicks in the middle of the screen.
            if (col.gameObject.tag == "Letter")
            {
                SceneManager.LoadScene("sc_brief_closeup");
            }

            if (col.gameObject.tag == "pcBackground")
            {
                SceneManager.LoadScene("sc_google_closeup");
            }

            if (col.gameObject.tag == "Door")
            {
                SceneManager.LoadScene("sc_street");
            }

            if (col.gameObject.tag == "Door2")
            {
                SceneManager.LoadScene("sc_brief_home_buurvrouw");
            }

            if (col.gameObject.tag == "PC")
            {
                SceneManager.LoadScene("sc_google_closeup");
            }
            if (col.gameObject.tag == "digidBrief")
            {
                SceneManager.LoadScene("sc_DigiDBrief");
            }
        }
    }

    //method to destroy the player
    public void DestroyPlayer()
    {
        Destroy(gameObject);
    }
}
