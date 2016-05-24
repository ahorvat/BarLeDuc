using UnityEngine;
using System.Collections;

public class changingSprites : MonoBehaviour {


    //Make a public sprite so we can add sprite 1 and 2 in the editor itself.
    public Sprite sprite1;
    public Sprite sprite2;
    //declare a playermovement object so we can adjust the player variables.
    private PlayerMovement player;
    //declare a playermovement object so we can change the rendered sprite later.
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        //set the player to the playermovement script.
        player = FindObjectOfType<PlayerMovement>();
        //set the spriterenderer to the spriterenderer component of this gameobject.
        spriteRenderer = GetComponent<SpriteRenderer>();
        //set the sprite to the first sprite even if there is no sprite selected.
        if (spriteRenderer.sprite == null)
        {
            spriteRenderer.sprite = sprite1;
        }
    }

    void Update()
    {
        //call the changing sprites method each frame.
        ChangeSprite();
    }

    //method to change the sprite.
    void ChangeSprite()
    {
        //check if the input is in the right inputbox.
        if (Input.GetMouseButtonDown(0) && player.inputboxmiddle && spriteRenderer.sprite == sprite1)
        {
            //so we can change the sprite to sprite2(button pressed sprite).
            spriteRenderer.sprite = sprite2;
        }
        //check if the mouseclick is in the middle of the screen
        else if (Input.GetMouseButtonDown(0) && player.inputboxmiddle && spriteRenderer.sprite == sprite2)
        {
            //set the sprite to the not-pressed sprite.
            spriteRenderer.sprite = sprite1;
        }

    }
}
