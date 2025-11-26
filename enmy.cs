using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class enmy : MonoBehaviour
{
    public int HP;
    public int currentHP;
    public GameObject emny;
    Component emnyy;
    public int bulletdamage = 1;
    public int hoverdamage = 8;
    string me;
    List<GameObject> emnys;
    List <float> emnydis;
    GameObject minn;
    float min = 9999;
    int count;
    public GameObject playeremny;
    List<GameObject> allemny;
    bool o = true;
    float dis;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HP = 50;
        currentHP = HP;
        emnys = new List<GameObject>();
        emnydis = new List<float>();
        allemny = new List<GameObject>();

        me = this.gameObject.name;
        if (me == "emny1(Clone)")
        {
            emny = GameObject.Find("emny2(Clone)");
            enmy emnyy = emny.GetComponent<enmy>();  
            playeremny = GameObject.Find("player2");
            emnys = GameObject.FindGameObjectsWithTag("emny2").ToList();
            foreach (GameObject e in emnys)
            {
                allemny.Add(e);
            }
            allemny.Add(playeremny);
                
        }
        if (me == "emny2(Clone)")
        {
            emny = GameObject.Find("emny1(Clone)");
            playeremny = GameObject.Find("player1");
            emnys = GameObject.FindGameObjectsWithTag("emny1").ToList();
            foreach (GameObject e in emnys)
            {
                allemny.Add(e);
            }
            allemny.Add(playeremny);
        }

    }

    // Update is called once per frame
    void Update()
    {
        allemny = allemny.Where(x => x != null).ToList();

        count++;
        if (count % 100 == 0)
        {
            min = 9999;
            minn = null;
            dis = Vector3.Distance(transform.position, playeremny.transform.position);
            foreach (var i in allemny)
            {
                if (i != null)
                {
                    if (i.activeInHierarchy == true)
                    {
                        float diss = Vector3.Distance(transform.position, i.transform.position);
                        //emnydis.Add(diss);
                        if (diss < min)
                        {
                            min = diss;
                            minn = i;

                        }
                    }
                }


            }
        }
        if (minn != null)
        {
            gameObject.GetComponentInChildren<emnyattackk>().target = minn;
            gameObject.GetComponentInChildren<emnyattackk>().dis = min;

        }


        if (minn != null)
        {
            //Debug.Log(emnydis.Max() + "and" + emnydis.Min() + dis);
            //if(emny.name == "player2")
            //{
            //  Debug.Log("the emny is player1");
            //}
            if (dis > min && min > 1f) //|| dis == min && min > 1f)
            {

                transform.LookAt(minn.transform);
                Vector3 vecc = minn.transform.position - transform.position;
                transform.position += vecc.normalized * 1.3f * Time.deltaTime;



            }
            else if (dis < min && dis > 1f || dis == min && min > 1f)
            {

                transform.LookAt(playeremny.transform);
                Vector3 vecc = playeremny.transform.position - transform.position;
                transform.position += vecc.normalized * 1.3f * Time.deltaTime;

            }
        }


        
            if (currentHP <= 0)
            {

                GameObject.Find("enmyspon").GetComponent<enmyspon>().death(this.gameObject);
                if (this.gameObject.name == "emny1(Clone)")
                {
                    if (GameObject.Find("player2").GetComponent<BODY>() != null)
                    {
                        GameObject.Find("player2").GetComponent<BODY>().getscore(this.gameObject);
                    }
                }
                if (this.gameObject.name == "emny2(Clone)")
                {
                    if (GameObject.Find("player1").GetComponent<BODY>() != null)
                    {
                        GameObject.Find("player2").GetComponent<BODY>().getscore(this.gameObject);
                    }


                }



            }

            if(gameObject.activeInHierarchy == false)
        {
            int a = 0;
            a++;
            if(a % 1000 == 0)
            {
                if(this.gameObject.name == "emny1(Clone)")
                {
                    transform.position = GameObject.Find("tower1").transform.position + new Vector3(0, 0, 3);
                }
            }
        }

        
    }
    public void damagedd(string n)
    {
        
        if (n == "bullet (Clone)")
        {
            currentHP -= bulletdamage;
            //Debug.Log(currentHP);
        }
        else if (n == "hover(Clone)")
        {
            currentHP -= hoverdamage;
        }
        else if(n == "emnyattack")
        {
            currentHP -= 1;
        }
        {
           
        }
    }
}
