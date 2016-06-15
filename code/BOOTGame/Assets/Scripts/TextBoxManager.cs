using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour {

    //player object, tekst objects en textfiles
    public PlayerMovement player;
    public GameObject optionBox;
    //buttons
    public Button option1;
    public Button option2;
    public Button option3;
    public Sprite buttonSprite1;
    public Sprite buttonSprite2;
    public Sprite buttonSprite3;
    // een bool om de canvas aan en uit te zetten
    public bool isActive;
    // een bool om de player te laten stoppen
    public bool stopPlayerMovement;


	// Use this for initialization
	void Start ()
    {
        if (isActive)
        {
            EnableTekstBox();
        }
        else
        {
            DisableTekstBox();
        }

	}
	
	// Update is called once per frame
	void Update ()
    {
        //als het object niet active is word de code niet gerunned
        if (!isActive)
        {
            return;
        }

            option1.image.sprite = buttonSprite1;
            option2.image.sprite = buttonSprite2;
            option3.image.sprite = buttonSprite3;

            optionBox.SetActive(true);
        
	}
    //een functie om de textbox aan te zetten en de player movement still te zetten. de playermovement is toggle baar
    public void EnableTekstBox()
    {
        isActive = true;
        if (stopPlayerMovement)
        {
            player.canMove = false;
        }
    }
    // een funity om de textbox uit te zetten.
    public void DisableTekstBox()
    {
        optionBox.SetActive(false);
        if(player != null)
        {
            player.canMove = true;
        }
        isActive = false;
    }
}