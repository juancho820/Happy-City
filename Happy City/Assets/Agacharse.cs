using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agacharse : MonoBehaviour {

    public static bool agacharse = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

        if(agacharse == true)
        {
            gameObject.SetActive(false);
        }
		
	}
}
