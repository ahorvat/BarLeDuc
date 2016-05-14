using UnityEngine;
using System.Collections;

public class changingSpritesLeftArrow : MonoBehaviour {

    public Sprite sprite1; // Drag your first sprite here
    public Sprite sprite2; // Drag your second sprite here
    private PlayerMovement player;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        player = FindObjectOfType<PlayerMovement>();

        spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
        if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
            spriteRenderer.sprite = sprite1; // set the sprite to sprite1
    }

    void Update()
    {
    
           ChangeTheDamnSprite(); // call method to change sprite
    }

    void ChangeTheDamnSprite()
    {
        if (Input.GetMouseButton(0) && Input.mousePosition.x < player.inputBoxLeft)
        {
            spriteRenderer.sprite = sprite2;
        }
        else if(Input.GetMouseButton(0) && Input.mousePosition.x < player.inputBoxRight && Input.mousePosition.x > player.inputBoxLeft)
        {
            spriteRenderer.sprite = sprite1;
        }
        else
        {
            spriteRenderer.sprite = sprite1;
        }


    }
}
