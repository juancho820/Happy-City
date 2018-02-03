using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Gm : MonoBehaviour {

    public static float veloVer = 0;
    public static int coinTotal = 0;
    public static float timeTotal = 0;
    public float waitToLoad = 0;

    public float zScenePos = 58;

    public static float zVelAdj = 1;

    public static string lvlCompStatus = "";

    public Transform bbNoPit;
    public Transform bbPitMid;

    public Transform CoinObj;
    public Transform ObstObj;
    public Transform CapsuleObj;

    public int randNum;

    // Use this for initialization
    void Start () {

        Instantiate(bbNoPit, new Vector3(0,2.25f,42), bbNoPit.rotation);
        Instantiate(bbNoPit, new Vector3(0, 2.25f, 46), bbNoPit.rotation);

        Instantiate(bbPitMid, new Vector3(0, 2.25f, 50), bbPitMid.rotation);
        Instantiate(bbPitMid, new Vector3(0, 2.25f, 54), bbPitMid.rotation);
        
    }
	
	// Update is called once per frame
	void Update () {

        if (zScenePos < 120)
        {
            randNum = Random.Range(0, 10);

            if(randNum < 3)
            {
                Instantiate(CoinObj, new Vector3(-1,3.25f,zScenePos), CoinObj.rotation);
            }
            if (randNum > 7)
            {
                Instantiate(CoinObj, new Vector3(1, 3.25f, zScenePos), CoinObj.rotation);
            }
            if (randNum == 4)
            {
                Instantiate(ObstObj, new Vector3(1, 3.25f, zScenePos), ObstObj.rotation);
            }
            if (randNum == 5)
            {
                Instantiate(ObstObj, new Vector3(0, 3.25f, zScenePos), ObstObj.rotation);
            }

            Instantiate(bbNoPit, new Vector3(0, 2.25f, zScenePos), bbNoPit.rotation);
            zScenePos += 4;
        }

        timeTotal += Time.deltaTime;
		
        if(lvlCompStatus == "Fail")
        {
            waitToLoad += Time.deltaTime;
        }

        if(waitToLoad > 2)
        {
            SceneManager.LoadScene("LevelComp");
        }
	}
}
