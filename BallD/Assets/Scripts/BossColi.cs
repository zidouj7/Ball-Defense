using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossColi : MonoBehaviour {


    public int HP = 4;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {



        if (collision.gameObject.tag == "Boundary")
        {
            GameOver.isPlayerDead = true;




            Destroy(gameObject);



        }
        if (collision.gameObject.tag == "Player")
        {
            if(HP == 0)
            {


                TheBall.score++;
                DidPlayerWin.didPlayerWin = true;
                Destroy(gameObject);

            }
            else
            {
                HP--;

            }

        }
    }

}
