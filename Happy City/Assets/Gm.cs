using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Gm : MonoBehaviour {

    public static int coinTotal = 0;
    public static float timeTotal = 0;
    public float waitToLoad = 0;

    public float zScenePos = 60;
    public float posJug;

    public static float zVelAdj = 1;

    public Transform bbNoPit;
    public Transform bbPitMid;
    public Transform inicio;
    public Transform Proced1;
    public Transform Proced2;
    public Transform Proced3;
    public Transform player;


    public Transform CoinObj;
    public Transform ObstObj;
    public Transform CapsuleObj;

    public int randNum;

    // Use this for initialization
    void Start () {

        posJug = player.transform.position.z;

        Instantiate(inicio, new Vector3(2, 2.25f, 18), inicio.rotation);

        Instantiate(bbNoPit, new Vector3(0,2.25f,42), bbNoPit.rotation);
        Instantiate(bbNoPit, new Vector3(0, 2.25f, 46), bbNoPit.rotation);

        Instantiate(bbPitMid, new Vector3(0, 2.25f, 50), bbPitMid.rotation);
        Instantiate(bbPitMid, new Vector3(0, 2.25f, 54), bbPitMid.rotation);
        
    }
	
	// Update is called once per frame
	void Update () {

        posJug = player.transform.position.z;

        if (zScenePos < 120+posJug)
        {
            randNum = Random.Range(0, 10);

            if (randNum < 3)
            {
                //Instantiate(CoinObj, new Vector3(-1,3.25f,zScenePos), CoinObj.rotation);
                Instantiate(Proced1, new Vector3(0, 2.25f, zScenePos), Proced1.rotation);
            }
            if (randNum > 7)
            {
                //Instantiate(CoinObj, new Vector3(1, 3.25f, zScenePos), CoinObj.rotation);
                Instantiate(Proced2, new Vector3(0, 2.25f, zScenePos), Proced2.rotation);
            }
            if (randNum >= 3 || randNum <=7)
            {
                Instantiate(Proced3, new Vector3(0, 2.25f, zScenePos), Proced3.rotation);
            }
            if (randNum == 4)
            {
                Instantiate(ObstObj, new Vector3(1, 3.25f, zScenePos), ObstObj.rotation);
            }
            if (randNum == 5)
            {
                Instantiate(ObstObj, new Vector3(0, 3.25f, zScenePos), ObstObj.rotation);
            }

            zScenePos += 36;
        }

        timeTotal += Time.deltaTime;
	}
    public void Reiniciar()
    {
        SceneManager.LoadScene("Play");
    }
}
