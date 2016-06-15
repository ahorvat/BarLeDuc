using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogeManager : MonoBehaviour
{

    // playermovement om de player te stoppen, 2 sprites als background voor de dialoge
    public PlayerMovement player;
    public GameObject textBox;
    public Image image;
    public Sprite bg_yousef;
    public Sprite bg_buurvrouw;
    // bool arrays om aan te geven welke line van welke personage is.
    public bool[] yousef_lines;
    // text = het textvak van de canvas, textasset is het textscript
    public Text yousefText;
    public Text buurvrouwText;
    public TextAsset textFile;

    // string array om de textlines in op te slaan
    public string[] textLines;

    // ints om de lines in de dialoge te handelen
    public int currentLine;
    public int endAtLine;

    // een bool om de canvas aan en uit te zetten
    public bool isActive;
    public bool keepEndLine;

    // een bool om de player te laten stoppen
    public bool stopPlayerMovement;

    // Use this for initialization
    void Start()
    {
        player = FindObjectOfType<PlayerMovement>();

        image = GameObject.Find("Image").GetComponent<Image>();
        yousefText = GameObject.Find("Youssef Text").GetComponent<Text>();
        buurvrouwText = GameObject.Find("Vrouw Text").GetComponent<Text>();

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

        if (isActive)
        {
            EnableDM();
        }

        if (!isActive)
        {
            DisableDM();
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (!isActive)
        {
            return;
        }
        if (currentLine > endAtLine)
        {
            if (keepEndLine)
            {
                return;
            }
            DisableDM();
            return;
        }

        //als de currentline in de boolean lijst true geeft display youseff background.
        if (yousef_lines[currentLine])
        {
            image.sprite = bg_yousef;
            buurvrouwText.text = "";
            yousefText.text = textLines[currentLine];
        }
        //als de currentline niet in de boolean lijst true geeft display vrouw background.
        if (!yousef_lines[currentLine])
        {
            image.sprite = bg_buurvrouw;
            yousefText.text = "";
            buurvrouwText.text = textLines[currentLine];
        }

        if (currentLine == endAtLine && SceneManager.GetActiveScene().name == "sc_street")
        {
            SceneManager.LoadScene("sc_buurvrouwFeedback");
        }
        if(currentLine == endAtLine && SceneManager.GetActiveScene().name == "sc_email_stap8")
        {
            SceneManager.LoadScene("sc_email_feedback");
        }

        hideMoreTextButtonOnDialogueEnd();

    }

    public void EnableDM()
    {
        textBox.SetActive(true);
        if (stopPlayerMovement)
        {
            player.canMove = false;
        }
        isActive = true;
    }
    public void DisableDM()
    {
        textBox.SetActive(false);
        if (stopPlayerMovement)
        {
            player.canMove = true;
        }
        isActive = false;
    }

    public void NextLine()
    {
        //zodra er enter word gedrukt word de volgende line ingeladen
        if (textBox.activeInHierarchy)
        {

                if (keepEndLine && currentLine == endAtLine)
                {
                    return;
                }
                currentLine += 1;
            
        }
    }

    // verwijdert de continue button als de currentline gelijk is aan de endline en de DM nog niet uit staat. wat wel zou moeten.
    private void hideMoreTextButtonOnDialogueEnd()
    {
        if (GameObject.Find("ContinueDialogueButton") && keepEndLine && currentLine == endAtLine)
            GameObject.Find("ContinueDialogueButton").SetActive(false);
    }


}
