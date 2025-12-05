using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class enmyspon : MonoBehaviour
{
   
    public GameObject emny1;
    public GameObject emny2;
    int count;
    List<GameObject> enmys; 
    List<GameObject> enmys2;
    GameObject h;
    GameObject hh;
    int deathcoubt;
    public GameObject g; 
   public bool c;
    int deathcount;
    Vector3 towerposition;
    Vector3 tower2position;
 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enmys = new List<GameObject>();
        enmys2  = new List<GameObject>();
     
        spon();
        towerposition = GameObject.Find("tower").transform.position;
        tower2position = GameObject.Find("tower2").transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        death();
        waiting.RemoveAll(d => !d.c);
     

    }

   
    void spon()
    {

        for (int i = 0; i < 8; i++)
        {


            h = Instantiate(emny1, (GameObject.Find("tower").transform.position) + new Vector3(0, 0, UnityEngine.Random.Range(1, 10)), Quaternion.identity);
            //GameObject.Find("player1").GetComponent<BODY>().emnys.Add(h);
            GameObject.Find("player1").GetComponent<BODY>().addemny(hh);
            hh = Instantiate(emny2, (GameObject.Find("tower2").transform.position) + new Vector3(0, 0, UnityEngine.Random.Range(1, 10)), Quaternion.identity);
            //GameObject.Find("player2").GetComponent<BODY>().emnys.Add(hh);
            GameObject.Find("player2").GetComponent<BODY>().addemny(h);
            h = Instantiate(emny1, (GameObject.Find("tower1").transform.position) + new Vector3(0, 0, UnityEngine.Random.Range(1, 10)), Quaternion.identity);
            //GameObject.Find("player1").GetComponent<BODY>().emnys.Add(h);
            GameObject.Find("player1").GetComponent<BODY>().addemny(hh);
            hh = Instantiate(emny2, (GameObject.Find("tower2 (1)").transform.position) + new Vector3(0, 0, UnityEngine.Random.Range(1, 10)), Quaternion.identity);
            //GameObject.Find("player2").GetComponent<BODY>().emnys.Add(hh);
            GameObject.Find("player2").GetComponent<BODY>().addemny(h);
            h = Instantiate(emny1, (GameObject.Find("tower1 (1)").transform.position) + new Vector3(0, 0, UnityEngine.Random.Range(1, 10)), Quaternion.identity);
            //GameObject.Find("player1").GetComponent<BODY>().emnys.Add(h);
            GameObject.Find("player1").GetComponent<BODY>().addemny(hh);
            hh = Instantiate(emny2, (GameObject.Find("tower2 (2)").transform.position) + new Vector3(0, 0, UnityEngine.Random.Range(1, 10)), Quaternion.identity);
            //GameObject.Find("player2").GetComponent<BODY>().emnys.Add(hh);
            GameObject.Find("player2").GetComponent<BODY>().addemny(h);
        }
       



        

    }
    //à»â∫éÄñSÇ∆ïúäàÇÃèàóù
    public class deathemny
    {
        public GameObject g;
        public bool c;
        public int deathtime;
    }

    List<deathemny> waiting = new List<deathemny>();

        public void deathdata(GameObject a , bool b)
        {
        waiting.Add(new deathemny
        {
            g = a,
            c = b,
            deathtime = 0
        });

              

         }

          public void death(){
            foreach(var i in waiting)
             
            {
                if (i.c)
                    {
                i.g.SetActive(false);
                i.deathtime++;
                }
             
                if(i.deathtime % 50000 == 0 && !i.g.activeInHierarchy)
                {
                i.g.GetComponent<enmy>().currentHP = i.g.GetComponent<enmy>().HP;
                i.g.SetActive(true);
                if (i.g.name == "emny1(Clone)")
                {
                    i.g.transform.position = towerposition;
                }
                if (i.g.name == "emny2(Clone)")
                {
                    i.g.transform.position = tower2position;

                }
                i.c = false;
                i.deathtime = 0;
            }
          
            }
        }
        }
    
