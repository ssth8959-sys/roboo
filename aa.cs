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
    List<GameObject> bullets;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       // emnys = new List<GameObject>();
        //emnys2 = new List<GameObject>();

        tama = Bullet.name.Trim().ToLower();
        //Debug.Log(tama);
        me = transform.root.gameObject.name;

        bullets = new List<GameObject>();
       
      

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
      

    }

    // Update is called once per frame
    void Update()

    {//emnys = emnys.Where(x  => x != null).ToList();

        //GameObject allive1 = GameObject.Find("player1");
        //GameObject allive2 = GameObject.Find("player2");

   
     
            
            
                if (minnn < 25f)
                {
                    count += 1;
                    switch (wepon)
                    {
                        case wepons.bullet:

                            if (count % 90 == 0)
                            {

                            if (target == null)
                            {
                                
                            }

                          
                            if (target == null) return; //デバック
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
                            if (target == null)
                            {
                               
                            }
                            flyy = Instantiate(Bullet, transform.position, quaternion.identity);
                                fly f = flyy.GetComponent<fly>();
                                f.wepon = transform.root.gameObject;
                                f.target = target;
                        if (target == null) return; 
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
                            if (target == null) return; transform.LookAt(target.transform);

                            
                            }
                            break;

                    }
                
            }











        }
    }

    

