using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour {

    

    public GameObject[] Enemy;
    public Transform enemySpawn1;
    public Transform enemySpawn2;
    public Transform enemySpawn3;
    public Transform bossSpawn;
    public GameObject Boss;
	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnRandom1", 2f, 2.5f);
        InvokeRepeating("SpawnRandom2", 3f, 2.5f);
        InvokeRepeating("SpawnRandom3", 4f, 2.5f);
        Invoke("SpawnBoss", 20);
        
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void SpawnRandom()
    {
        //Vector3 screenPosition = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width/2, Screen.height/2, Camera.main.nearClipPlane+5)); //will get the middle of the screen

        Instantiate(Enemy[Random.Range(0, Enemy.Length)], enemySpawn1.position, transform.rotation);
    }

    void SpawnRandom2()
    {
        Instantiate(Enemy[Random.Range(0, Enemy.Length)], enemySpawn1.position, transform.rotation);

    }
    void SpawnRandom3()
    {
        Instantiate(Enemy[Random.Range(0, Enemy.Length)], enemySpawn1.position, transform.rotation);

    }
    void SpawnBoss()
    {
        Instantiate(Boss, bossSpawn.position, transform.rotation);
        Debug.Log("Spawn Boss");

    }
}

