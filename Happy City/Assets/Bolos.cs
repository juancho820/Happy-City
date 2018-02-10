using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolos : MonoBehaviour {

    public Transform PuntoA;
    public Transform PuntoB;
    public Transform PuntoC;

    public bool slerp = false;

    public float speed = 1F;
    public float journeyTime;
    private float startTime;

    // Use this for initialization
    void Start () {

        startTime = Time.time;

    }
	
	// Update is called once per frame
	void Update () {
        float step = speed * Time.deltaTime;
        if(slerp == false)
        {
            Vector3 center = (PuntoA.position + PuntoB.position) * 0.5F;
            center -= new Vector3(0, 2, 0);
            Vector3 riseRelCenter = PuntoA.position - center;
            Vector3 setRelCenter = PuntoB.position - center;
            float fracComplete = (Time.time - startTime) / journeyTime;
            transform.position = Vector3.Slerp(riseRelCenter, setRelCenter, fracComplete);
            transform.position += center;
        }

        float dist = Vector3.Distance(transform.position, PuntoB.transform.position);

        if (dist < 0.1f)
        {
            slerp = true;
        }
        if(slerp == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, PuntoC.position, step);
        }


    }
}
