﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DeleteBrief : MonoBehaviour {

    public bool gemeenteBrief;
    public bool abnBrief;
    public bool staatsloterijLetter;

	// Use this for initialization
	void Update ()
    {
        if (gemeenteBrief)
        {
            Destroy(GameObject.Find("gemeenteLetter"));
        }
        if (abnBrief)
        {
            Destroy(GameObject.Find("ABNLetter"));
        }
        if (staatsloterijLetter)
        {
            Destroy(GameObject.Find("staatsloterijLetter"));
        }

        if(gemeenteBrief && abnBrief && staatsloterijLetter)
        {
            SceneManager.LoadScene("sc_gemeenteBrief_choices");
            Destroy(gameObject);
        }
    }
}