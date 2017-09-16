using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour {

    public Transform[] path;
    public float speed;
    public float reachDist = 1.0f;
    public int current = 0;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        float dist = Vector3.Distance(path[current].position, transform.position);
        transform.position = Vector3.Lerp(transform.position, path[current].position, Time.deltaTime * speed);

        if (dist <= reachDist)
        {
            current++;
        }

        if(current >= path.Length)
        {
            current = 0;
        }

	}


    
}
