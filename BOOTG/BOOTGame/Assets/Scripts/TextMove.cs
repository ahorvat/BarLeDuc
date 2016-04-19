using UnityEngine;
using System.Collections;

public class TextMove : MonoBehaviour {

    private Rigidbody2D rb;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
	}
	

    void Move()
    {
        rb.MovePosition(new Vector2(-1.212f, 0.538f));
    }

    void ReMove()
    {
        rb.MovePosition(new Vector2(-20, -20));
    }
}
