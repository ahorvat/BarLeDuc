using UnityEngine;
using System.Collections;

public class QuestManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ButtonChoises(int choise)
    {
        if (choise == 1)
        {
            Debug.Log("woop");
        }
        else
        {
            Debug.Log("shawoop");
        }
    }
}
