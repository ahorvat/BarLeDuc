using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class incorrectPhonecall : MonoBehaviour {
    private DialogeManager dialogueManager;

    void Start()
    {
        dialogueManager = FindObjectOfType<DialogeManager>();
    }

	// Update is called once per frame
	void Update () {
        if (!dialogueManager.isActive)
        {
            SceneManager.LoadScene("sc_phonecallFeedback");
        }
	}
}
