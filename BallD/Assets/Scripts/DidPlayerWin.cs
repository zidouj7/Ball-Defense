using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DidPlayerWin : MonoBehaviour {

    public static bool didPlayerWin = false;
    public Text playerWin;


	// Use this for initialization
	void Start () {
        playerWin.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

        if (didPlayerWin)
        {
            Time.timeScale = 0;
            playerWin.enabled = true;
        }


	}
}
