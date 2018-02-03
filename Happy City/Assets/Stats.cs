using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (gameObject.name == "Coins")
        {
            GetComponent<TextMesh>().text = "Coins : " + Gm.coinTotal;
        }
        if (gameObject.name == "Time")
        {
            GetComponent<TextMesh>().text = "Time : " + Gm.timeTotal;
        }
        if (gameObject.name == "runStatus")
        {
            GetComponent<TextMesh>().text =  Gm.lvlCompStatus;
        }

    }
}
