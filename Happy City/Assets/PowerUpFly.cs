using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpFly : MonoBehaviour {

    public Transform player;
    public  Transform PuntoA;
    public Transform PuntoB;
    public static bool Fly = false;

    public float journeyTime = 1.0F;
    private float startTime;

    // Use this for initialization
    void Start () {

        startTime = Time.time;

    }
	
	// Update is called once per frame
	void Update () {

        //PuntoB.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z+100);

        if(Fly == true)
        {
            Vector3 center = (PuntoA.position + PuntoB.position) * 0.5F;
            center -= new Vector3(0, 1, 0);
            Vector3 riseRelCenter = PuntoA.position - center;
            Vector3 setRelCenter = PuntoB.position - center;
            float fracComplete = (Time.time - startTime) / journeyTime;
            transform.position = Vector3.Slerp(riseRelCenter, setRelCenter, fracComplete);
            transform.position += center;
        }

        float dist = Vector3.Distance(transform.position, PuntoB.transform.position);

        if (dist < 0.1f)
        {
            player.transform.position = PuntoB.transform.position;
            Fly = false;
        }
    }
}
