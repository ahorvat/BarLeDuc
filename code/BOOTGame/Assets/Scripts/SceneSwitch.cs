using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour {

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
}
