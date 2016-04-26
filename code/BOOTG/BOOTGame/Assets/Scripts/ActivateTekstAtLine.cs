using UnityEngine;
using System.Collections;

public class ActivateTekstAtLine : MonoBehaviour {


    public TextAsset theText;

    public int startLine;
    public int endLine;

    public TextBoxManager textBox;

    public bool destroyWhenActivated;

    public bool requireButtonPress;
    private bool waitForPress;

	// Use this for initialization
	void Start ()
    {

        textBox = FindObjectOfType<TextBoxManager>();
        	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(waitForPress && Input.GetKeyDown(KeyCode.J))
        {
            textBox.ReloadScript(theText);
            textBox.currentLine = startLine;
            textBox.endAtLine = endLine;
            textBox.EnableTekstBox();

            if (destroyWhenActivated)
            {
                Destroy(gameObject);
            }
        }
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.name == "Player")
        {
            if(requireButtonPress)
            {
                waitForPress = true;
                return;
            }
            textBox.ReloadScript(theText);
            textBox.currentLine = startLine;
            textBox.endAtLine = endLine;
            textBox.EnableTekstBox();

            if (destroyWhenActivated)
            {
                Destroy(gameObject);
            }
        }
    }
    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.name == "Player")
        {
            waitForPress = false;
        }
    }
}
