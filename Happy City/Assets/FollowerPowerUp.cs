using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerPowerUp : MonoBehaviour {

    public GameObject player;

	void Update () {

        transform.position = new Vector3(transform.position.x, player.transform.position.y, player.transform.position.z);
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "coin(Clone)")
        {
            Destroy(other.gameObject);
            Gm.coinTotal += 1 * Moveorb.PowerMoneda;
        }
    }
}
