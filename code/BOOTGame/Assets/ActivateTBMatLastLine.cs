using UnityEngine;
using System.Collections;

public class ActivateTBMatLastLine : MonoBehaviour {

    private TextBoxManager TBM;
    private DialogeManager DM;

	// Use this for initialization
	void Start () {
        TBM = FindObjectOfType<TextBoxManager>();
        DM = FindObjectOfType<DialogeManager>();
	
	}
	
	// Update is called once per frame
	void Update () {
        if (DM.currentLine == DM.endAtLine)
        {
            TBM.EnableTekstBox();
        }
	
	}
}
