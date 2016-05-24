using UnityEngine;
using System.Collections;
using UnityEngine.UI;

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

    // een bool om de player te laten stoppen
    public bool stopPlayerMovement;

    // Use this for initialization
    void Start()
    {
        player = FindObjectOfType<PlayerMovement>();
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
    }

    // Update is called once per frame
    void Update()
    {
        if (!isActive)
        {
            return;
        }
        //zodra er enter word gedrukt word de volgende line ingeladen
        if (textBox.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0))
            {
                currentLine += 1;
            }
        }

        if (yousef_lines[currentLine])
        {
            image.sprite = bg_yousef;
            buurvrouwText.text = "";
            yousefText.text = textLines[currentLine];
        }
        if (!yousef_lines[currentLine])
        {
            image.sprite = bg_buurvrouw;
            yousefText.text = "";
            buurvrouwText.text = textLines[currentLine];
        }

        if (currentLine > endAtLine)
        {
            textBox.SetActive(false);
            player.canMove = true;
            isActive = false;
        }


    }
    void Youssef()
    {
        image.sprite = bg_yousef;

        buurvrouwText.text = "";
        yousefText.text = textLines[currentLine];
    }

    void Buurvrouw()
    {
        image.sprite = bg_buurvrouw;
        yousefText.text = "";
        buurvrouwText.text = textLines[currentLine];

    }
}
