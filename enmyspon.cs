using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class enmyspon : MonoBehaviour
{
    int n;
    public GameObject emny1;
    public GameObject emny2;
    int count;
    List<GameObject> enmys; 
    List<GameObject> enmys2;
    GameObject h;
    GameObject hh;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enmys = new List<GameObject>();
        enmys2  = new List<GameObject>();

        spon();
        
    }

    // Update is called once per frame
    void Update()
    {
        //count++;
        
        //if (count % 300 == 0) {
            //if (enmys.Count < 10)
            //{
              //  enmys.Add( Instantiate(emny1, (GameObject.Find("tower").transform.position) + new Vector3(0, 0, UnityEngine.Random.Range(1, 10)),  Quaternion.identity));
                //GameObject.Find("player1").GetComponent<BODY>().addemny(enmys[enmys.Count - 1]);
            //}
            //if (enmys2.Count < 10)
            //{
              //  enmys2.Add( Instantiate(emny2, (GameObject.Find("tower").transform.position) + new Vector3(0, 0, UnityEngine.Random.Range(1, 10)),  Quaternion.identity));
                //GameObject.Find("player2").GetComponent<BODY>().addemny(enmys[enmys.Count - 1]);

          //  }
        }
    
    public  void death(GameObject enmy)
    {
        

        enmys.Remove(enmy);

        GameObject.Find("player1").GetComponent<BODY>().emnyreset();
        GameObject.Find("player2").GetComponent<BODY>().emnyreset();
        Destroy(enmy);







    }
    void spon()
    {

        for (int i = 0; i < 10; i++)
        {


            h = Instantiate(emny1, (GameObject.Find("tower").transform.position) + new Vector3(0, 0, UnityEngine.Random.Range(1, 10)), Quaternion.identity);
            enmys.Add(h);
            hh = Instantiate(emny2, (GameObject.Find("tower2").transform.position) + new Vector3(0, 0, UnityEngine.Random.Range(1, 10)), Quaternion.identity);
            enmys2.Add(h);
        }
    }
}