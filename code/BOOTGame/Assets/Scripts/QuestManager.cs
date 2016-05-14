using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class QuestManager : MonoBehaviour {

    int[] scenario1;

	// Use this for initialization
	void Start () {
        scenario1 = new int[5];
	}
	
    public void OptionGood(int step)
    {
        scenario1[step] = 3;
    }
    public void OptionBad(int step)
    {
        scenario1[step] = 1;
    }
    public void OptionMed(int step)
    {
        scenario1[step] = 2;
    }
}
