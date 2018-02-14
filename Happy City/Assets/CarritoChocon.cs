using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarritoChocon : MonoBehaviour {

    public GameObject player;

	// Use this for initialization
	void Start () {

        player = GameObject.Find("Player");
		
	}

    // Update is called once per frame
    void Update() {

        if (transform.position.z - player.transform.position.z < 40)
        {
            transform.Translate(new Vector3(0,0,-0.1f));
        }
		
	}
}
