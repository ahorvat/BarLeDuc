using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour {
    private GameObject dialogueManager;
    private DialogeManager dialogueScript;


    void Start()
    {
        dialogueManager = GameObject.FindGameObjectWithTag("dialogueManager");
        dialogueScript = dialogueManager.GetComponent<DialogeManager>();
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "sc_DigiDStap6")
        {
            if (dialogueScript.currentLine == dialogueScript.endAtLine && Input.GetMouseButtonUp(0))
            {
                SceneManager.LoadScene("sc_ontvang_code");
            }
        }
    }
	public void sc_brief_home_google()
    {
        SceneManager.LoadScene("sc_brief_home_google");
        return;
    }

    public void sc_brief_home_phone()
    {
        SceneManager.LoadScene("sc_brief_home_phonecall");
        return;
    }
    public void sc_brief_home_buurvrouw()
    {
        SceneManager.LoadScene("sc_brief_home_buurvrouw");
        return;
    }

    public void sc_incorrectchoice_dialogue()
    {
        SceneManager.LoadScene("sc_incorrectchoice_dialogue");
        return;
    }

}
