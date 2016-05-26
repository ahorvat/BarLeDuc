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
    public bool kutMathijs;

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
            if (kutMathijs)
            {
                return;
            }
            DisableDM();
        }
        //zodra er enter word gedrukt word de volgende line ingeladen
        if (textBox.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonDown(0))
            {
                if (kutMathijs && currentLine == endAtLine)
                {
                    return;
                }
                currentLine += 1;
            }
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
}
