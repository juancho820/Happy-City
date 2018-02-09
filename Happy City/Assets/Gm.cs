using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Gm : MonoBehaviour {

    public static int coinTotal = 0;
    public static float timeTotal = 0;
    public float zScenePos = 60;
    public float posJug;

    public Text score;

    public Transform Proced1;
    public Transform Proced2;
    public Transform Proced3;
    public Transform player;
    public Transform ObstObj1;
    public Transform ObstObj2;
    public Transform ObstObj3;
    public Transform ObstObj4;
    public Transform CapsuleObj;
    public Transform CoinObj;

    public float randProced;
    public float randObj;
    public int randCarril;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {

        score.text = "Score: " + Gm.coinTotal;
        timeTotal += Time.deltaTime;

        posJug = player.transform.position.z;
        randProced = Random.Range(0, 3);

        if (zScenePos < 120+posJug)
        {
            

            if (randProced == 0)
            {
                Instantiate(Proced1, new Vector3(0, 2.25f, zScenePos), Proced1.rotation);
                for (int i = 0; i < 5; i++)
                {
                    randObj = Random.Range(0.0f, 5.0f);
                    randCarril = Random.Range(-1, 2);
                    if (randObj < 1)
                    {
                        Instantiate(ObstObj1, new Vector3(randCarril, 3.35f, zScenePos + Random.Range(-18,18)), ObstObj1.rotation);
                    }
                    if (randObj > 1 && randObj < 2)
                    {
                        Instantiate(ObstObj2, new Vector3(randCarril, 3.35f, zScenePos + Random.Range(-18, 18)), ObstObj2.rotation);
                    }
                    if (randObj > 2 && randObj < 3)
                    {
                        Instantiate(ObstObj3, new Vector3(randCarril, 3.35f, zScenePos + Random.Range(-18, 18)), ObstObj3.rotation);
                    }
                    if (randObj > 3 && randObj < 4)
                    {
                        Instantiate(CapsuleObj, new Vector3(randCarril, 3.35f, zScenePos + Random.Range(-18, 18)), CapsuleObj.rotation);
                    }
                    if (randObj > 4 && randObj < 5)
                    {
                        Instantiate(CoinObj, new Vector3(randCarril, 3.35f, zScenePos + Random.Range(-18, 18)), CoinObj.rotation);
                    }
                }
            }
            if (randProced == 1)
            {

                Instantiate(Proced2, new Vector3(0, 2.25f, zScenePos), Proced2.rotation);
                for (int i = 0; i < 5; i++)
                {
                    randObj = Random.Range(0.0f, 5.0f);
                    randCarril = Random.Range(-1, 2);
                    if (randObj < 1)
                    {
                        Instantiate(ObstObj1, new Vector3(randCarril, 3.35f, zScenePos + Random.Range(-18, 18)), ObstObj1.rotation);
                    }
                    if (randObj > 1 && randObj < 2)
                    {
                        Instantiate(ObstObj2, new Vector3(randCarril, 3.35f, zScenePos + Random.Range(-18, 18)), ObstObj2.rotation);
                    }
                    if (randObj > 2 && randObj < 3)
                    {
                        Instantiate(ObstObj3, new Vector3(randCarril, 3.35f, zScenePos + Random.Range(-18, 18)), ObstObj3.rotation);
                    }
                    if (randObj > 3 && randObj < 4)
                    {
                        Instantiate(CapsuleObj, new Vector3(randCarril, 3.35f, zScenePos + Random.Range(-18, 18)), CapsuleObj.rotation);
                    }
                    if (randObj > 4 && randObj < 5)
                    {
                        Instantiate(CoinObj, new Vector3(randCarril, 3.35f, zScenePos + Random.Range(-18, 18)), CoinObj.rotation);
                    }
                }
            }
            if (randProced == 2)
            {
                Instantiate(Proced3, new Vector3(0, 2.25f, zScenePos), Proced3.rotation);
                for (int i = 0; i < 5; i++)
                {
                    randObj = Random.Range(0.0f, 5.0f);
                    randCarril = Random.Range(-1, 2);
                    if (randObj < 1)
                    {
                        Instantiate(ObstObj1, new Vector3(randCarril, 3.35f, zScenePos + Random.Range(-18, 18)), ObstObj1.rotation);
                    }
                    if (randObj > 1 && randObj < 2)
                    {
                        Instantiate(ObstObj2, new Vector3(randCarril, 3.35f, zScenePos + Random.Range(-18, 18)), ObstObj2.rotation);
                    }
                    if (randObj > 2 && randObj < 3)
                    {
                        Instantiate(ObstObj3, new Vector3(randCarril, 3.35f, zScenePos + Random.Range(-18, 18)), ObstObj3.rotation);
                    }
                    if (randObj > 3 && randObj < 4)
                    {
                        Instantiate(CapsuleObj, new Vector3(randCarril, 3.35f, zScenePos + Random.Range(-18, 18)), CapsuleObj.rotation);
                    }
                    if (randObj > 4 && randObj < 5)
                    {
                        Instantiate(CoinObj, new Vector3(randCarril, 3.35f, zScenePos + Random.Range(-18, 18)), CoinObj.rotation);
                    }
                }
            }
            zScenePos += 36;
        }
	}
    public void Reiniciar()
    {
        SceneManager.LoadScene("Play");
    }
}
