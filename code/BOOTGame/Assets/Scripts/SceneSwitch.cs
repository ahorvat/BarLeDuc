using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    private GameObject dialogueManager;
    private DialogeManager dialogueScript;


    void Start()
    {
        dialogueManager = GameObject.FindGameObjectWithTag("dialogueManager");
        dialogueScript = dialogueManager.GetComponent<DialogeManager>();
    }

    void Update()
    {
        if (dialogueScript.currentLine == dialogueScript.endAtLine && Input.GetMouseButtonUp(0))
        {
            if (SceneManager.GetActiveScene().name == "sc_DigiDStap6")
            {
                SceneManager.LoadScene("sc_DigiD_TimePass");
            }

            if (SceneManager.GetActiveScene().name == "sc_DigiDStap5")
            {
                SceneManager.LoadScene("sc_DigiDStap6");
            }
            if (SceneManager.GetActiveScene().name == "sc_DigiDStap8")
            {
                SceneManager.LoadScene("sc_DigiDStap9");
            }
            if (SceneManager.GetActiveScene().name == "sc_DigiDStap9")
            {
                SceneManager.LoadScene("sc_FeedBack_Scene");
            }
            if (SceneManager.GetActiveScene().name == "sc_DigiDStap2")
            {
                SceneManager.LoadScene("sc_BSN_zoeken");
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
    public void sc_emailGoogleCorrect()
    {
        SceneManager.LoadScene("sc_emailGoogleCorrect");
        return;
    }

    public void sc_emailGoogleIncorrect()
    {
        SceneManager.LoadScene("sc_emailGoogleIncorrect");
        return;
    }
}
