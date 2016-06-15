using UnityEngine;
using System.Collections;

public class disableNavOnDialogue : MonoBehaviour {

	private PlayerMovement player;
	private GameObject[] navArrows;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerMovement>();
		navArrows = GameObject.FindGameObjectsWithTag("navArrow");
	}
	
	// Update is called once per frame.
	void Update () {
		if (!player || !player.canMove)
		{
			foreach (GameObject arrow in navArrows)
			{
				arrow.SetActive(false);
			}
		} else {
			foreach (GameObject arrow in navArrows)
			{
				arrow.SetActive(true);
			}
		}
	}
}
