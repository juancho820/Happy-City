using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Moveorb : MonoBehaviour {

    public KeyCode moveL;
    public KeyCode moveR;

    public GameObject Canvas;

    float jump;
    public float speed;

    public float velocidad = 5;
    public float horizVel = 0;
    public int laneNum = 2;
    public string controlLocked = "n";

    public Transform boomObj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        velocidad += 0.001f;

        GetComponent<Rigidbody>().velocity = new Vector3(horizVel, 0, velocidad);

        if ((Input.GetKeyDown(moveL)) && (laneNum > 1) && (controlLocked == "n"))
        {
            horizVel = -2;
            StartCoroutine(stopSlide());
            laneNum -= 1;
            controlLocked = "y";
        }
        if ((Input.GetKeyDown(moveR)) && (laneNum < 3) && (controlLocked == "n"))
        {
            horizVel = 2;
            StartCoroutine(stopSlide());
            laneNum += 1;
            controlLocked = "y";
        }
        if (Input.GetKeyDown(KeyCode.W) && (controlLocked == "n"))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 1000, ForceMode.Impulse);
            StartCoroutine(stopSlide());
            controlLocked = "y";
        }

    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "lethal")
        {
            Destroy(gameObject);
            Gm.zVelAdj = 0;
            Instantiate(boomObj, transform.position, boomObj.rotation);
            Canvas.SetActive(true);
        }
        if (other.gameObject.name == "Capsule(Clone)")
        {
            Destroy(other.gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "coin(Clone)")
        {
            Destroy(other.gameObject);
            Gm.coinTotal += 1;
        }
    }

    IEnumerator stopSlide()
    {
        yield return new WaitForSeconds(.5f);
        horizVel = 0;
        controlLocked = "n";
    }
}
