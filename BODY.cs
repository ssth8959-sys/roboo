using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.Mathematics;
using UnityEngine;


public class BODY : MonoBehaviour
{
    public int MaxHP;
    GameObject wepon1;
    GameObject wepon2;
    GameObject wepon3;
    public GameObject enmy;
    public GameObject bullet;
    public int currentHP;
    string body;
    public int bulletdamage = 1;
    public int hoverdamage = 8;
    int level;
    int sucore;
    bool a, b, c;
    List<GameObject> emnys;
    List<float> emnydis;
    float min = 9999;
    GameObject minn;
    public int score = 0;
    List<string> weponsname;
    List<GameObject> wepons;
    int count = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MaxHP = 1000;
        currentHP = MaxHP;

        body = this.gameObject.name;

        emnys = new List<GameObject>();
        emnydis = new List<float>();
        wepons = new List<GameObject>();
        weponsname = new List<string>() { "wepon1", "wepon2"};

        if (body == "player1")
        {
            enmy = GameObject.Find("player2");


            emnys = GameObject.FindGameObjectsWithTag("emny2").ToList();
            emnys.Add(enmy);

        }
        if (body == "player2")
        {
            enmy = GameObject.Find("player1");
            emnys = GameObject.FindGameObjectsWithTag("emny1").ToList();
            emnys.Add(enmy);



        }
        
   


        foreach (string obj in weponsname)
        {
            
            
                wepons.Add(transform.Find(obj).gameObject);
        

        }
        Debug.Log(wepons[0].name);
        Debug.Log(wepons[1].name);
    }





    // Update is called once per frame
    void Update()
    {
        float dis = Vector3.Distance(transform.position, enmy.transform.position);
        //if (emnys.Count != 10)
        //{
        //    if (body == "body")


        //      for (int i = 0; i < 10 - emnys.Count; i++)
        //    {

        //      emnys.Add(GameObject.Find("emny2(Clone)"));
        //}


        //            if (body == "player2")
        //          {
        ////          ;
        //         for (int i = 0; i < 10 - emnys.Count; i++)
        //       {
        //         emnys.Add(GameObject.Find("emny1(Clone)"));
        ///   }

        //            }
        //      }
        ///Debug.Log(emnys.Count);
        //Debug.Log(emnydis.Count);
        count++;
        if (count % 100 == 0)
        {
            foreach (GameObject i in emnys)
            {
                if (i != null)
                {
                    float diss = Vector3.Distance(transform.position, i.transform.position);

                    if (diss < min)
                    {
                        min = diss;
                        minn = i;
                    }
                }


            }

            foreach (GameObject i in wepons)
            {
                i.GetComponent<aa>().target = minn;
                i.GetComponent<aa>().minnn = min;

            }

        }

        if (enmy != null)
        {
            // Debug.Log(emnydis.Max() + "and" + emnydis.Min() + dis);
            if (minn != null)
            {
                if (dis > min && min > 15f)
                {
                    //Debug.Log("sceceeeeeeeee");
                    transform.LookAt(minn.transform);
                    Vector3 vec = minn.transform.position - transform.position;
                    transform.position += vec.normalized * 0.9f * Time.deltaTime;

                }
                else if (dis < min && dis > 15f)
                {

                    transform.LookAt(enmy.transform);
                    Vector3 vec = enmy.transform.position - transform.position;
                    transform.position += vec.normalized * 0.9f * Time.deltaTime;

                }
            }
        }
        
        
        if (currentHP <= 0)
        {
            Destroy(gameObject);
        }
        
        skill(a, b, c);
    }
    public void damaged(string n)
    {
        Debug.Log(n);
        if (n == "bullet (Clone)")
        {
            currentHP -= bulletdamage;
            //Debug.Log(currentHP);
        }
        else if (n == "hover(Clone)")
        {
            currentHP -= hoverdamage;
        }
        else
        {
            //‰ñ”ð
            Debug.Log("!");
        }

        skill(a, b, c);
    }
    public void attack(GameObject bullet)
    {


        Instantiate(bullet, transform.position, quaternion.identity);
    }
    IEnumerator heal()
    {
        while (currentHP != MaxHP)
        {
            int r = UnityEngine.Random.Range(0, 10);
            if (r <= 1)
            {
                currentHP = +20;
                if (currentHP > MaxHP)
                {
                    currentHP = MaxHP;
                }
                //animation
            }
            yield return new WaitForSeconds(1f);



        }
    }
    void skill(bool a, bool b, bool c)
    {
        if (a == true)
        {

        }
        if (b == true)
        {

        }
        if (c == true)
        {

        }

    }
    public void getskill()
    {

    }
    public void emnyreset()
    {
        emnys.Clear();

        if (body == "player2")
        {
       

            emnys = GameObject.FindGameObjectsWithTag("emny2").ToList();


        }
        if (body == "player2")
        {

            emnys = GameObject.FindGameObjectsWithTag("emny1").ToList();
        }
    }
    public void addemny(GameObject n)
    {
        emnys.Add(n);

    }
    public void getscore(GameObject n)
    {
        score++;
    }
}









