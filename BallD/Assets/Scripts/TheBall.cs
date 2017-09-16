using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TheBall : MonoBehaviour {
    public GameObject[] startingBalls;
    public GameObject startball;
    public Transform spawnPoint;

    public static int score = 0;
    public static int levelCount;
    public Text scoreText;

    // Use this for initialization
    void Start () {
        startball = (GameObject)Instantiate(startingBalls[0], spawnPoint.position, transform.rotation);

    }

    // Update is called once per frame
    void Update () {

        scoreText.text = "Score: " + score;



    }
}
