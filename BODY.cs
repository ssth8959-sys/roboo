using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.Mathematics;
using Unity.VisualScripting;
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
    bool a, b, c ,d ,e= false;
    List<GameObject> emnys;
    List<float> emnydis;
    float min = 9999;
    GameObject minn;
    public int score = 0;
    List<string> weponsname;
    List<GameObject> wepons;
    public TMP_Text hppopup;
    int count = 0;
    int deathcount = 0;
    List<int> number;
    List<int> random;
    List<int> tower;
  
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
        number = new List<int>() { 1, 2, 3, 4 };
        random = new List<int>() {1, 2, 3, 4 };
        tower = new List<int>();
        Debug.Log(body);
        //foreach (int i in number)
        //{
          //  int c = 3;
            //int r = UnityEngine.Random.Range(0, c);
            //int rr = random[r];

           // tower[random[rr]] = i;
            //random.Remove(random[r]);
            //Debug.Log(random.Count);
            //c -= 1;

        //}






        if (body == "player1")
        {
           
            enmy = GameObject.Find("player2");
            


            emnys = GameObject.FindGameObjectsWithTag("emny1").ToList();
            emnys.Add(enmy);

        }
        if (body == "player2")
        {
            enmy = GameObject.Find("player1");
            emnys = GameObject.FindGameObjectsWithTag("emny2").ToList();
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



       
        emnys = emnys.Where(x => x != null).ToList();
        if (!emnys.Contains(enmy))
        {
            emnys.Add (enmy);
        
        }

        count++;

        float dis = Vector3.Distance(transform.position, enmy.transform.position);



        if (count % 100 == 0)
        {
            min = 9999;
            minn = null;
            foreach (GameObject i in emnys)
            {
                if (i != null) 
                {
                    if (i.activeInHierarchy == true)
                    {
                        float diss = Vector3.Distance(transform.position, i.transform.position);

                        if (diss < min)
                        {
                            min = diss;
                            minn = i;
                        }
                    }
                }
                
                
            }


            if (minn == null) return;
            


            foreach (GameObject i in wepons)
            {
               
                if (minn == null) break;
              
                
                    
                i.GetComponent<aa>().target = minn;
                i.GetComponent<aa>().minnn = min;


            }
            }
     
        

            if (enmy != null)
        {
            // Debug.Log(emnydis.Max() + "and" + emnydis.Min() + dis);

            if (minn != null)
            {
                if (minn.activeInHierarchy == true)
                {
                    if (!enmy.activeInHierarchy && emnys.Count < 15)
                    {

                        //transform.LookAt("")
                        Vector3 vec = minn.transform.position - transform.position;
                        transform.position += vec.normalized * 1.5f * Time.deltaTime;


                    }
                    else if (dis > min && min > 15f)//|| dis == min && min > 3f)
                    {
                        //Debug.Log("sceceeeeeeeee");
                        transform.LookAt(minn.transform);
                        Vector3 vec = minn.transform.position - transform.position;
                        transform.position += vec.normalized * 0.9f * Time.deltaTime;

                    }
                    else if (dis < min && dis > 15f || dis == min && min > 3f)
                    {

                        transform.LookAt(enmy.transform);
                        Vector3 vec = enmy.transform.position - transform.position;
                        transform.position += vec.normalized * 0.9f * Time.deltaTime;

                    }
                }
            }
        }
        
        //プレイヤー死亡処理
        if (currentHP <= 0)
        {
            gameObject.SetActive(false);
            deathcount++;
                if (deathcount % 800 == 0) {
                currentHP = MaxHP;
                gameObject.SetActive(true);
                }
        }
        //パッシフ系スキル処理
        skill(a, b, c);
    }
    //ダメージ関連処理
    public void damaged(string n)
    {
        
        if (n == "bullet (Clone)")
        {
            if (d)
            {
                hppopup.text = "MISS" ;
                Instantiate(hppopup, transform.position, quaternion.identity);
                transform.position += new Vector3(0, 0, 3); 
            }
            currentHP -= bulletdamage;
          
            //Debug.Log(currentHP);
        }
        else if (n == "hover(Clone)")
        {
            if (d)
            {
                hppopup.text = "MISS";
                Instantiate(hppopup, transform.position, quaternion.identity);
                transform.position += new Vector3(0, 0, 3);
            }
            else
            {
                currentHP -= hoverdamage;
            }
                
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
    //以下、ガチャボーナス
    void skill(bool a, bool b, bool c)
    {
        if (a == true)
        {
            if (count % 1500 == 0)
            {
                gameObject.GetComponent<BODY>().currentHP += 15;
            }
        }
        if (b == true)
        {
            if (count % 1500 == 0)
            {
                gameObject.GetComponent<BODY>().currentHP += 15;
            }

        }
        if (c == true)
        {
            ;
        } }
    public void addwepon()
    {
        if (!GameObject.Find("rendomwepon1").activeInHierarchy)
        {
            GameObject.Find("rendomwepon1").SetActive(true);

        }
        else if (!GameObject.Find("rendomwepon2").activeInHierarchy)
        {
            GameObject.Find("rendomwepon2").SetActive(true);

        }
        else 
        {
            GameObject.Find("rendomwepon3").SetActive(true);


        }
    }


    //emnyが死亡したときのリストのリセット
    public void emnyreset()
    {
        emnys.Clear();

        if (body == "player2")
        {
       

            emnys = GameObject.FindGameObjectsWithTag("emny2").ToList();


        }
        if (body == "player1")
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









