using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {


    public static bool isPlayerDead = false;
    public Text gameOver;

	// Use this for initialization
	void Start () {
        gameOver.enabled = false;


	}
	
	// Update is called once per frame
	void Update () {

        if (isPlayerDead)
        {
            gameOver.enabled = true;

            Time.timeScale = 0;

        }

	}


    
}
