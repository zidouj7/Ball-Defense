using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

    public void LoadLevel(string name)
    {
        SceneManager.LoadScene(name);
        GameOver.isPlayerDead = false;
        Time.timeScale = 1;
        TheBall.score = 0;

    }
}
