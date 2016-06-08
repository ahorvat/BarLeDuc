using UnityEngine;
using System.Collections;

public class activateGameObject : MonoBehaviour {

    private DialogeManager dialogueManager;

    // Use this for initialization
    void Start()
    {
        dialogueManager = GameObject.FindGameObjectWithTag("dialogueManager").GetComponent<DialogeManager>();
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (dialogueManager.currentLine == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
