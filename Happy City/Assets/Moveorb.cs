using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Moveorb : MonoBehaviour {

    public KeyCode moveL;
    public KeyCode moveR;

    public int PowerMoneda = 1;

    public Transform puntoa, puntob, puntoc;
    public GameObject Canvas;

    float speed = 1f;
    int linea = 0;
    public float velocidadZ = 5;
    public string controlLocked = "n";

    public Transform boomObj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        velocidadZ += 0.001f;
        speed += 0.001f;
        float step = speed * Time.deltaTime;

        GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, GetComponent<Rigidbody>().velocity.y, velocidadZ);

        if (Input.GetKeyDown(moveL))
        {
            linea -= 1;
            if(linea < -1)
            {
                linea = -1;
            }
        }
        if (Input.GetKeyDown(moveR))
        {
            linea += 1;
            if (linea > 1)
            {
                linea = 1;
            }
        }

        if(linea == -1)
        {
            transform.position = Vector3.MoveTowards(transform.position, puntoa.position, step);
        }
        if (linea == 0)
        {
            transform.position = Vector3.MoveTowards(transform.position, puntob.position, step);
        }
        if (linea == 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, puntoc.position, step);
        }

        if (Input.GetKeyDown(KeyCode.W) && (controlLocked == "n"))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 50, ForceMode.Impulse);
            StartCoroutine(stopSlide());
            controlLocked = "y";
        }

    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "lethal")
        {
            Destroy(gameObject);
            Instantiate(boomObj, transform.position, boomObj.rotation);
            Canvas.SetActive(true);
        }
        if (other.gameObject.name == "Capsule(Clone)")
        {
            Destroy(other.gameObject);
            PowerMoneda = 2;
            StartCoroutine(StopPowerUp());
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "coin(Clone)")
        {
            Destroy(other.gameObject);
            Gm.coinTotal += 1*PowerMoneda;
        }
    }

    IEnumerator stopSlide()
    {
        yield return new WaitForSeconds(.5f);
        controlLocked = "n";
    }
    IEnumerator StopPowerUp()
    {
        yield return new WaitForSeconds(10f);
        PowerMoneda = 1;
    }
}
