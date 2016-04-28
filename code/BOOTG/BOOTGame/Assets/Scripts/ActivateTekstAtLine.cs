﻿using UnityEngine;
using System.Collections;

public class ActivateTekstAtLine : MonoBehaviour {

    // textbestand en textbox object
    public TextAsset theText;
    public TextBoxManager textBox;

    // int voor startline en endline
    public int startLine;
    public int endLine;

    public Sprite Button1;
    public Sprite Button2;
    public Sprite button3;

    public int choise1;
    public int choise2;
    public int choise3;


    // booleans om de behaviour van dit script te handelen.
    public bool hasChoise;

    public bool destroyWhenActivated; //destroy het object waar dit compenent in zit waarneer dit true is.
    public bool requireButtonPress; // of er een keypress nodig is om de text te laten verschijnen
    private bool waitForPress; // een bool om de keypress af te wachten
    

	// Use this for initialization
	void Start ()
    {
        // de textbox word ingeladen d.m.v findobjectoftype zodat we geen textbox hoeven in te laden per NPC of trigger.
        textBox = FindObjectOfType<TextBoxManager>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        // hier word pas text doorgevoerd zodra er een key input is.
        // later moet er nog mouse input voor worden toegevoegd.
        if(waitForPress && Input.GetKeyDown(KeyCode.J))
        {
            // de text word ingeladen in de textbox manager
            // de startline en endline worden meegegeven om de tekst te handelen.

            textBox.ReloadScript(theText);
            textBox.currentLine = startLine;
            textBox.endAtLine = endLine;

            if (hasChoise)
            {
                textBox.buttonSprite1 = Button1;
                textBox.buttonSprite2 = Button2;
                textBox.buttonSprite3 = button3;

                textBox.buttonChoise1 = choise1;
                textBox.buttonChoise2 = choise2;
                textBox.buttonChoise3 = choise3;

            }
            textBox.EnableTekstBox();
            if (destroyWhenActivated)
            {
                Destroy(gameObject);
            }
        }
	}
    // zodra er collision is
    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.name == "Player")
        {
            // en er een keybutton nodig is word waitforpress op true gezet
            if(requireButtonPress)
            {
                waitForPress = true;
                return;
            }
            // anders word er op collision deze code uitgevoerd

            textBox.ReloadScript(theText);
            textBox.currentLine = startLine;
            textBox.endAtLine = endLine;
            textBox.EnableTekstBox();

            if (hasChoise)
            {

                textBox.buttonSprite1 = Button1;
                textBox.buttonSprite2 = Button2;
                textBox.buttonSprite3 = button3;

                textBox.buttonChoise1 = choise1;
                textBox.buttonChoise2 = choise2;
                textBox.buttonChoise3 = choise3;

            }

            if (destroyWhenActivated)
            {
                Destroy(gameObject);
            }
        }
    }
    // als er geen collision is kan de textbox niet geactivated worden d.m.v keypress.
    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.name == "Player")
        {
            waitForPress = false;
        }
    }
}
