using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour {

    //player object, tekst objects en textfiles
    public PlayerMovement player;
    public GameObject textBox;
    public GameObject optionBox;
    public QuestManager questManager;
    //buttons
    public Button option1;
    public Button option2;
    public Button option3;
    public Sprite buttonSprite1;
    public Sprite buttonSprite2;
    public Sprite buttonSprite3;
    public int buttonChoise1;
    public int buttonChoise2;
    public int buttonChoise3;
    //text
    public Text theText;
    public TextAsset textFile;
    //string array voor regels tekst
    public string[] textLines;
    //ints om de lines bij te houden
    public int currentLine;
    public int endAtLine;
    public int optionLine;
    // een bool om de canvas aan en uit te zetten
    public bool isActive;
    // een bool om de player te laten stoppen
    public bool stopPlayerMovement;


	// Use this for initialization
	void Start ()
    {
        //als de tekst niet leeg is dan word de tekst opgesplits per enter
	    if (textFile != null)
        {
            textLines = (textFile.text.Split('\n'));
        }
        //als er geen endline word meegegeven word de enldline de max aantal regels
        if (endAtLine == 0)
        {
            endAtLine = textLines.Length - 1;
        }
        // waarneer active word enable tekstbox aangeroepen, anders disable tekxtbox
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
        //de text in de canvas is de currentline
        theText.text = textLines[currentLine];
        //zodra er enter word gedrukt word de volgende line ingeladen
        if (textBox.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0))
            {
                currentLine += 1;
            }
        }
        
        //als de line bij endline aankomt word de textbox uitgezet
        if(currentLine > endAtLine)
        {
            DisableTekstBox();
        }
        if(currentLine == optionLine)
        {
            option1.image.sprite = buttonSprite1;
            option2.image.sprite = buttonSprite2;
            option3.image.sprite = buttonSprite3;
            option1.onClick.AddListener(QuestChoise1);
            option2.onClick.AddListener(QuestChoise2);
            option3.onClick.AddListener(QuestChoise3);
            textBox.SetActive(false);
            optionBox.SetActive(true);
        }
	}
    //een functie om de textbox aan te zetten en de player movement still te zetten. de playermovement is toggle baar
    public void EnableTekstBox()
    {
        textBox.SetActive(true);
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
        textBox.SetActive(false);
        player.canMove = true;
        isActive = false;
    }
    // in deze funtie word er een nieuw textbestand ingeladen. bijna hetzelfde aan het begin van het script
    // maar dan bruikbaar voor activetekstlines.
    public void ReloadScript(TextAsset theText)
    {
        if (theText != null)
        {
            textLines = new string[1];
            textLines = (theText.text.Split('\n'));

        }
    }
    public void QuestChoise1()
    {
        //questManager.ButtonChoises(buttonChoise1);
        DisableTekstBox();

    }
    public void QuestChoise2()
    {
        //questManager.ButtonChoises(buttonChoise2);
        DisableTekstBox();

    }
    public void QuestChoise3()
    {
        //questManager.ButtonChoises(buttonChoise3);
        DisableTekstBox();
    }
    public void DebugTest()
    {
        Debug.Log("test");
    }
    
}
