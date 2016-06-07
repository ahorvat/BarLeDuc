using UnityEngine;
using System.Collections;

public class PhonecallChangePlayerSprite : MonoBehaviour {

    private DialogeManager DM;
    private SpriteRenderer playerSprite;
    public Sprite spr_boy_calling;

	// Use this for initialization
	void Start () {
        DM = FindObjectOfType<DialogeManager>();
        playerSprite = GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        if(DM.currentLine == 1)
        {
            playerSprite.sprite = spr_boy_calling;
        }
	
	}
}
