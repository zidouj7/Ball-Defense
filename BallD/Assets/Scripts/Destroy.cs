using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {


    public float lifetime = 2;
	// Use this for initialization
	void Start () {
        Destroy(gameObject, lifetime);

    }

    // Update is called once per frame
    void Update () {
		
	}
}
