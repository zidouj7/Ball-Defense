using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {

    public void LoadLevel(string name)
    {
        SceneManager.LoadScene(name);
        GameOver.isPlayerDead = false;
        Time.timeScale = 1;


    }

    public void SetPlayerAlive()
    {
        Time.timeScale = 1;

        GameOver.isPlayerDead = false;
        DidPlayerWin.didPlayerWin = false;
        Debug.Log("Run");
    }
}
