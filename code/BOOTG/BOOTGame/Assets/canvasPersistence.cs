using UnityEngine;
using System.Collections;

public class canvasPersistence : MonoBehaviour {
    public Canvas pause;
    public PlayerMovement player;
    

    // Use this for initialization
    void Start () {
        DontDestroyOnLoad(gameObject);
        player = FindObjectOfType<PlayerMovement>();
        //pause = FindObjectOfType<Canvas>();
	}
	
	// Update is called once per frame
	void Update () {
        
	}
   /* void OnLevelWasLoad(int level)
    {
        if (level == 3)
            player.SetActive(true);
            

    }
    */
}
