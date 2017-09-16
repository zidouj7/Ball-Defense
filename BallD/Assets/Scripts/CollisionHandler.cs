using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollisionHandler : MonoBehaviour {
    public GameObject activePrefabs;
    public Transform spawnPoint;
    public GameObject[] difColorsDif2;



    void OnCollisionEnter2D(Collision2D collision)
    {



            if (collision.gameObject.tag == "Boundary")
            {


                Instantiate(difColorsDif2[0], spawnPoint.position, transform.rotation);


                Destroy(gameObject);



            }
            else if (collision.gameObject.tag == "Enemy")
            {

                Instantiate(difColorsDif2[0], spawnPoint.position, transform.rotation);
                TheBall.score++;

                Destroy(gameObject);



            }
            else if (collision.gameObject.tag == "Boss")
            {
                Instantiate(difColorsDif2[0], spawnPoint.position, transform.rotation);

                Destroy(gameObject);
                


        }





    }

    
}


