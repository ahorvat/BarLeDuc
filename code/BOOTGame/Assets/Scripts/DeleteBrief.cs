using UnityEngine;
using System.Collections;

public class DeleteBrief : MonoBehaviour {

    public bool gemeenteBrief;
    public bool abnBrief;
    public bool staatsloterijLetter;

	// Use this for initialization
	void Update ()
    {
        if (gemeenteBrief)
        {
            Debug.Log("adfasdf");
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
    }
}
