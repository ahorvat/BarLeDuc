using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class TBM_Extend : zOD_TextBoxManager {
    public GameObject DialogYoussef;
    public GameObject DialogHenk;
    public Scene activeScene;
	// Use this for initialization
	void Start () {
        Scene activeScene = SceneManager.GetActiveScene();
        DialogHenk.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        theText.text = textLines[currentLine];
        if (textBox.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.Return) || Input.GetMouseButtonUp(0))
            {
                currentLine += 1;
            }
        }

        if (currentLine == 2)
        {
            DialogYoussef.SetActive(false);
            DialogHenk.SetActive(true);
        }
        if (currentLine == 3)
        {
            DialogYoussef.SetActive(true);
            DialogHenk.SetActive(false);
        }
        if (currentLine == 4)
        {
            DialogYoussef.SetActive(false);
            DialogHenk.SetActive(true);
        }
        if (currentLine == 5)
        {
            DialogYoussef.SetActive(true);
            DialogHenk.SetActive(false);
        }
        if (currentLine == 6)
        {
            SceneManager.LoadScene("sc_incorrectPhonecall");
        }
    }
}
