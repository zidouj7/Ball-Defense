using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {
    public Rigidbody2D rb;
    private Vector3 startPos;
    private Vector3 swipeDirection;

    public GameObject activePrefab;


    public float speed = 10f;

    void Start() {



        rb = GetComponent<Rigidbody2D>();



    }

    void Update()
    {


        if (Input.GetButtonDown("Fire1"))
        {


            startPos = Input.mousePosition;





        }

        if (Input.GetButtonUp("Fire1"))
        {
            Vector2 endPos = Input.mousePosition;

            Debug.Log(endPos);

            swipeDirection = new Vector3(endPos.x - startPos.x, endPos.y - startPos.y, 0);
            swipeDirection.Normalize();

            rb.AddForce(swipeDirection * speed);



        }

    }








}

