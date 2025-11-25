using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class aa : MonoBehaviour
{
    public GameObject Bullet;
    GameObject flyy;
    public GameObject target;
    public string tama;
    int count;
    string me;
    enum wepons { bullet, misail, lazer, hover };
    wepons wepon;
    List<GameObject> emnys;
    List<GameObject> emnys2;
    public float minnn;
    GameObject min;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        emnys = new List<GameObject>();
        emnys2 = new List<GameObject>();

        tama = Bullet.name.Trim().ToLower();
        //Debug.Log(tama);
        me = transform.root.gameObject.name;
        //if (me == "player1")
        //{
        //   target = GameObject.Find("player2");
        //}//
        //if(me == "player2")
        //{
        //  target = GameObject.Find("player1");
        //}

        //if(tama != "bullet") { Debug.Log(33333333); }
        if (tama == "bullet")
        {
            wepon = wepons.bullet;
        }
        else if (tama == "misail")
        {
            wepon = wepons.misail;
        }
        else if (tama == "hover")
        {
            wepon = wepons.hover;
        }
        else
        {
            wepon = wepons.lazer;
        }
        //if(wepon == wepons.bullet) { Debug.Log( "11111"); }
        //if(wepon != wepons.bullet) { Debug.Log("22222"); }

    }

    // Update is called once per frame
    void Update()

    {
        GameObject allive1 = GameObject.Find("player1");
        GameObject allive2 = GameObject.Find("player2");

        //if (emnys.Count < 11)
        {
            //  emnys = GameObject.FindGameObjectsWithTag("emny1").ToList();
        }
        //if (emnys2.Count < 11)
        //{
        //  emnys2 = GameObject.FindGameObjectsWithTag("emny2").ToList();
        //}
        //if (me == "player1")
        //{
        //  emnys2.Add(allive2);
        //}
        //if (me == "player2")
        //{
        //    emnys.Add(allive1);
        //}
        //if (me == "player2")
        //{
        //  foreach (var emny in emnys)
        {
            //    float ve = Vector3.Distance(transform.position, emny.transform.position);
            //  if (ve < minnn)
            //{
            //  minnn = ve;
            //target = emny;
            //}
            //}
            //}
            //if (me == "player1")
            //{
            //  foreach (var emny in emnys2)
            // {
            //   float ve = Vector3.Distance(transform.position, emny.transform.position);
            //     if (ve < minnn)

            // {
            //   minnn = ve;
            // target = emny;
            // }

            //}
            //}
            if (target != null)
            {
                if (minnn < 25f)
                {
                    count += 1;
                    switch (wepon)
                    {
                        case wepons.bullet:

                            if (count % 15 == 0)
                            {

                                flyy = Instantiate(Bullet, transform.position, quaternion.identity);
                                fly f = flyy.GetComponent<fly>();
                                f.wepon = transform.root.gameObject;
                                f.target = target;
                                f.minnn = minnn;
                                transform.LookAt(target.transform);

                            }
                            break;
                        case wepons.hover:
                            if (count % 750 == 0)
                            {
                                flyy = Instantiate(Bullet, transform.position, quaternion.identity);
                                fly f = flyy.GetComponent<fly>();
                                f.wepon = transform.root.gameObject;
                                f.target = target;
                                transform.LookAt(target.transform);
                            }
                            break;
                        case wepons.misail:
                            if (count % 150 == 0)
                            {
                                flyy = Instantiate(Bullet, transform.position, quaternion.identity);
                                fly f = flyy.GetComponent<fly>();
                                f.wepon = transform.root.gameObject;
                                f.target = target;
                                transform.LookAt(GameObject.Find(target.name).transform);
                            }
                            break;
                    }
                }
            }











        }
    }
}
    

