using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using TMPro;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.InputSystem.HID;
using UnityEngine.UIElements;
using static Unity.Burst.Intrinsics.Arm;


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
    bool a = false, b = false, c = false;
    public List<GameObject> emnys;
    List<float> emnydis;
    float min = 9999;
    GameObject minn;
    public int score = 0;
    List<string> weponsname;
    List<GameObject> wepons;
    public TMP_Text hppopup;
    int count = 0;
    List<GameObject> childwepon;
    List<bool> skills;
    public List<GameObject> towers;
    List<int> tower;
    List<bool> active;
    bool a1 = true, a2 = true, a3 = true;
    bool aa = false, bb = false, cc = false;
    bool heal = false, teleport = false, avoid = false, ADDwepon1 = false, ADDwepon2 = false, ADDwepon3 = false;
    int r;
    List<int> skillset;
    public List<string> skillsname;
    public List<string> sskills;
    public GameObject healeffect;
    public GameObject avoideffect;
    public GameObject misseffact;
    public GameObject teleporteffact;
    Vector3 positionn;
    bool keya = true, keyb = true, keyc = true, keyaa = true, keybb = true, keycc = true;
    List<int> skillnumbers;
    // Start is called once before th;e first execution of Update after the MonoBehaviour is created
    void Start()
    {


        MaxHP = 800;
        currentHP = MaxHP;

        body = this.gameObject.name;
        skills = new List<bool>() { a, b, c, aa, bb, cc };
        emnys = new List<GameObject>();
        emnydis = new List<float>();
        wepons = new List<GameObject>();
        active = new List<bool>() { a1, a2, a3 };
        weponsname = new List<string>() { "wepon1", "wepon2", "randomwepon1", "randomwepon2", "randomwepon3" };
        childwepon = new List<GameObject>();
        skillset = new List<int>();
        sskills = new List<string>();
        skillsname = new List<string>() { "heal", "teleport", "avoid", "ADDwepon1", "ADDwepon2", "ADDwepon3" };


        skillnumbers = new List<int>() { 0, 1, 2, 3, 4, 5 };








        foreach (Transform child in this.transform)
        {
            childwepon.Add(child.gameObject);
            //Debug.Log("Child name: " + child.name);
        }


        if (body == "player1")
        {

            enmy = GameObject.Find("player2");



            emnys = GameObject.FindGameObjectsWithTag("emny2").ToList();

            Debug.Log(emnys.Count + "emnys");
            emnys.Add(enmy);

        }
        if (body == "player2")
        {
            enmy = GameObject.Find("player1");
            emnys = GameObject.FindGameObjectsWithTag("emny1").ToList();

            Debug.Log(emnys.Count + "emnys");
            emnys.Add(enmy);



        }

        foreach (Transform child in this.transform)
        {
            childwepon.Add(child.gameObject);
        }


        foreach (string obj in weponsname)
        {


            wepons.Add(transform.Find(obj).gameObject);


        }
        if (body == "player1")
        {

            enmy = GameObject.Find("player2");



            //emnys = GameObject.FindGameObjectsWithTag("emny2").ToList();



        }


        tower = new List<int>() { 0, 1, 2, 3 };
        for (int i = tower.Count - 1; i > 0; i--)
        {
            int r = UnityEngine.Random.Range(0, i + 1);
            int rr = tower[i];
            tower[i] = tower[r];
            tower[r] = rr;
        }
    }





    // Update is called once per frame
    void Update()
    {

        addwepon();
        skill();

        emnys = emnys.Where(x => x != null).ToList();
        //if (!enmy.activeInHierarchy)
        //{
        //  if(emnys.Contains(enmy))
        //emnys.Remove(enmy);

        //}
        if (enmy.activeInHierarchy && !emnys.Contains(enmy))
        {
            emnys.Add(enmy);

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
                if (i != null)
                {


                    i.GetComponent<aa>().target = minn;
                    i.GetComponent<aa>().minnn = min;
                }

            }
        }
        foreach (string i in sskills)
        {
            Debug.Log(i);
        }


        if (enmy != null)
        {
            // Debug.Log(emnydis.Max() + "and" + emnydis.Min() + dis);tr

            if (minn != null)
            {
                if (minn.activeInHierarchy == true)
                {
                    if (!enmy.activeInHierarchy)
                    {
                        if (towers[tower[0]].activeInHierarchy)
                        {
                            if (towers[tower[0]] != null )
                            {

                              //  for (int i = 0; i == childwepon.Count - 1; i++)
                                //{
                                  //  childwepon[i].GetComponent<aa>().t = true;

//                                }
   foreach (GameObject i in wepons)
                                {
                                    if (i != null)
                                    {
                                        i.GetComponent<aa>().target = towers[tower[0]];
                                    }


                                }
                                transform.LookAt(towers[tower[0]].transform);
                                Vector3 vec = towers[tower[0]].transform.position - transform.position;
                                transform.position += vec.normalized * 1.5f * Time.deltaTime;

                            }


                        }
                        else if (towers[tower[1]].activeInHierarchy)
                        {
                            transform.LookAt(towers[tower[1]].transform);
                            Vector3 vec = towers[tower[1]].transform.position - transform.position;
                            transform.position += vec.normalized * 1.5f * Time.deltaTime;
                            foreach (GameObject i in wepons)
                            {
                                if (i != null)
                                    {
                                    i.GetComponent<aa>().target = towers[tower[1]];
                                }


                            }

                        }
                        else if (towers[tower[2]].activeInHierarchy)
                        {
                            transform.LookAt(towers[tower[2]].transform);
                            Vector3 vec = towers[tower[2]].transform.position - transform.position;
                            transform.position += vec.normalized * 1.5f * Time.deltaTime;
                            foreach (GameObject i in wepons)
                            {
                                if (i != null)
                                {
                                    i.GetComponent<aa>().target = towers[tower[2]];
                                }


                            }
                        }
                        else if (towers[tower[3]].activeInHierarchy)
                        {
                            transform.LookAt(towers[tower[3]].transform);
                            Vector3 vec = towers[tower[3]].transform.position - transform.position;
                            transform.position += vec.normalized * 1.5f * Time.deltaTime;
                            foreach (GameObject i in wepons)
                            {
                                if (i != null)
                                {
                                    i.GetComponent<aa>().target = towers[tower[3]];
                                }


                            }

                        }



                    }
                    else if (dis > min && min > 15f)//|| dis == min && min > 3f)
                    {
                        if (!enmy.activeInHierarchy) return; 
                        //Debug.Log("sceceeeeeeeee");
                        transform.LookAt(minn.transform);
                        Vector3 vec = minn.transform.position - transform.position;
                        transform.position += vec.normalized * 0.9f * Time.deltaTime;

                    }
                    else if (dis < min && dis > 15f || dis == min && min > 15f)
                    {
                        if (!enmy.activeInHierarchy) return;
                        transform.LookAt(enmy.transform);
                        Vector3 vec = enmy.transform.position - transform.position;
                        transform.position += vec.normalized * 0.9f * Time.deltaTime;

                    }
                }
            }









            //プレイヤー死亡処理
            if (currentHP <= 0)
            {
                if (this.gameObject.name == "player1")
                {
                    GameObject.Find("life").GetComponent<life>().g = this.gameObject;
                    GameObject.Find("life").GetComponent<life>().c = true;
                }
                if (this.gameObject.name == "player2")
                {
                    GameObject.Find("life").GetComponent<life>().g = this.gameObject;
                    GameObject.Find("life").GetComponent<life>().c = true;
                }

            }


            //パッシフ系スキル処理
            if (score >= 8 && a1)
            {
                int a = UnityEngine.Random.Range(0, skillsname.Count - 1);
                getskill(skillnumbers[a]);
            
                sskills.Add(skillsname[a]);
                skillsname.Remove(skillsname[a]);
                skillnumbers.Remove(skillnumbers[a]);


                a1 = false;
            }
            if (score >= 15 && a2)
            {
                // int a = UnityEngine.Random.Range(0, skills.Count - 2);

                getskill(4);
                sskills.Add(skillsname[4]);
                skillsname.Remove(skillsname[4]);
                a2 = false;
            }
            if (score > 25 && a3)
            {
                int a = UnityEngine.Random.Range(0, skillsname.Count -1);
                getskill(skillnumbers[a]);
                sskills.Add(skillsname[a]);
                skillsname.Remove(skillsname[a]);
                skillnumbers.Remove(skillnumbers[a]);
                a3 = false;
            }
        }
    }


    //ダメージ関連処理
    public void damaged(string n)
    {
        if (n == "emnyattack")
        {
            currentHP -= 1;
        }

        else if (n == "bullet (Clone)")
        {
            int a = UnityEngine.Random.Range(0, 9);
            if (a < 2)
            {
                if (c)
                {
                    GameObject effact;
                    //hppopup.GetComponent<TMP_Text>().text = "MISS";
                    //Instantiate(hppopup, transform.position, quaternion.identity);
                    effact = Instantiate(misseffact, transform.position, quaternion.identity);
                    Destroy(effact, 3f);
                }
            }
            else
            {
                currentHP -= bulletdamage;
            }

            //Debug.Log(currentHP);

        }
        else if (n == "hover(Clone)")
        {
            int a = UnityEngine.Random.Range(0, 9);
            if (a < 2)
            {
                if (c)
                {
                    GameObject effact;
                    //hppopup.GetComponent<TMP_Text>().text = "MISS";
                    //Instantiate(hppopup, transform.position, quaternion.identity);
                    effact = Instantiate(misseffact, transform.position, quaternion.identity);
                    Destroy(effact, 0.3f);

                }
            }
            else
            {
                currentHP -= hoverdamage;
            }

        }


    }


    //    public void attack(GameObject bullet)
    //   {


    //     Instantiate(bullet, transform.position, quaternion.identity);
    //}

    //以下、ガチャボーナス
    void skill()
    {
        if (a == true)

        {
            if (enmy.activeInHierarchy)
            {
                if (count % 5000 == 0)
                {
                    currentHP += 10;
                    Debug.Log("+20!!");
                    if (currentHP > MaxHP)
                    {
                        GameObject effact;
                        currentHP = MaxHP;
                        effact = Instantiate(healeffect, transform.position, quaternion.identity);
                        Destroy(effact, 2f);
                    }
                }
            }
        }
        if (min < 15f && b == true)
        {
            Debug.Log("!!");

            if (b == true)
            {
                if (count % 5000 == 0)
                {
                    GameObject effact;
                    positionn = transform.position;
                    effact = Instantiate(teleporteffact, transform.position, quaternion.identity);
                    Destroy(effact, 2);
                    transform.position = enmy.transform.position + new UnityEngine.Vector3(0, 0, -5f);
                    effact = Instantiate(teleporteffact, transform.position, quaternion.identity);
                    Destroy(effact, 2);
                    transform.GetComponent<Collider>().enabled = false;
                    Invoke("returnposition", 2f);



                }
            }
        }

    }
    public void addwepon()
    {

        if (aa && !transform.Find("randomwepon1").gameObject.activeInHierarchy)
        {

            transform.Find("randomwepon1").gameObject.SetActive(true);


            aa = false;

        }
        if (bb)
        {
            transform.Find("randomwepon2").gameObject.SetActive(true);
            bb = false;

        }
        if (cc)
        {
            transform.Find("randomwepon3").gameObject.SetActive(true);
            cc = false;


        }
    }


    //emnyが死亡したときのリストのリセット
    public void emnyreset()
    {
        emnys.Clear();

        if (body == "player2")
        {


            emnys = GameObject.FindGameObjectsWithTag("emny1").ToList();


        }
        if (body == "player1")
        {

            emnys = GameObject.FindGameObjectsWithTag("emny2").ToList();
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
    void getskill(int index)
    {

        switch (index)
        {
            case 0: a = true; keya = false; break;
            case 1: b = true; keyb = false; break;
            case 2: c = true; keyc = false; break;
            case 3: aa = true; keyaa = false; break;
            case 4: bb = true; keybb = false; break;
            case 5: cc = true; keycc = false; break;

        }
    }
    void returnposition()
    {
        transform.position = positionn;
        transform.GetComponent<Collider>().enabled = true;
    }
}



































