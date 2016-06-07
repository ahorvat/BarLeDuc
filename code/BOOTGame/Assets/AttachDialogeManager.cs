using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AttachDialogeManager : MonoBehaviour {


	// Use this for initialization
	void Start () {
        Button bt = GetComponent<Button>();
        DialogeManager DM = FindObjectOfType<DialogeManager>();
        bt.onClick.AddListener( DM.NextLine );
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
