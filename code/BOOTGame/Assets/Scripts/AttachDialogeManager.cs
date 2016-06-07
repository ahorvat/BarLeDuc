using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class AttachDialogeManager : MonoBehaviour {

    private Button bt;
    DialogeManager DM;

    // Use this for initialization
    void Start () {
        bt = GetComponent<Button>();
        DM = FindObjectOfType<DialogeManager>();
        bt.onClick.AddListener( DM.NextLine );
	}
	
	// Update is called once per frame
	void Update () {
    
	}
}
