﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour {

    //player object, tekst objects en textfiles
    public PlayerMovement player;
    public GameObject textBox;
    public Text theText;
    public TextAsset textFile;
    //string array voor regels tekst
    public string[] textLines;
    //ints om de lines bij te houden
    public int currentLine;
    public int endAtLine;
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
        if (Input.GetKeyDown(KeyCode.Return))
        {
            currentLine += 1;
        }
        //als de line bij endline aankomt word de textbox uitgezet
        if(currentLine > endAtLine)
        {
            DisableTekstBox();
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
    
}
