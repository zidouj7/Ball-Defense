using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class EnemyCol : MonoBehaviour

{ 
    // Use this for initialization
    void OnCollisionEnter2D(Collision2D collision)
    {



        if (collision.gameObject.tag == "Boundary")
        {
            GameOver.isPlayerDead = true;




            Destroy(gameObject);



        }
        if (collision.gameObject.tag == "Player")
        {


            Destroy(gameObject);


        }
    }
}