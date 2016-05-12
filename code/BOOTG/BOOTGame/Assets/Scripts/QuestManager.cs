using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class QuestManager : MonoBehaviour {

    int[] scenario1;
	// Use this for initialization
	void Start () {
        scenario1 = new int[5];
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OptionGood(int step)
    {
        scenario1[step] = 3;
        Debug.Log(scenario1);
    }
    public void OptionBad(int step)
    {
        scenario1[step] = 1;
        Debug.Log(scenario1);

    }
    public void OptionMed(int step)
    {
        scenario1[step] = 2;
        Debug.Log(scenario1);

    }


}
